﻿using Krka.MoveOn.Data;
using Krka.MoveOn.Data.Dials;
using Krka.MoveOn.Data.Questionnaires;
using Microsoft.EntityFrameworkCore;

namespace Krka.MoveOn.Services.Questionnaires
{
    public class Moca07Service(ApplicationDbContext context)
    {
        private readonly ApplicationDbContext _context = context;

        public async Task<QuestionnaireMoca07?> GetQuestionnaireMoca07ByQuestionnaireIdAsync(string questionnaireId)
        {
            return await _context.QuestionnaireMoca07s
                .FirstOrDefaultAsync(q => q.Questionnaire_id == questionnaireId);
        }

        public async Task<List<DialMH>> GetDialMHAsync()
        {
            return await _context.DialMHs.ToListAsync();
        }

        public async Task SaveQuestionnaireMoca07Async(QuestionnaireMoca07 questionnaire)
        {
            if (questionnaire == null)
            {
                throw new ArgumentNullException(nameof(questionnaire));
            }

            _context.QuestionnaireMoca07s.Add(questionnaire);
            await _context.SaveChangesAsync();
        }

    }
}