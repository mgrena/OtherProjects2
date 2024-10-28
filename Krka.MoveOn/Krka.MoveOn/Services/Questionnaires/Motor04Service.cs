using Krka.MoveOn.Data;
using Krka.MoveOn.Data.Dials;
using Krka.MoveOn.Data.Questionnaires;
using Microsoft.EntityFrameworkCore;

namespace Krka.MoveOn.Services.Questionnaires;

public class Motor04Service(ApplicationDbContext context)
{
    private readonly ApplicationDbContext _context = context;

    public async Task<QuestionnaireNonMotor04?> GetQuestionnaireNonMotor04(string questionnaireId)
    {
        return await Task.Run(() => _context.QuestionnaireNonMotor04s
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

}
