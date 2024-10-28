using Krka.MoveOn.Data;
using Krka.MoveOn.Data.Dials;
using Krka.MoveOn.Data.Questionnaires;
using Microsoft.EntityFrameworkCore;

namespace Krka.MoveOn.Services.Questionnaires;

public class Motor06Service(ApplicationDbContext context)
{
    private readonly ApplicationDbContext _context = context;

    public async Task<QuestionnaireMotorSkill06?> GetQuestionnaireMotorSkill06(string questionnaireId)
    {
        return await Task.Run(() => _context.QuestionnaireMotorSkill06s
            .FirstOrDefault(q => q.Questionnaire_id == questionnaireId));
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
