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

    public async Task<InformedConsentCompetence> GetInformedConsentCompetenceByIdAsync(string Id)
    {
        InformedConsentCompetence? InformedConsentCompetenceQuestionary = await _context.InformedConsentCompetences.FirstOrDefaultAsync(p => p.Id == Id);
        InformedConsentCompetenceQuestionary ??= new() {
            Id = Id,
            IsConsent = true,
            IsAdult = true,
            IsStableHypertension = true,
            IsInformedConsent = true,
            IsAlreadyEnrolled = false,
            IsResistantHypertension = false,
            IsClinicalTrial = false,
            IsPregnant = false,
            VisitDate = DateTime.Now,
            ModifiedAt = DateTime.Now,
            CreatedAt = DateTime.Now,
        };
        return InformedConsentCompetenceQuestionary;
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
    public async Task<DemographyHistory> GetDemographyHistoryByIdAsync(string Id)
    {
        DemographyHistory? DemographyHistoryQuestionary = await _context.DemographyHistories.FirstOrDefaultAsync(p => p.Id == Id);
        DemographyHistoryQuestionary ??= new()
        {
            Id = Id,
            IsMan = true,
            Age = 50,
            ModifiedAt = DateTime.Now,
            CreatedAt = DateTime.Now,

        };
        return DemographyHistoryQuestionary;
    }
    public async Task<OperationResult> SaveDemographyHistoryQuestionaryAsync(DemographyHistory demographyhistory)
    {
        var DemographyHistory = await _context.DemographyHistories.FirstOrDefaultAsync(i => i.Id == demographyhistory.Id);
        if (DemographyHistory == null)
        {
            _logger.LogInformation("The informed consent competence for patient {user} has been added.", demographyhistory.Id);
            _context.DemographyHistories.Add(demographyhistory);
        }
        else
        {
            _logger.LogInformation("The informed consent competence with id {id} has been updated.", demographyhistory.Id);
            DemographyHistory.IsMan = demographyhistory.IsMan;
            DemographyHistory.Age = demographyhistory.Age;
            DemographyHistory.Smoker = demographyhistory.Smoker;
            DemographyHistory.Education = demographyhistory.Education;
            DemographyHistory.DiagnosisYear = demographyhistory.DiagnosisYear;
            DemographyHistory.DiagnosisYearUnknown = demographyhistory.DiagnosisYearUnknown;
            DemographyHistory.TreatmentYear = demographyhistory.TreatmentYear;
            DemographyHistory.TreatmentYearUnknown = demographyhistory.TreatmentYearUnknown;
            DemographyHistory.DiagnosisNone = demographyhistory.DiagnosisNone;
            DemographyHistory.DiagnosisDiabetes = demographyhistory.DiagnosisDiabetes;
            DemographyHistory.DiagnosisDyslipidemia = demographyhistory.DiagnosisDyslipidemia;
            DemographyHistory.DiagnosisICHS = demographyhistory.DiagnosisICHS;
            DemographyHistory.DiagnosisICHSInfarction = demographyhistory.DiagnosisICHSInfarction;
            DemographyHistory.DiagnosisICHSAngina = demographyhistory.DiagnosisICHSAngina;
            DemographyHistory.DiagnosisICHSAngiography = demographyhistory.DiagnosisICHSAngiography;
            DemographyHistory.DiagnosisICHSAngiographyType = demographyhistory.DiagnosisICHSAngiographyType;
            DemographyHistory.DiagnosisICHSRevascularization = demographyhistory.DiagnosisICHSRevascularization;
            DemographyHistory.DiagnosisICHSRevascularizationType = demographyhistory.DiagnosisICHSRevascularizationType;
            DemographyHistory.DiagnosisHeartFailure = demographyhistory.DiagnosisHeartFailure;
            DemographyHistory.DiagnosisFibrillation = demographyhistory.DiagnosisFibrillation;
            DemographyHistory.DiagnosisStroke = demographyhistory.DiagnosisStroke;
            DemographyHistory.DiagnosisArterialD = demographyhistory.DiagnosisArterialD;
            DemographyHistory.DiagnosisInsufficiency = demographyhistory.DiagnosisInsufficiency;
            DemographyHistory.DiagnosisKidneyD = demographyhistory.DiagnosisKidneyD;
            DemographyHistory.DiagnosisKidneyDType = demographyhistory.DiagnosisKidneyDType;


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
