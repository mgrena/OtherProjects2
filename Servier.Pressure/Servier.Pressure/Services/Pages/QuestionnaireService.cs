using Microsoft.AspNetCore.Components.Authorization;
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

    public async Task<InformedConsentCompetence> GetWorkplaceByUserIdAsync(string Id)
    {
        InformedConsentCompetence? InformedConsentCompetenceQuestionary = await _context.InformedConsentCompetences.FirstOrDefaultAsync(p => p.Id == Id);
        InformedConsentCompetenceQuestionary ??= new() {
            Id = string.Empty,
            IsConsent = true,
            IsAdult = true,
            IsStableHypertension = true,
            IsInformedConsent = true,
            IsAlreadyEnrolled = true,
            IsResistantHypertension = true,
            IsClinicalTrial = true,
            IsPregnant = true,
            VisitDate = DateTime.Now,
            ModifiedAt = DateTime.Now,
            CreatedAt = DateTime.Now,
        };
        return InformedConsentCompetenceQuestionary;
    }

    public async Task<OperationResult> SaveInformedConsentCompetenceQuestionaryAsync(InformedConsentCompetence informedconsentcompetence)
    {
        var InformedConsentCompetence = await _context.InformedConsentCompetences.FirstOrDefaultAsync(i => i.Id == informedconsentcompetence.Id);
        if (InformedConsentCompetence == null)
        {
            _logger.LogInformation("The informed consent competence for patient {user} has been added.", informedconsentcompetence.Id);
            _context.InformedConsentCompetences.Add(informedconsentcompetence);
        }
        else
        {
            _logger.LogInformation("The informed consent competence with id {id} has been updated.", informedconsentcompetence.Id);
            InformedConsentCompetence.IsConsent = informedconsentcompetence.IsConsent;
            InformedConsentCompetence.IsAdult = informedconsentcompetence.IsAdult;
            InformedConsentCompetence.IsStableHypertension = informedconsentcompetence.IsStableHypertension;
            InformedConsentCompetence.IsInformedConsent = informedconsentcompetence.IsInformedConsent;
            InformedConsentCompetence.IsAlreadyEnrolled = informedconsentcompetence.IsAlreadyEnrolled;
            InformedConsentCompetence.IsResistantHypertension = informedconsentcompetence.IsResistantHypertension;
            InformedConsentCompetence.IsClinicalTrial = informedconsentcompetence.IsClinicalTrial;
            InformedConsentCompetence.IsPregnant = informedconsentcompetence.IsPregnant;

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
