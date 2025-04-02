using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.EntityFrameworkCore;
using Servier.Pressure.Data;
using Servier.Pressure.Data.Models;
using System.IdentityModel.Claims;

namespace Servier.Pressure.Services.Pages;

public class PatientService(ApplicationDbContext context, AuthenticationStateProvider authenticationStateProvider, ILogger<PatientService> logger)
{
    private readonly ApplicationDbContext _context = context;
    private readonly AuthenticationStateProvider _authenticationStateProvider = authenticationStateProvider;
    private readonly ILogger _logger = logger;

    public async Task<List<Patient>> GetPatientsAsync()
    {
        var authState = await _authenticationStateProvider.GetAuthenticationStateAsync();
        var user = authState.User;
        List<Patient> patients;

        // get patients
        List<ApplicationUser> doctors = [.. _context.Users];
        if (user.IsInRole("Doctor"))
        {
            var userId = user.FindFirst(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            doctors = await _context.Users.Where(i => i.Id == userId).ToListAsync();

            patients = await _context.Patients
                .Where(p => p.DeletedAt == null && p.UserId == userId)
                .OrderBy(p => p.Valid == Patient.ValidEnum.Predčasne_vylúčený)
                .ThenByDescending(p => p.CreatedAt)
                .ToListAsync();
        }
        else if (user.IsInRole("Admin"))
        {
            doctors = [.. _context.Users];
            patients = await _context.Patients
               .Where(p => p.DeletedAt == null)
               .OrderBy(p => p.Valid == Patient.ValidEnum.Predčasne_vylúčený)
               .ThenByDescending(p => p.CreatedAt)
               .ToListAsync();
        }
        else
        {
            patients = [];
        }

        // get doctors info

        foreach (var patient in patients)
        {
            var patientUser = doctors.FirstOrDefault(u => u.Id == patient.UserId);
            if (patientUser != null)
            {
                patient.Doctor = $"{patientUser.TitleBefore} {patientUser.FirstName} {patientUser.LastName} {patientUser.TitleAfter}";
            }
        }

        return patients;
    }
    public async Task<Patient?> GetPatientByIdAsync(string id)
    {
        return await _context.Patients.FirstOrDefaultAsync(i => i.Id == id);
    }
    public async Task DeletePatientAsync(string patientId)
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
