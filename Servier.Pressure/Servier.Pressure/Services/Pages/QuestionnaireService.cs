using Microsoft.EntityFrameworkCore;
using Servier.Pressure.Data;
using Servier.Pressure.Data.Lists;
using Servier.Pressure.Data.Models;
using Servier.Pressure.Helpers;

namespace Servier.Pressure.Services.Pages;

public class QuestionnaireService(ApplicationDbContext context, ILogger<QuestionnaireService> logger)
{
    private readonly ApplicationDbContext _context = context;
    private readonly ILogger _logger = logger;

    public async Task<TreatmentBefore?> GetTreatmentBeforeAsync(string patientId)
    {
        return await _context.TreatmentsBefore.FirstOrDefaultAsync(i => i.Id == patientId);
    }

    public async Task<List<DyslipidemiaDrug>> GetDyslipidemiaDrugsAsync()
    {
        return await _context.DyslipidemiaDrugs.OrderBy(i => i.Id).ToListAsync();
    }

    public async Task<OperationResult> SaveTreatmentBeforeAsync(TreatmentBefore entry)
    {
        var existEntry = await _context.TreatmentsBefore.FirstOrDefaultAsync(i => i.Id == entry.Id);
        if (existEntry == null)
        {
            _logger.LogInformation("The TreatmentBefore for patient {id} has been added.", entry.Id);
            _context.TreatmentsBefore.Add(entry);
        }
        else
        {
            _logger.LogInformation("The TreatmentBefore for patient {id} has been updated.", entry.Id);
            existEntry.DiagnosisDyslipidemiaDrug = entry.DiagnosisDyslipidemiaDrug;
            existEntry.GeneralPractitioner = entry.GeneralPractitioner;
            existEntry.Diabetologist = entry.Diabetologist;
            existEntry.Geriatrician = entry.Geriatrician;
            existEntry.Internist = entry.Internist;
            existEntry.Cardiologist = entry.Cardiologist;
            existEntry.Other = entry.Other;
            existEntry.FixCombination3Unknown = entry.FixCombination3Unknown;
            existEntry.FixCombinationMixUnknown = entry.FixCombinationMixUnknown;
            existEntry.ModifiedAt = DateTime.Now;
        }

        try
        {
            await _context.SaveChangesAsync();
            return OperationResult.SuccessResult();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, ex.Message);
            return OperationResult.FailureResult("Pri ukladaní údajov došlo k neočakávanej chybe.", ex.Message);
        }
    }

}
