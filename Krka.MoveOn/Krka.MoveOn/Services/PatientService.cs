using Krka.MoveOn.Data;
using Microsoft.EntityFrameworkCore;

namespace Krka.MoveOn.Services
{
    public class PatientService(ApplicationDbContext context)
    {
        private readonly ApplicationDbContext _context = context;

        public async Task<List<Data.Patient>> GetPatientsAsync()
        {
            return await _context.Patients.ToListAsync();
        }

        public Task InsertEmployeeAsync(IDictionary<string, object> newValues)
        {
            return null;
        }
        public Task InsertEmployeeAsync(Patient newDataItem)
        {
            return null;
        }
        public Task RemoveEmployeeAsync(Patient dataItem)
        {
            return null;
        }
        public Task UpdateEmployeeAsync(Patient dataItem, IDictionary<string, object> newValues)
        {
            return null;
        }
        public Task UpdateEmployeeAsync(Patient dataItem, Patient newDataItem)
        {
            return null;
        }
    }
}
