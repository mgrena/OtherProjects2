using Krka.MoveOn.Data;
using Krka.MoveOn.Data.Dials;
using Krka.MoveOn.Data.Questionnaires;
using Microsoft.EntityFrameworkCore;

namespace Krka.MoveOn.Services.Questionnaires;

public class Motor040506Service(ApplicationDbContext context)
{
    private readonly ApplicationDbContext _context = context;

    public async Task<QuestionnaireNonMotor04?> GetQuestionnaireNonMotor04(string questionnaireId)
    {
        return await Task.Run(() => _context.QuestionnaireNonMotor04s
            .FirstOrDefault(q => q.Questionnaire_id == questionnaireId));            
    }

    public async Task<QuestionnaireMotor05?> GetQuestionnaireMotor05(string questionnaireId)
    {
        return await Task.Run(() => _context.QuestionnaireMotor05s
            .FirstOrDefault(q => q.Questionnaire_id == questionnaireId));
    }

    public async Task<QuestionnaireMotorSkill06?> GetQuestionnaireMotorSkill06(string questionnaireId)
    {
        return await Task.Run(() => _context.QuestionnaireMotorSkill06s
            .FirstOrDefault(q => q.Questionnaire_id == questionnaireId));
    }

    public async Task SaveOrUpdateQuestionnaireNonMotor04(QuestionnaireNonMotor04 questionnaire)
    {
        var existing = await _context.QuestionnaireNonMotor04s
            .FirstOrDefaultAsync(q => q.Questionnaire_id == questionnaire.Questionnaire_id);

        if (existing == null)
        {
            _context.QuestionnaireNonMotor04s.Add(questionnaire);
        }
        else
        {
            existing.Nonmot_1 = questionnaire.Nonmot_1;
            existing.Nonmot_2 = questionnaire.Nonmot_2;
            existing.Nonmot_3 = questionnaire.Nonmot_3;
            existing.Nonmot_4 = questionnaire.Nonmot_4;
            existing.Nonmot_5 = questionnaire.Nonmot_5;
            existing.Nonmot_6 = questionnaire.Nonmot_6;
            existing.Nonmot_7 = questionnaire.Nonmot_7;
            existing.Nonmot_8 = questionnaire.Nonmot_8;
            existing.Nonmot_9 = questionnaire.Nonmot_9;
            existing.Nonmot_10 = questionnaire.Nonmot_10;
            existing.Nonmot_11 = questionnaire.Nonmot_11;
            existing.Nonmot_12 = questionnaire.Nonmot_12;
            existing.Nonmot_13 = questionnaire.Nonmot_13;
            existing.ModifiedAt = DateTime.Now;
        }

        await _context.SaveChangesAsync();
    }

    public async Task SaveOrUpdateQuestionnaireMotor05(QuestionnaireMotor05 questionnaire)
    {
        var existing = await _context.QuestionnaireMotor05s
            .FirstOrDefaultAsync(q => q.Questionnaire_id == questionnaire.Questionnaire_id);

        if (existing == null)
        {
            _context.QuestionnaireMotor05s.Add(questionnaire);
        }
        else
        {
            existing.Mot_1 = questionnaire.Mot_1;
            existing.Mot_2 = questionnaire.Mot_2;
            existing.Mot_3 = questionnaire.Mot_3;
            existing.Mot_4 = questionnaire.Mot_4;
            existing.Mot_5 = questionnaire.Mot_5;
            existing.Mot_6 = questionnaire.Mot_6;
            existing.Mot_7 = questionnaire.Mot_7;
            existing.Mot_8 = questionnaire.Mot_8;
            existing.Mot_9 = questionnaire.Mot_9;
            existing.Mot_10 = questionnaire.Mot_10;
            existing.Mot_11 = questionnaire.Mot_11;
            existing.Mot_12 = questionnaire.Mot_12;
            existing.Mot_13 = questionnaire.Mot_13;
            existing.ModifiedAt = DateTime.Now;
        }

        await _context.SaveChangesAsync();
    }

    public async Task SaveOrUpdateQuestionnaireMotorSkill06(QuestionnaireMotorSkill06 questionnaire)
    {
        var existing = await _context.QuestionnaireMotorSkill06s
            .FirstOrDefaultAsync(q => q.Questionnaire_id == questionnaire.Questionnaire_id);

        if (existing == null)
        {
            _context.QuestionnaireMotorSkill06s.Add(questionnaire);
        }
        else
        {
            existing.Motskill_1 = questionnaire.Motskill_1;
            existing.Motskill_2 = questionnaire.Motskill_2;
            existing.Motskill_3 = questionnaire.Motskill_3;
            existing.Motskill_4 = questionnaire.Motskill_4;
            existing.Motskill_5 = questionnaire.Motskill_5;
            existing.Motskill_6 = questionnaire.Motskill_6;
            existing.Motskill_7 = questionnaire.Motskill_7;
            existing.Motskill_8 = questionnaire.Motskill_8;
            existing.Motskill_9 = questionnaire.Motskill_9;
            existing.Motskill_10 = questionnaire.Motskill_10;
            existing.Motskill_11 = questionnaire.Motskill_11;
            existing.Motskill_12 = questionnaire.Motskill_12;
            existing.Motskill_13 = questionnaire.Motskill_13;
            existing.Motskill_14 = questionnaire.Motskill_14;
            existing.Motskill_15 = questionnaire.Motskill_15;
            existing.Motskill_16 = questionnaire.Motskill_16;
            existing.Motskill_17 = questionnaire.Motskill_17;
            existing.Motskill_18 = questionnaire.Motskill_18;
            existing.Motskill_19 = questionnaire.Motskill_19;
            existing.Motskill_20 = questionnaire.Motskill_20;
            existing.Motskill_21 = questionnaire.Motskill_21;
            existing.Motskill_22 = questionnaire.Motskill_22;
            existing.Motskill_23 = questionnaire.Motskill_23;
            existing.Motskill_24 = questionnaire.Motskill_24;
            existing.Motskill_25 = questionnaire.Motskill_25;
            existing.Motskill_26 = questionnaire.Motskill_26;
            existing.Motskill_27 = questionnaire.Motskill_27;
            existing.Motskill_28 = questionnaire.Motskill_28;
            existing.Motskill_29 = questionnaire.Motskill_29;
            existing.Motskill_30 = questionnaire.Motskill_30;
            existing.Motskill_31 = questionnaire.Motskill_31;
            existing.Motskill_32 = questionnaire.Motskill_32;
            existing.Motskill_33 = questionnaire.Motskill_33;
            existing.ModifiedAt = DateTime.Now;
        }

        await _context.SaveChangesAsync();
    }


}
