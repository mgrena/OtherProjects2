using Krka.MoveOn.Data;
using Krka.MoveOn.Data.Questionnaires;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.EntityFrameworkCore;
using System.IdentityModel.Claims;

namespace Krka.MoveOn.Services.Pages
{
    public class PatientService(ApplicationDbContext context, AuthenticationStateProvider authenticationStateProvider, ILogger<PatientService> logger)
    {
        private readonly ApplicationDbContext _context = context;
        private readonly AuthenticationStateProvider _authenticationStateProvider = authenticationStateProvider;
        private readonly ILogger _logger = logger;

        public int PatientCount { get; private set; }

        //public async Task<List<Patient>> GetPatientsAsync()
        //{
        //    var authState = await _authenticationStateProvider.GetAuthenticationStateAsync();
        //    var user = authState.User;

        //    List<Patient> patients;

        //    if (user.IsInRole("Doctor"))
        //    {
        //        var userId = user.FindFirst(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
        //        var users = await _context.Users.ToListAsync();
        //        var currUser = users.First(i => i.Id == userId);
        //        List<string> userIds = [];
        //        if (currUser.WorkplaceId == 1)
        //            userIds.Add(userId!);
        //        else
        //            userIds = users.Where(i => i.WorkplaceId == currUser.WorkplaceId).Select(i => i.Id).ToList();

        //        patients = await _context.Patients
        //            .Where(p => p.DeletedAt == null && userIds.Contains(p.UserId))
        //            .OrderBy(p => p.Valid == Patient.ValidEnum.Predčasne_vylúčený)
        //            .ThenByDescending(p => p.CreatedAt)
        //            .ToListAsync();
        //    }
        //    else if (user.IsInRole("Admin") || user.IsInRole("Office"))
        //    {
        //        patients = await _context.Patients
        //           .Where(p => p.DeletedAt == null)
        //           .OrderBy(p => p.Valid == Patient.ValidEnum.Predčasne_vylúčený)
        //           .ThenByDescending(p => p.CreatedAt)
        //           .ToListAsync();
        //    }
        //    else
        //    {
        //        patients = [];
        //    }

        //    foreach (var patient in patients)
        //    {
        //        var patientUser = _context.Users.FirstOrDefault(u => u.Id == patient.UserId);
        //        if (patientUser != null)
        //        {
        //            patient.Doctor = $"{patientUser.TitleBefore} {patientUser.FirstName} {patientUser.LastName} {patientUser.TitleAfter}";
        //        }
        //    }

        //    PatientCount = patients.Count(p => p.Valid == Patient.ValidEnum.Aktivný);

        //    return patients;
        //}

