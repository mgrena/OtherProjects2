﻿using Krka.MoveOn.Data;
using Krka.MoveOn.Data.Dials;
using Krka.MoveOn.Data.Questionnaires;
using Microsoft.EntityFrameworkCore;

namespace Krka.MoveOn.Services.Questionnaires;

public class Motor05Service(ApplicationDbContext context)
{
    private readonly ApplicationDbContext _context = context;

    public async Task<QuestionnaireMotor05?> GetQuestionnaireMotor05(string questionnaireId)
    {
        return await _context.QuestionnaireMotor05s
                .FirstOrDefaultAsync(q => q.Questionnaire_id == questionnaireId);

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

}
