using DevExpress.XtraPrinting.Shape.Native;
using Krka.MoveOn.Data;
using Krka.MoveOn.Data.Questionnaires;
using Krka.MoveOn.Services.Pages;
using Microsoft.EntityFrameworkCore;

namespace Krka.MoveOn.Services.Questionnaires;

public class QuestionnaireProgressService(IServiceScopeFactory scopeFactory, General01Service general01Service, Initial02Service initial02Service,
                                    Treatment03Service treatment03Service, Motor04Service motor04Service, Motor05Service motor05Service,
                                    Motor06Service motor06Service, Moca07Service moca07Service, Exclusion08Service exclusion08Service,
                                    DrugEffect09Service drugEffect09Service, Satisfaction10Service satisfaction10Service, PatientService patientService)
{
    private readonly IServiceScopeFactory _scopeFactory = scopeFactory;
    private readonly General01Service _general01Service = general01Service;
    private readonly Initial02Service _initial02Service = initial02Service;
    private readonly Treatment03Service _treatment03Service = treatment03Service;
    private readonly Motor04Service _motor04Service = motor04Service;
    private readonly Motor05Service _motor05Service = motor05Service;
    private readonly Motor06Service _motor06Service = motor06Service;
    private readonly Moca07Service _moca07Service = moca07Service;
    private readonly Exclusion08Service _exclusion08Service = exclusion08Service;
    private readonly DrugEffect09Service _drugEffect09Service = drugEffect09Service;
    private readonly Satisfaction10Service _satisfaction10Service = satisfaction10Service;
    private readonly PatientService _patientService = patientService;

    public async Task UpdateProgressAsync(string questionnaireId)
    {
        using var scope = _scopeFactory.CreateScope();
        var aContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        var existingQuestionnaire = await aContext.Questionnaires.FirstOrDefaultAsync(q => q.Id == questionnaireId) ?? throw new InvalidOperationException($"Questionnaire with ID {questionnaireId} not found.");
        var patient = await _patientService.GetPatientByIdAsync(existingQuestionnaire.PatientId) ?? throw new InvalidOperationException($"Patient with ID {existingQuestionnaire.PatientId} not found.");

        var initialQ = await _initial02Service.GetQuestionnaireInitial02(questionnaireId);
        var treatmentQ = await _treatment03Service.GetQuestionnaireTreatment03(questionnaireId);
        var motorSkillQ = await _motor06Service.GetQuestionnaireMotorSkill06(questionnaireId);
        var exclusionQ = await _exclusion08Service.GetQuestionnaireExclusion08ByQuestionnaireIdAsync(questionnaireId);


        switch (existingQuestionnaire.Order)
        {
            case Questionnaire.QuestionnaireOrderEnum.entry:
                // load relevent data
                var generalQ = await _general01Service.GetQuestionnaireGeneral01ByQuestionnaireIdAsync(questionnaireId);
                var nonmotorQ1 = await _motor04Service.GetQuestionnaireNonMotor04(questionnaireId);
                var motorQ1 = await _motor05Service.GetQuestionnaireMotor05(questionnaireId);
                var mocaQ1 = await _moca07Service.GetQuestionnaireMoca07ByQuestionnaireIdAsync(questionnaireId);

                var entryProgress =
                    (int)Math.Ceiling((generalQ?.ProgressPercentage ?? 0) / 6.0) +
                    (int)Math.Ceiling((initialQ.Count > 0 ? 100 : 0) / 6.0) +
                    (int)Math.Ceiling((treatmentQ.Count > 0 ? 100 : 0) / 6.0) +
                    (int)Math.Ceiling(((int)Math.Ceiling((nonmotorQ1 != null ? 100 : 0) / 3.0) + (int)Math.Ceiling((motorQ1 != null ? 100 : 0) / 3.0) + (int)Math.Ceiling((motorSkillQ != null ? 100 : 0) / 3.0)) / 6.0) +
                    (int)Math.Ceiling((mocaQ1?.ProgressPercentage ?? 0) / 6.0) +
                    (int)Math.Ceiling((exclusionQ != null ? 100 : 0) / 6.0);

                entryProgress = entryProgress > 94
                ? 100
                : Math.Clamp(entryProgress, 0, 100);
                // update data models
                existingQuestionnaire.ProgressPercentage = entryProgress;
                patient.EntryProgressPercentage = entryProgress;
                break;
            case Questionnaire.QuestionnaireOrderEnum.ongoing:
                // load relevent data
                var drugEffectQ2 = await _drugEffect09Service.GetQuestionnaireDrugEffect09(questionnaireId);
                var satisfactionQ2 = await _satisfaction10Service.GetQuestionnaireSatisfaction10(questionnaireId);

                // calculate progress
                var ongoingProgress =
                        (int)Math.Ceiling((initialQ.Count > 0 ? 100 : 0) / 6.0) +
                        (int)Math.Ceiling((treatmentQ.Count > 0 ? 100 : 0) / 6.0) +
                        (int)Math.Ceiling((drugEffectQ2.Count > 0 ? 100 : 0) / 6.0) +
                        (int)Math.Ceiling((motorSkillQ != null ? 100 : 0) / 6.0) +
                        (int)Math.Ceiling((satisfactionQ2?.ProgressPercentage ?? 0) / 6.0) +
                        (int)Math.Ceiling((exclusionQ != null ? 100 : 0) / 6.0)
                    ;

                ongoingProgress = ongoingProgress > 94
                ? 100
                : Math.Clamp(ongoingProgress, 0, 100);

                // update data models
                existingQuestionnaire.ProgressPercentage = ongoingProgress;
                patient.OngoingProgressPercentage = ongoingProgress;
                break;
            case Questionnaire.QuestionnaireOrderEnum.result:
                // load relevent data
                var drugEffectQ3 = await _drugEffect09Service.GetQuestionnaireDrugEffect09(questionnaireId);
                var nonmotorQ3 = await _motor04Service.GetQuestionnaireNonMotor04(questionnaireId);
                var motorQ3 = await _motor05Service.GetQuestionnaireMotor05(questionnaireId);
                var mocaQ3 = await _moca07Service.GetQuestionnaireMoca07ByQuestionnaireIdAsync(questionnaireId);
                var satisfactionQ3 = await _satisfaction10Service.GetQuestionnaireSatisfaction10(questionnaireId);

                // calculate progress
                var resultProgress =

                        (int)Math.Ceiling((initialQ.Count > 0 ? 100 : 0) / 7.0) +
                        (int)Math.Ceiling((treatmentQ.Count > 0 ? 100 : 0) / 7.0) +
                        (int)Math.Ceiling((drugEffectQ3.Count > 0 ? 100 : 0) / 7.0) +
                        (int)Math.Ceiling(((int)Math.Ceiling((nonmotorQ3 != null ? 100 : 0) / 3.0) + (int)Math.Ceiling((motorQ3 != null ? 100 : 0) / 3.0) + (int)Math.Ceiling((motorSkillQ != null ? 100 : 0) / 3.0)) / 7.0) +
                        (int)Math.Ceiling((satisfactionQ3?.ProgressPercentage ?? 0) / 7.0) +
                        (int)Math.Ceiling((mocaQ3?.ProgressPercentage ?? 0) / 7.0) +
                        (int)Math.Ceiling((exclusionQ != null ? 100 : 0) / 7.0)
                    ;
                resultProgress = resultProgress > 94
                    ? 100
                    : Math.Clamp(resultProgress, 0, 100);

                // update data models
                existingQuestionnaire.ProgressPercentage = resultProgress;
                patient.ResultProgressPercentage = resultProgress;
                break;
        }

        await SaveQuestionnaireAsync(existingQuestionnaire);
        await SavePatientAsync(patient);
    }

    private async Task SaveQuestionnaireAsync(Questionnaire questionnaire)
    {
        using var scope = _scopeFactory.CreateScope();
        var aContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        aContext.Questionnaires.Update(questionnaire);
        await aContext.SaveChangesAsync();
    }

    private async Task SavePatientAsync(Patient patient)
    {
        await _patientService.SavePatientAsync(patient);
    }


}
