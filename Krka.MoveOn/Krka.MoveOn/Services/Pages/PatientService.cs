using Krka.MoveOn.Data;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.EntityFrameworkCore;
using System.IdentityModel.Claims;

namespace Krka.MoveOn.Services.Pages
{
    public class PatientService(ApplicationDbContext context, AuthenticationStateProvider authenticationStateProvider, ILogger<UserService> logger)
    {
        private readonly ApplicationDbContext _context = context;
        private readonly AuthenticationStateProvider _authenticationStateProvider = authenticationStateProvider;
        private readonly ILogger _logger = logger;

        public int PatientCount { get; private set; }

        public async Task<List<Patient>> GetPatientsAsync()
        {
            var authState = await _authenticationStateProvider.GetAuthenticationStateAsync();
            var user = authState.User;
            List<Patient> patients;

            if (user.IsInRole("Doctor"))
            {
                var userId = user.FindFirst(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
                patients = await _context.Patients
                    .Where(p => p.DeletedAt == null && p.UserId == userId)
                    .OrderBy(p => p.Valid == Patient.ValidEnum.Predčasne_vylúčený)
                    .ThenByDescending(p => p.CreatedAt)
                    .ToListAsync();
            }
            else if (user.IsInRole("Admin") || user.IsInRole("Office"))
            {
                patients = await _context.Patients
                   .Where(p => p.DeletedAt == null)
                   .OrderBy(p => p.Valid == Patient.ValidEnum.Predčasne_vylúčený)
                   .ThenByDescending(p => p.CreatedAt)
                   .ToListAsync();
            }
            else
            {
                patients = new List<Patient>();
            }

            foreach (var patient in patients)
            {
                var patientUser = _context.Users.FirstOrDefault(u => u.Id == patient.UserId);
                if (patientUser != null)
                {
                    patient.Doctor = $"{patientUser.TitleBefore} {patientUser.FirstName} {patientUser.LastName} {patientUser.TitleAfter}";
                }
            }


            PatientCount = patients.Count(p => p.Valid == Patient.ValidEnum.Aktivný);

            return patients;
        }

        public async Task<List<ApplicationUser>> GetDoctorsAsync()
        {
            var doctorRole = await _context.Roles.FirstOrDefaultAsync(r => r.Name == "Doctor");
            if (doctorRole == null)
            {
                return new List<ApplicationUser>();
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

            if (doctorPatientCount > 20)
            {
                _logger.LogInformation("The patient limit has been reached for user {UserName}.", patient.UserId);
                return OperationResult.FailureResult("Lekár môže pridať maximálne 20 pacientov.");
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
            catch (DbUpdateException ex) when (ex.InnerException?.Message.Contains("UNIQUE constraint failed") == true)
            {
                _logger.LogError(ex, ex.Message);
                return OperationResult.FailureResult("Kód pacienta musí byť jedinečný.", ex.InnerException?.Message);
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
