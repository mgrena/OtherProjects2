using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.EntityFrameworkCore;
using Servier.Pressure.Data;
using Servier.Pressure.Data.Models;
using Servier.Pressure.Helpers;
using System.IdentityModel.Claims;

namespace Servier.Pressure.Services.Pages;

public class PatientService(IServiceScopeFactory scopeFactory, AuthenticationStateProvider authenticationStateProvider, ILogger<PatientService> logger)
{
    private readonly IServiceScopeFactory _scopeFactory = scopeFactory;
    private readonly AuthenticationStateProvider _authenticationStateProvider = authenticationStateProvider;
    private readonly ILogger _logger = logger;

    public async Task<List<Patient>> GetPatientsAsync()
    {
        using var scope = _scopeFactory.CreateScope();
        var aContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        var authState = await _authenticationStateProvider.GetAuthenticationStateAsync();
        var user = authState.User;
        List<Patient> patients;

        // get patients
        List<ApplicationUser> doctors = [.. aContext.Users];
        if (user.IsInRole("Doctor"))
        {
            var userId = user.FindFirst(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            doctors = await aContext.Users.Where(i => i.Id == userId).ToListAsync();

            patients = await aContext.Patients
                .Where(p => p.DeletedAt == null && p.UserId == userId)
                .OrderBy(p => p.Valid == Patient.ValidEnum.Predčasne_vylúčený)
                .ThenBy(p => p.PatientCode)
                .ToListAsync();
        }
        else if (user.IsInRole("Admin"))
        {
            doctors = [.. aContext.Users];
            patients = await aContext.Patients
               .Where(p => p.DeletedAt == null)
               .OrderBy(p => p.Valid == Patient.ValidEnum.Predčasne_vylúčený)
               .ThenBy(p => p.CreatedAt)
               //.ThenBy(p => p.PatientCode)
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
        using var scope = _scopeFactory.CreateScope();
        var aContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        return await aContext.Patients.FirstOrDefaultAsync(i => i.Id == id);
    }
    public async Task<OperationResult> SavePatientAsync(Patient patient)
    {
        using var scope = _scopeFactory.CreateScope();
        var aContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        var existEntry = await aContext.Patients.FirstOrDefaultAsync(i => i.Id == patient.Id);
        if (existEntry != null)
        {
            _logger.LogInformation("The patient with code {code} has been updated.", patient.PatientCode);
            existEntry.PatientName = patient.PatientName;
            existEntry.ModifiedAt = DateTime.Now;
        }

        try
        {
            await aContext.SaveChangesAsync();
            return OperationResult.SuccessResult();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, ex.Message);
            return OperationResult.FailureResult("Pri ukladaní údajov došlo k neočakávanej chybe.", ex.Message);
        }
    }
    public async Task DeletePatientAsync(string patientId)
    {
        using var scope = _scopeFactory.CreateScope();
        var aContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        var patient = await aContext.Patients.FindAsync(patientId);
        if (patient != null)
        {
            _logger.LogInformation("The patient with id {id} has been deleted.", patientId);
            patient.DeletedAt = DateTime.Now;
            aContext.Patients.Update(patient);
            await aContext.SaveChangesAsync();
        }
    }

}