        public async Task<List<Patient>> GetPatientsAsync()
        {
            var authState = await _authenticationStateProvider.GetAuthenticationStateAsync();
            var user = authState.User;

            List<Patient> patients = new();

            IQueryable<Patient> baseQuery = _context.Patients.AsNoTracking().Where(p => p.DeletedAt == null);

            if (user.IsInRole("Doctor"))
            {
                var userId = user.FindFirst(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
                if (string.IsNullOrEmpty(userId))
                {
                    return new();
                }

                var currUser = await _context.Users.AsNoTracking().Where(u => u.Id == userId).Select(u => new { u.Id, u.WorkplaceId }).FirstOrDefaultAsync();

                if (currUser == null)
                {
                    return new();
                }

                List<string> allowedUserIds;
                if (currUser.WorkplaceId == 1)
                {
                    allowedUserIds = new() { currUser.Id };
                }
                else
                {
                    allowedUserIds = await _context.Users.AsNoTracking().Where(u => u.WorkplaceId == currUser.WorkplaceId).Select(u => u.Id).ToListAsync();
                }

                baseQuery = baseQuery.Where(p => allowedUserIds.Contains(p.UserId));
            }
            else if (user.IsInRole("Admin") || user.IsInRole("Office"))
            {
                patients = await _context.Patients.Where(p => p.DeletedAt == null).OrderBy(p => p.Valid == Patient.ValidEnum.Predčasne_vylúčený).ThenByDescending(p => p.CreatedAt).ToListAsync();
            }

            //1.Patients
            patients = await baseQuery.OrderBy(p => p.Valid == Patient.ValidEnum.Predčasne_vylúčený).ThenByDescending(p => p.CreatedAt).ToListAsync();

            //2.Doctor 
            var userIds = patients.Select(p => p.UserId).Distinct().ToList();

            var doctorsByUserId = await _context.Users.AsNoTracking().Where(u => userIds.Contains(u.Id)).Select(u => new { u.Id, FullName = (u.TitleBefore ?? "") + " " + u.FirstName + " " + u.LastName + " " + (u.TitleAfter ?? "") }).ToDictionaryAsync(x => x.Id, x => x.FullName.Trim());

            foreach (var p in patients)
            {
                if (doctorsByUserId.TryGetValue(p.UserId, out var doc))
                {
                    p.Doctor = doc;
                }
            }

            //3. Gen1 JOIN General01
            var patientIds = patients.Select(p => p.Id).ToList();

            var gen1ByPatientId = await (
                from q in _context.Questionnaires.AsNoTracking()
                join g in _context.QuestionnaireGeneral01s.AsNoTracking()
                    on q.Id equals g.Questionnaire_id
                where patientIds.Contains(q.PatientId)
                group g by q.PatientId into grp
                select new
                {
                    PatientId = grp.Key,
                    Gen1 = grp.Max(x => (DateTime?)x.Gen_1)
                }
            ).ToDictionaryAsync(x => x.PatientId, x => x.Gen1);

            foreach (var p in patients)
                p.Gen1 = gen1ByPatientId.TryGetValue(p.Id, out var gen1) ? gen1 : null;

            PatientCount = patients.Count(p => p.Valid == Patient.ValidEnum.Aktivný);

            //4. Date2st JOIN Questionnaire => order_num = ongoing
            var date2st = await _context.Questionnaires
                .AsNoTracking()
                .Where(q => patientIds.Contains(q.PatientId) && q.Order == Questionnaire.QuestionnaireOrderEnum.ongoing && q.ProgressPercentage != 0)
                .GroupBy(q => q.PatientId)
                .Select(g => new {
                    PatientId = g.Key,
                    Date = g.Max(x => (DateTime?)x.Date)
                })
                .ToDictionaryAsync(x => x.PatientId, x => x.Date);

            foreach (var p in patients)
                p.Date2st = date2st.TryGetValue(p.Id, out var dt) ? dt : null;

            //5. Date2st JOIN Questionnaire => order_num = result
            var date3st = await _context.Questionnaires
                .AsNoTracking()
                .Where(q => patientIds.Contains(q.PatientId) && q.Order == Questionnaire.QuestionnaireOrderEnum.result && q.ProgressPercentage != 0)
                .GroupBy(q => q.PatientId)
                .Select(g => new {
                    PatientId = g.Key,
                    Date = g.Max(x => (DateTime?)x.Date)
                })
                .ToDictionaryAsync(x => x.PatientId, x => x.Date);

            foreach (var p in patients)
                p.Date3st = date3st.TryGetValue(p.Id, out var dt) ? dt : null;

            return patients;
        }

        public async Task<Patient?> GetPatientByIdAsync(int patientId)
        {
            return await _context.Patients
                .FirstOrDefaultAsync(p => p.Id == patientId);
        }

        public async Task<List<ApplicationUser>> GetDoctorsAsync()
        {
            var doctorRole = await _context.Roles.FirstOrDefaultAsync(r => r.Name == "Doctor");
            if (doctorRole == null)
            {
                return [];
            }

            var doctorRoleId = doctorRole.Id;
            var doctorUserIds = await _context.UserRoles
                .Where(ur => ur.RoleId == doctorRoleId)
                .Select(ur => ur.UserId)
                .ToListAsync();

            var doctors = await _context.Users
                .Where(u => doctorUserIds.Contains(u.Id))
                .ToListAsync();

            return doctors;
        }

        public async Task<OperationResult> SavePatientAsync(Patient patient)
        {
            var doctorPatientCount = await _context.Patients
                    .CountAsync(p => p.UserId == patient.UserId && p.DeletedAt == null);
            var codecheck = await _context.Patients
                    .CountAsync(p => p.PatientCode == patient.PatientCode && p.DeletedAt == null);

            if (doctorPatientCount > 20)
            {
                _logger.LogError("The patient limit has been reached for user {UserName}.", patient.UserId);
                return OperationResult.FailureResult("Lekár môže pridať maximálne 20 pacientov.");
            }
            if (patient.Id == 0 && codecheck > 0)
            {
                _logger.LogError("Cannot insert duplicate key row in patients. Duplicate value is {patient.PatientCode}.", patient.PatientCode);
                return OperationResult.FailureResult($"Pacient so zadaným kódom {patient.PatientCode} už v databáze existuje. Záznam nie je možné uložiť.");
            }

            if (patient.Id == 0)
            {
                _logger.LogInformation("The patient with code {code} has been added.", patient.PatientCode);
                _context.Patients.Add(patient);
            }
            else
            {
                _logger.LogInformation("The patient with code {code} has been updated.", patient.PatientCode);
                _context.Patients.Update(patient);
            }

            try
            {
                await _context.SaveChangesAsync();
                return OperationResult.SuccessResult();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                var exx = ex;
                while (exx.InnerException != null)
                {
                    if (exx.Message.Contains("id_user"))
                        break;
                    exx = exx.InnerException;
                }
                string message = string.Empty;
                if (exx.Message.Contains("id_user"))
                    message = "Výber lekára je povinný.";
                else
                    message = exx.Message;
                return OperationResult.FailureResult("Pri ukladaní údajov došlo k neočakávanej chybe.", message);
            }
        }

        public async Task DeletePatientAsync(int patientId)
        {
            var patient = await _context.Patients.FindAsync(patientId);
            if (patient != null)
            {
                _logger.LogInformation("The patient with id {id} has been deleted.", patientId);
                patient.DeletedAt = DateTime.Now;
                _context.Patients.Update(patient);
                await _context.SaveChangesAsync();
            }
        }
    }

}
