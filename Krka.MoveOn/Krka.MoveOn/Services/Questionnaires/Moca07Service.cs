using Krka.MoveOn.Data;
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

            questionnaire.ProgressPercentage = 100;

            var existingQuestionnaire = await _context.QuestionnaireMoca07s
                .FirstOrDefaultAsync(q => q.Id == questionnaire.Id);

            if (existingQuestionnaire != null)
            {
                existingQuestionnaire.Mh_1 = questionnaire.Mh_1;
                existingQuestionnaire.Moca_1 = questionnaire.Moca_1;
                existingQuestionnaire.Moca_2 = questionnaire.Moca_2;
                existingQuestionnaire.Moca_3 = questionnaire.Moca_3;
                existingQuestionnaire.Moca_4 = questionnaire.Moca_4;
                existingQuestionnaire.Moca_5 = questionnaire.Moca_5;
                existingQuestionnaire.Moca_6 = questionnaire.Moca_6;
                existingQuestionnaire.Moca_7 = questionnaire.Moca_7;
                existingQuestionnaire.Moca_8 = questionnaire.Moca_8;
                existingQuestionnaire.Moca_9 = questionnaire.Moca_9;
                existingQuestionnaire.Moca_10 = questionnaire.Moca_10;
                existingQuestionnaire.Moca_11 = questionnaire.Moca_11;
                existingQuestionnaire.Moca_12 = questionnaire.Moca_12;
                existingQuestionnaire.ModifiedAt = DateTime.Now;

                _context.QuestionnaireMoca07s.Update(existingQuestionnaire);
            }
            else
            {
                // Pridanie nového záznamu
                _context.QuestionnaireMoca07s.Add(questionnaire);
            }

            await _context.SaveChangesAsync();
        }

    }
}
