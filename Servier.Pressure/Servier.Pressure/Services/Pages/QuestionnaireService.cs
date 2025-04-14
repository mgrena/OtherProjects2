using Microsoft.EntityFrameworkCore;
using Servier.Pressure.Data;
using Servier.Pressure.Data.Lists;
using Servier.Pressure.Data.Models;
using Servier.Pressure.Helpers;

namespace Servier.Pressure.Services.Pages;

public class QuestionnaireService(IServiceScopeFactory scopeFactory, ILogger<QuestionnaireService> logger)
{
    private readonly IServiceScopeFactory _scopeFactory = scopeFactory;
    private readonly ILogger _logger = logger;

    public async Task<InformedConsentCompetence> GetInformedConsentCompetenceByIdAsync(string Id)
    {
        using var scope = _scopeFactory.CreateScope();
        var aContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        InformedConsentCompetence? InformedConsentCompetenceQuestionary = await aContext.InformedConsentCompetences.FirstOrDefaultAsync(p => p.Id == Id);
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
        using var scope = _scopeFactory.CreateScope();
        var aContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        return await aContext.TreatmentsBefore.FirstOrDefaultAsync(i => i.Id == patientId);
    }
    public async Task<DemographyHistory> GetDemographyHistoryByIdAsync(string Id)
    {
        using var scope = _scopeFactory.CreateScope();
        var aContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        DemographyHistory? DemographyHistoryQuestionary = await aContext.DemographyHistories.FirstOrDefaultAsync(p => p.Id == Id);
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
    public async Task<PhysicalExamination1> GetPhysicalExamination1ByIdAsync(string Id)
    {
        using var scope = _scopeFactory.CreateScope();
        var aContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        var result = await aContext.PhysicalExaminations1.FirstOrDefaultAsync(p => p.Id == Id);
        result ??= new()
        {
            Id = Id,
            ModifiedAt = DateTime.Now,
            CreatedAt = DateTime.Now,

        };
        return result;
    }
    public async Task<PhysicalExamination2> GetPhysicalExamination2ByIdAsync(string Id)
    {
        using var scope = _scopeFactory.CreateScope();
        var aContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        var result = await aContext.PhysicalExaminations2.FirstOrDefaultAsync(p => p.Id == Id);
        result ??= new()
        {
            Id = Id,
            ModifiedAt = DateTime.Now,
            CreatedAt = DateTime.Now,

        };
        return result;
    }
    public async Task<LaboratoryTest> GetLaboratoryTestByIdAsync(string Id)
    {
        using var scope = _scopeFactory.CreateScope();
        var aContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        var result = await aContext.LaboratoryTests.FirstOrDefaultAsync(p => p.Id == Id);
        result ??= new()
        {
            Id = Id,
            ModifiedAt = DateTime.Now,
            CreatedAt = DateTime.Now,

        };
        return result;
    }
    public async Task<Treatment1Visit?> GetTreatment1VisitAsync(string patientId)
    {
        using var scope = _scopeFactory.CreateScope();
        var aContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        return await aContext.Treatments1Visit.FirstOrDefaultAsync(i => i.Id == patientId);
    }
    public async Task<Treatment2Visit?> GetTreatment2VisitAsync(string patientId)
    {
        using var scope = _scopeFactory.CreateScope();
        var aContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        return await aContext.Treatments2Visit.FirstOrDefaultAsync(i => i.Id == patientId);
    }
    public async Task<BloodPressureMonitor?> GetBloodPressureMonitorAsync(string patientId)
    {
        using var scope = _scopeFactory.CreateScope();
        var aContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        var result = await aContext.BloodPressureMonitors.FirstOrDefaultAsync(i => i.Id == patientId);
        result ??= new()
        {
            Id = patientId,
            ModifiedAt = DateTime.Now,
            CreatedAt = DateTime.Now,

        };
        return result;
    }

    public async Task<List<TreatmentMonotherapy>> GetTreatmentMonotherapiesAsync(string patientId, VisitEnum visitNum)
    {
        using var scope = _scopeFactory.CreateScope();
        var aContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        return await aContext.TreatmentMonotherapies.Where(i => i.PatientId == patientId && i.VisitNumber == visitNum).ToListAsync();
    }
    public async Task<List<TreatmentMultitherapy>> GetTreatmentMultitherapiesAsync(string patientId, VisitEnum visitNum)
    {
        using var scope = _scopeFactory.CreateScope();
        var aContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        return await aContext.TreatmentMultitherapies.Where(i => i.PatientId == patientId && i.VisitNumber == visitNum).ToListAsync();
    }
    public async Task<List<DayRecord>> GetDayRecordsAsync(string patientId)
    {
        using var scope = _scopeFactory.CreateScope();
        var aContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        return await aContext.DayRecords.Where(i => i.PatientId == patientId).ToListAsync();
    }
    public async Task<TreatmentUnknowns> GetTreatmentUnknownsAsync(string patientId, VisitEnum visitNum)
    {
        using var scope = _scopeFactory.CreateScope();
        var aContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

        TreatmentUnknowns result = new();
        switch (visitNum)
        {
            case VisitEnum.before:
                var before = await GetTreatmentBeforeAsync(patientId);
                if (before != null) 
                {
                    result.FixCombination3Unknown = before.FixCombination3Unknown;
                    result.FixCombinationMixUnknown = before.FixCombinationMixUnknown;
                }
                break;
            case VisitEnum.first:
                var visit1 = await GetTreatment1VisitAsync(patientId);
                if (visit1 != null) 
                {
                    result.IsChanged = visit1.IsChanged;
                    result.FixCombination3Unknown = visit1.FixCombination3Unknown;
                    result.FixCombinationMixUnknown = visit1.FixCombinationMixUnknown;
                }
                break;
            case VisitEnum.second:
                var visit2 = await GetTreatment2VisitAsync(patientId);
                if (visit2 != null) 
                {
                    result.IsChanged = visit2.IsChanged;
                    result.FixCombination3Unknown = visit2.FixCombination3Unknown;
                    result.FixCombinationMixUnknown = visit2.FixCombinationMixUnknown;
                }
                break;
        }

        return result;
    }

    public async Task<List<DyslipidemiaDrug>> GetDyslipidemiaDrugsAsync()
    {
        using var scope = _scopeFactory.CreateScope();
        var aContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        return await aContext.DyslipidemiaDrugs.OrderBy(i => i.Id).ToListAsync();
    }
    public async Task<List<TreatmentMonotherapyDrug>> GetTreatmentMonotherapyDrugsAsync(MonotherapyEnum category, bool isAldosteroneAntagonist)
    {
        using var scope = _scopeFactory.CreateScope();
        var aContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        return await aContext.TreatmentMonotherapyDrugs.Where(i => i.Monotherapy == category && i.IsAldosteroneAntagonist == isAldosteroneAntagonist).OrderBy(i=> i.Order).ToListAsync();
    }
    public async Task<List<TreatmentMultitherapyDrug>> GetTreatmentMultitherapyDrugsAsync()
    {
        using var scope = _scopeFactory.CreateScope();
        var aContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        return await aContext.TreatmentMultitherapyDrugs.OrderBy(i => i.Order).ToListAsync();
    }

    public async Task<OperationResult> SaveInformedConsentCompetenceQuestionaryAsync(InformedConsentCompetence informedconsentcompetence)
    {
        using var scope = _scopeFactory.CreateScope();
        var aContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        var InformedConsentCompetence = await aContext.InformedConsentCompetences.FirstOrDefaultAsync(i => i.Id == informedconsentcompetence.Id);
        if (InformedConsentCompetence == null)
        {
            _logger.LogInformation("The informed consent competence for patient {user} has been added.", informedconsentcompetence.Id);
            aContext.InformedConsentCompetences.Add(informedconsentcompetence);
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
            await aContext.SaveChangesAsync();
            return OperationResult.SuccessResult();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, ex.Message);
            return OperationResult.FailureResult("Pri ukladaní údajov došlo k neočakávanej chybe.", ex.Message);
        }
    }
    public async Task<OperationResult> SaveTreatmentBeforeAsync(TreatmentBefore entry)
    {
        using var scope = _scopeFactory.CreateScope();
        var aContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        var existEntry = await aContext.TreatmentsBefore.FirstOrDefaultAsync(i => i.Id == entry.Id);
        if (existEntry == null)
        {
            _logger.LogInformation("The TreatmentBefore for patient {id} has been added.", entry.Id);
            aContext.TreatmentsBefore.Add(entry);
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
            await aContext.SaveChangesAsync();
            return OperationResult.SuccessResult();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, ex.Message);
            return OperationResult.FailureResult("Pri ukladaní údajov došlo k neočakávanej chybe.", ex.Message);
        }
    }
    public async Task<OperationResult> SaveDemographyHistoryQuestionaryAsync(DemographyHistory demographyhistory)
    {
        using var scope = _scopeFactory.CreateScope();
        var aContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        var DemographyHistory = await aContext.DemographyHistories.FirstOrDefaultAsync(i => i.Id == demographyhistory.Id);
        if (DemographyHistory == null)
        {
            _logger.LogInformation("The informed consent competence for patient {user} has been added.", demographyhistory.Id);
            aContext.DemographyHistories.Add(demographyhistory);
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
            DemographyHistory.DiagnosisDiabetesType = demographyhistory.DiagnosisDiabetesType;
            DemographyHistory.DiagnosisDyslipidemia = demographyhistory.DiagnosisDyslipidemia;
            DemographyHistory.DiagnosisDyslipidemiaDrug = demographyhistory.DiagnosisDyslipidemiaDrug;
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
            await aContext.SaveChangesAsync();
            return OperationResult.SuccessResult();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, ex.Message);
            return OperationResult.FailureResult("Pri ukladaní údajov došlo k neočakávanej chybe.", ex.Message);
        }
    }
    public async Task<OperationResult> SavePhysicalExamination1Async(PhysicalExamination1 entry)
    {
        using var scope = _scopeFactory.CreateScope();
        var aContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        var existEntry = await aContext.PhysicalExaminations1.FirstOrDefaultAsync(i => i.Id == entry.Id);
        if (existEntry == null)
        {
            _logger.LogInformation("The PhysicalExamination1 for patient {user} has been added.", entry.Id);
            aContext.PhysicalExaminations1.Add(entry);
        }
        else
        {
            _logger.LogInformation("The PhysicalExamination1 for patient with id {id} has been updated.", entry.Id);
            existEntry.Height = entry.Height;
            existEntry.HeightUnknown = entry.HeightUnknown;
            existEntry.Weight = entry.Weight;
            existEntry.WeightUnknown = entry.WeightUnknown;
            existEntry.Waist = entry.Waist;
            existEntry.WaistUnknown = entry.WaistUnknown;
            existEntry.Hand = entry.Hand;
            existEntry.Measurement1 = entry.Measurement1;
            existEntry.Measurement1Stk = entry.Measurement1Stk;
            existEntry.Measurement1Dtk = entry.Measurement1Dtk;
            existEntry.Measurement1Sf = entry.Measurement1Sf;
            existEntry.Measurement2 = entry.Measurement2;
            existEntry.Measurement2Stk = entry.Measurement2Stk;
            existEntry.Measurement2Dtk = entry.Measurement2Dtk;
            existEntry.Measurement2Sf = entry.Measurement2Sf;
            existEntry.Measurement3 = entry.Measurement3;
            existEntry.Measurement3Stk = entry.Measurement3Stk;
            existEntry.Measurement3Dtk = entry.Measurement3Dtk;
            existEntry.Measurement3Sf = entry.Measurement3Sf;
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
    public async Task<OperationResult> SavePhysicalExamination2Async(PhysicalExamination2 entry)
    {
        using var scope = _scopeFactory.CreateScope();
        var aContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        var existEntry = await aContext.PhysicalExaminations2.FirstOrDefaultAsync(i => i.Id == entry.Id);
        if (existEntry == null)
        {
            _logger.LogInformation("The PhysicalExamination2 for patient {user} has been added.", entry.Id);
            aContext.PhysicalExaminations2.Add(entry);
        }
        else
        {
            _logger.LogInformation("The PhysicalExamination2 for patient with id {id} has been updated.", entry.Id);
            existEntry.AmbulatoryMonitor = entry.AmbulatoryMonitor;
            existEntry.BorrowedMonitor = entry.BorrowedMonitor;
            existEntry.AmbulatoryHand = entry.AmbulatoryHand;
            existEntry.AmbulatoryMeasurement1 = entry.AmbulatoryMeasurement1;
            existEntry.AmbulatoryMeasurement1Stk = entry.AmbulatoryMeasurement1Stk;
            existEntry.AmbulatoryMeasurement1Dtk = entry.AmbulatoryMeasurement1Dtk;
            existEntry.AmbulatoryMeasurement1Sf = entry.AmbulatoryMeasurement1Sf;
            existEntry.AmbulatoryMeasurement2 = entry.AmbulatoryMeasurement2;
            existEntry.AmbulatoryMeasurement2Stk = entry.AmbulatoryMeasurement2Stk;
            existEntry.AmbulatoryMeasurement2Dtk = entry.AmbulatoryMeasurement2Dtk;
            existEntry.AmbulatoryMeasurement2Sf = entry.AmbulatoryMeasurement2Sf;
            existEntry.AmbulatoryMeasurement3 = entry.AmbulatoryMeasurement3;
            existEntry.AmbulatoryMeasurement3Stk = entry.AmbulatoryMeasurement3Stk;
            existEntry.AmbulatoryMeasurement3Dtk = entry.AmbulatoryMeasurement3Dtk;
            existEntry.AmbulatoryMeasurement3Sf = entry.AmbulatoryMeasurement3Sf;
            existEntry.BorrowedHand = entry.BorrowedHand;
            existEntry.BorrowedMeasurement1 = entry.BorrowedMeasurement1;
            existEntry.BorrowedMeasurement1Stk = entry.BorrowedMeasurement1Stk;
            existEntry.BorrowedMeasurement1Dtk = entry.BorrowedMeasurement1Dtk;
            existEntry.BorrowedMeasurement1Sf = entry.BorrowedMeasurement1Sf;
            existEntry.BorrowedMeasurement2 = entry.BorrowedMeasurement2;
            existEntry.BorrowedMeasurement2Stk = entry.BorrowedMeasurement2Stk;
            existEntry.BorrowedMeasurement2Dtk = entry.BorrowedMeasurement2Dtk;
            existEntry.BorrowedMeasurement2Sf = entry.BorrowedMeasurement2Sf;
            existEntry.BorrowedMeasurement3 = entry.BorrowedMeasurement3;
            existEntry.BorrowedMeasurement3Stk = entry.BorrowedMeasurement3Stk;
            existEntry.BorrowedMeasurement3Dtk = entry.BorrowedMeasurement3Dtk;
            existEntry.BorrowedMeasurement3Sf = entry.BorrowedMeasurement3Sf;
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
    public async Task<OperationResult> SaveLaboratoryTestAsync(LaboratoryTest entry)
    {
        using var scope = _scopeFactory.CreateScope();
        var aContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        var existEntry = await aContext.LaboratoryTests.FirstOrDefaultAsync(i => i.Id == entry.Id);
        if (existEntry == null)
        {
            _logger.LogInformation("The LaboratoryTest for patient {user} has been added.", entry.Id);
            aContext.LaboratoryTests.Add(entry);
        }
        else
        {
            _logger.LogInformation("The LaboratoryTest for patient with id {id} has been updated.", entry.Id);
            existEntry.Cholesterol = entry.Cholesterol;
            existEntry.CholesterolUnknown = entry.CholesterolUnknown;
            existEntry.LDL = entry.LDL;
            existEntry.LDLUnknown = entry.LDLUnknown;
            existEntry.HDL = entry.HDL;
            existEntry.HDLUnknown = entry.HDLUnknown;
            existEntry.Triglycerides = entry.Triglycerides;
            existEntry.TriglyceridesUnknown = entry.TriglyceridesUnknown;
            existEntry.Albumin = entry.Albumin;
            existEntry.AlbuminUnknown = entry.AlbuminUnknown;
            existEntry.Creatinine = entry.Creatinine;
            existEntry.CreatinineUnknown = entry.CreatinineUnknown;
            existEntry.Glycemia = entry.Glycemia;
            existEntry.GlycemiaUnknown = entry.GlycemiaUnknown;
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
    public async Task<OperationResult> SaveTreatment1VisitAsync(Treatment1Visit entry)
    {
        using var scope = _scopeFactory.CreateScope();
        var aContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        var existEntry = await aContext.Treatments1Visit.FirstOrDefaultAsync(i => i.Id == entry.Id);
        if (existEntry == null)
        {
            _logger.LogInformation("The Treatment1Visit for patient {id} has been added.", entry.Id);
            aContext.Treatments1Visit.Add(entry);
        }
        else
        {
            _logger.LogInformation("The Treatment1Visit for patient {id} has been updated.", entry.Id);
            existEntry.IsChanged = entry.IsChanged;
            existEntry.FixCombination3Unknown = entry.FixCombination3Unknown;
            existEntry.FixCombinationMixUnknown = entry.FixCombinationMixUnknown;
            existEntry.IsOngoing = entry.IsOngoing;
            existEntry.IsIssuingRecorder = entry.IsIssuingRecorder;
            existEntry.IsPressureGauge = entry.IsPressureGauge;
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
    public async Task<OperationResult> SaveTreatment2VisitAsync(Treatment2Visit entry)
    {
        using var scope = _scopeFactory.CreateScope();
        var aContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        var existEntry = await aContext.Treatments2Visit.FirstOrDefaultAsync(i => i.Id == entry.Id);
        if (existEntry == null)
        {
            _logger.LogInformation("The Treatment2Visit for patient {id} has been added.", entry.Id);
            aContext.Treatments2Visit.Add(entry);
        }
        else
        {
            _logger.LogInformation("The Treatment2Visit for patient {id} has been updated.", entry.Id);
            existEntry.VisitDate = entry.VisitDate;
            existEntry.IsReturnedRecorder = entry.IsReturnedRecorder;
            existEntry.SubjectEvaluation = entry.SubjectEvaluation;
            existEntry.IsProperlyTerminated = entry.IsProperlyTerminated;
            existEntry.TerminationReason = entry.TerminationReason;
            existEntry.IsChanged = entry.IsChanged;
            existEntry.ChangeDate = entry.ChangeDate;
            existEntry.IsChangeDateUnknown = entry.IsChangeDateUnknown;
            existEntry.FixCombination3Unknown = entry.FixCombination3Unknown;
            existEntry.FixCombinationMixUnknown = entry.FixCombinationMixUnknown;
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
    public async Task<OperationResult> SaveBloodPressureMonitorAsync(BloodPressureMonitor entry)
    {
        using var scope = _scopeFactory.CreateScope();
        var aContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        var existEntry = await aContext.BloodPressureMonitors.FirstOrDefaultAsync(i => i.Id == entry.Id);
        if (existEntry == null)
        {
            _logger.LogInformation("The Monitor for patient {id} has been added.", entry.Id);
            aContext.BloodPressureMonitors.Add(entry);
        }
        else
        {
            _logger.LogInformation("The Monitor for patient {id} has been updated.", entry.Id);
            existEntry.IsOmronMonitor = entry.IsOmronMonitor;
            existEntry.OmronNumber = entry.OmronNumber;
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

    public async Task<OperationResult> SaveTreatmentMonotherapyAsync(TreatmentMonotherapy entry)
    {
        using var scope = _scopeFactory.CreateScope();
        var aContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        var existEntry = await aContext.TreatmentMonotherapies.FirstOrDefaultAsync(i => i.Id == entry.Id);
        if (existEntry == null)
        {
            _logger.LogInformation("The TreatmentMonotherapy for patient {patient} and visit {visit} has been added.", entry.PatientId, entry.VisitNumber.ToString());
            aContext.TreatmentMonotherapies.Add(entry);
        }
        else
        {
            _logger.LogInformation("The TreatmentMonotherapy {id} for patient {patient} and visit {visit} has been updated.", entry.Id, entry.PatientId, entry.VisitNumber.ToString());
            existEntry.DrugId = entry.DrugId;
            existEntry.IsAldosteroneAntagonist = entry.IsAldosteroneAntagonist;
            existEntry.Dose = entry.Dose;
            existEntry.NumberMorning = entry.NumberMorning;
            existEntry.NumberNoon = entry.NumberNoon;
            existEntry.NumberEvening = entry.NumberEvening;
            existEntry.IsUnknown = entry.IsUnknown;
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
    public async Task<OperationResult> SaveTreatmentMultitherapyAsync(TreatmentMultitherapy entry)
    {
        using var scope = _scopeFactory.CreateScope();
        var aContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        var existEntry = await aContext.TreatmentMultitherapies.FirstOrDefaultAsync(i => i.Id == entry.Id);
        if (existEntry == null)
        {
            _logger.LogInformation("The TreatmentMultitherapy for patient {patient} and visit {visit} has been added.", entry.PatientId, entry.VisitNumber.ToString());
            aContext.TreatmentMultitherapies.Add(entry);
        }
        else
        {
            _logger.LogInformation("The TreatmentMultitherapy {id} for patient {patient} and visit {visit} has been updated.", entry.Id, entry.PatientId, entry.VisitNumber.ToString());
            existEntry.DrugId = entry.DrugId;
            existEntry.Dose1 = entry.Dose1;
            existEntry.Dose2 = entry.Dose2;
            existEntry.Dose3 = entry.Dose3;
            existEntry.NumberMorning = entry.NumberMorning;
            existEntry.NumberNoon = entry.NumberNoon;
            existEntry.NumberEvening = entry.NumberEvening;
            existEntry.IsUnknown = entry.IsUnknown;
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
    public async Task<OperationResult> SaveDayRecordAsync(DayRecord entry)
    {
        using var scope = _scopeFactory.CreateScope();
        var aContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        var existEntry = await aContext.DayRecords.FirstOrDefaultAsync(i => i.PatientId == entry.PatientId && i.DayNumber == entry.DayNumber);
        if (existEntry == null)
        {
            _logger.LogInformation("The DayRecord for patient {patient} and day {day} has been added.", entry.PatientId, entry.DayNumber.ToString());
            aContext.DayRecords.Add(entry);
        }
        else
        {
            _logger.LogInformation("The DayRecord {id} for patient {patient} and day {day} has been updated.", entry.Id, entry.PatientId, entry.DayNumber.ToString());
            existEntry.Morning1PressureUnknown = entry.Morning1PressureUnknown;
            existEntry.Morning1PulseUnknown = entry.Morning1PulseUnknown;
            existEntry.Morning1Stk = entry.Morning1Stk;
            existEntry.Morning1Dtk = entry.Morning1Dtk;
            existEntry.Morning1Sf = entry.Morning1Sf;
            existEntry.Morning2PressureUnknown = entry.Morning2PressureUnknown;
            existEntry.Morning2PulseUnknown = entry.Morning2PulseUnknown;
            existEntry.Morning2Stk = entry.Morning2Stk;
            existEntry.Morning2Dtk = entry.Morning2Dtk;
            existEntry.Morning2Sf = entry.Morning2Sf;
            existEntry.Evening1PressureUnknown = entry.Evening1PressureUnknown;
            existEntry.Evening1PulseUnknown = entry.Evening1PulseUnknown;
            existEntry.Evening1Stk = entry.Evening1Stk;
            existEntry.Evening1Dtk = entry.Evening1Dtk;
            existEntry.Evening1Sf = entry.Evening1Sf;
            existEntry.Evening2PressureUnknown = entry.Evening2PressureUnknown;
            existEntry.Evening2PulseUnknown = entry.Evening2PulseUnknown;
            existEntry.Evening2Stk = entry.Evening2Stk;
            existEntry.Evening2Dtk = entry.Evening2Dtk;
            existEntry.Evening2Sf = entry.Evening2Sf;
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
    public async Task<OperationResult> SaveTreatmentUnknownsAsync(string patientId, VisitEnum visitNum, TreatmentUnknowns unknowns)
    {
        using var scope = _scopeFactory.CreateScope();
        var aContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

        switch (visitNum)
        {
            case VisitEnum.before:
                var before = await GetTreatmentBeforeAsync(patientId);
                if (before != null)
                {
                    before.FixCombination3Unknown = unknowns.FixCombination3Unknown;
                    before.FixCombinationMixUnknown = unknowns.FixCombinationMixUnknown;
                    _logger.LogInformation("The TreatmentBefore for patient {id} has been updated.", patientId);
                }
                break;
            case VisitEnum.first:
                var visit1 = await GetTreatmentBeforeAsync(patientId);
                if (visit1 != null)
                {
                    visit1.FixCombination3Unknown = unknowns.FixCombination3Unknown;
                    visit1.FixCombinationMixUnknown = unknowns.FixCombinationMixUnknown;
                    _logger.LogInformation("The Treatment1Visit for patient {id} has been updated.", patientId);
                }
                break;
            case VisitEnum.second:
                var visit2 = await GetTreatmentBeforeAsync(patientId);
                if (visit2 != null)
                {
                    visit2.FixCombination3Unknown = unknowns.FixCombination3Unknown;
                    visit2.FixCombinationMixUnknown = unknowns.FixCombinationMixUnknown;
                    _logger.LogInformation("The Treatment2Visit for patient {id} has been updated.", patientId);
                }
                break;
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

    public async Task<OperationResult> DeleteTreatmentMonotherapyAsync(TreatmentMonotherapy entry)
    {
        using var scope = _scopeFactory.CreateScope();
        var aContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        var existEntry = await aContext.TreatmentMonotherapies.FirstOrDefaultAsync(i => i.Id == entry.Id);
        if (existEntry != null)
        {
            _logger.LogInformation("The TreatmentMonotherapy for patient {id} and visit {visit} has been deleted.", entry.Id, entry.VisitNumber.ToString());
            aContext.TreatmentMonotherapies.Remove(existEntry);
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
    public async Task<OperationResult> DeleteTreatmentMultitherapyAsync(TreatmentMultitherapy entry)
    {
        using var scope = _scopeFactory.CreateScope();
        var aContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        var existEntry = await aContext.TreatmentMultitherapies.FirstOrDefaultAsync(i => i.Id == entry.Id);
        if (existEntry != null)
        {
            _logger.LogInformation("The TreatmentMultitherapy for patient {id} and visit {visit} has been deleted.", entry.Id, entry.VisitNumber.ToString());
            aContext.TreatmentMultitherapies.Remove(existEntry);
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

}
