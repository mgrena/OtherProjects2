using Krka.MoveOn.Data;
using Krka.MoveOn.Data.Questionnaires;
using Krka.MoveOn.Services.Pages;
using Microsoft.EntityFrameworkCore;

namespace Krka.MoveOn.Services.Questionnaires;

public class QuestionnaireProgressService(ApplicationDbContext context, General01Service general01Service, Initial02Service initial02Service,
                                    Treatment03Service treatment03Service, Motor04Service motor04Service, Motor05Service motor05Service,
                                    Motor06Service motor06Service, Moca07Service moca07Service, Exclusion08Service exclusion08Service,
                                    DrugEffect09Service drugEffect09Service, Satisfaction10Service satisfaction10Service, PatientService patientService)
{
    private readonly ApplicationDbContext _context = context;
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

        var existingQuestionnaire = await _context.Questionnaires
                                                  .FirstOrDefaultAsync(q => q.Id == questionnaireId);

        if (existingQuestionnaire == null)
        {
            throw new InvalidOperationException($"Questionnaire with ID {questionnaireId} not found.");
        }


        var patient = await _patientService.GetPatientByIdAsync(existingQuestionnaire.PatientId);

        var generalQ = await _general01Service.GetQuestionnaireGeneral01ByQuestionnaireIdAsync(questionnaireId);
        var initialQ = await _initial02Service.GetQuestionnaireInitial02(questionnaireId);
        var treatmentQ = await _treatment03Service.GetQuestionnaireTreatment03(questionnaireId);
        var nonmotorQ = await _motor04Service.GetQuestionnaireNonMotor04(questionnaireId);
        var motorQ = await _motor05Service.GetQuestionnaireMotor05(questionnaireId);
        var motorSkillQ = await _motor06Service.GetQuestionnaireMotorSkill06(questionnaireId);
        var mocaQ = await _moca07Service.GetQuestionnaireMoca07ByQuestionnaireIdAsync(questionnaireId);
        var exclusionQ = await _exclusion08Service.GetQuestionnaireExclusion08ByQuestionnaireIdAsync(questionnaireId);
        var drugEffectQ = await _drugEffect09Service.GetQuestionnaireDrugEffect09(questionnaireId);
        var satisfactionQ = await _satisfaction10Service.GetQuestionnaireSatisfaction10(questionnaireId);

        var entryProgress =
        ((generalQ?.ProgressPercentage ?? 0) +
        (initialQ.Count > 0 ? 100 : 0) +
        (treatmentQ.Count > 0 ? 100 : 0) +
        ((nonmotorQ != null ? 100 : 0) + (motorQ != null ? 100 : 0) + (motorSkillQ != null ? 100 : 0)) / 3 +
        (mocaQ?.ProgressPercentage ?? 0) +
        (exclusionQ != null ? 100 : 0)) / 6;

        var ongoingProgress =
        ((initialQ.Count > 0 ? 100 : 0) +
        (treatmentQ.Count > 0 ? 100 : 0) +
        (drugEffectQ.Count > 0 ? 100 : 0) +
        (motorSkillQ != null ? 100 : 0) +
        (satisfactionQ?.ProgressPercentage ?? 0) +
        (exclusionQ != null ? 100 : 0)) / 6;

        var resultProgress =
        ((initialQ.Count > 0 ? 100 : 0) +
        (treatmentQ.Count > 0 ? 100 : 0) +
        (drugEffectQ.Count > 0 ? 100 : 0) +
        ((nonmotorQ != null ? 100 : 0) + (motorQ != null ? 100 : 0) + (motorSkillQ != null ? 100 : 0)) / 3 +
        (satisfactionQ?.ProgressPercentage ?? 0) +
        (mocaQ?.ProgressPercentage ?? 0) +
        (exclusionQ != null ? 100 : 0)) / 7;

        switch (existingQuestionnaire.Order)
        {
            case Questionnaire.QuestionnaireOrderEnum.entry:
                existingQuestionnaire.ProgressPercentage = entryProgress;
                patient.EntryProgressPercentage = entryProgress;
                break;
            case Questionnaire.QuestionnaireOrderEnum.ongoing:
                existingQuestionnaire.ProgressPercentage = ongoingProgress;
                patient.OngoingProgressPercentage = ongoingProgress;
                break;
            case Questionnaire.QuestionnaireOrderEnum.result:
                existingQuestionnaire.ProgressPercentage = resultProgress;
                patient.ResultProgressPercentage = resultProgress;
                break;
        }

        await SaveQuestionnaireAsync(existingQuestionnaire);
        await SavePatientAsync(patient);
    }

    private async Task SaveQuestionnaireAsync(Questionnaire questionnaire)
    {
        _context.Questionnaires.Update(questionnaire);
        await _context.SaveChangesAsync();
    }

    private async Task SavePatientAsync(Patient patient)
    {
        await _patientService.SavePatientAsync(patient);
    }


}
