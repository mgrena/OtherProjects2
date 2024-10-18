using Krka.MoveOn.Data;
using Microsoft.EntityFrameworkCore;

namespace Krka.MoveOn.Services
{
    public class PatientService(ApplicationDbContext context)
    {
        private readonly ApplicationDbContext _context = context;

        public async Task<List<Data.Patient>> GetPatientsAsync()
        {
            return await _context.Patients
                .Where(p => p.DeletedAt == null)
                .ToListAsync();
        }

        public async Task SavePatientAsync(Patient patient)
        {
            if (patient.Id == 0)
            {
                _context.Patients.Add(patient);
            }
            else
            {
                _context.Patients.Update(patient);
            }
            await _context.SaveChangesAsync();
        }

        public async Task DeletePatientAsync(int patientId)
        {
            var patient = await _context.Patients.FindAsync(patientId);
            if (patient != null)
            {
                patient.DeletedAt = DateTime.Now;
                _context.Patients.Update(patient);
                await _context.SaveChangesAsync();
            }
        }
    }
}
