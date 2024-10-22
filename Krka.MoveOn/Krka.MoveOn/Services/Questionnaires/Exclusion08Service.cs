using Krka.MoveOn.Data;
using Krka.MoveOn.Data.AdverseEffects;
using Krka.MoveOn.Data.Dials;
using Krka.MoveOn.Data.Questionnaires;
using Microsoft.EntityFrameworkCore;

namespace Krka.MoveOn.Services.Questionnaires
{
    public class Exclusion08Service(ApplicationDbContext context)
    {
        private readonly ApplicationDbContext _context = context;

        public async Task<QuestionnaireExclusion08?> GetQuestionnaireExclusion08ByQuestionnaireIdAsync(int questionnaireId)
        {
            return await Task.Run(() => _context.QuestionnaireExclusion08s
                                 .FirstOrDefault(q => q.Questionnaire_id == questionnaireId));
        }

        public async Task<List<DialQGeneral>> GetDialGeneralAsync()
        {
            return await _context.DialQGenerals.ToListAsync();
        }

        public async Task<List<DialExclusion>> GetDialExclusionAsync()
        {
            return await _context.DialExclusions.ToListAsync();
        }

        public async Task<List<DialAdverseEffect>> GetDialAdverseEffectAsync()
        {
            return await _context.DialAdverseEffects.ToListAsync();
        }

        public async Task<List<AdverseEffect>> GetAdverseEffect(int questionnaireId)
        {
            return await _context.AdverseEffects
               .Where(q => q.QuestionnaireId == questionnaireId && q.DeletedAt == null)
               .ToListAsync();
        }

        public async Task SaveQuestionnaireExlusion08Async(QuestionnaireExclusion08 questionnaire)
        {
            if (questionnaire == null)
            {
                throw new ArgumentNullException(nameof(questionnaire));
            }

            var existingQuestionnaire = await _context.QuestionnaireExclusion08s
                .FirstOrDefaultAsync(q => q.Id == questionnaire.Id);

            if (existingQuestionnaire != null)
            {               
                existingQuestionnaire.Exc_Q = questionnaire.Exc_Q;
                existingQuestionnaire.Exc_1 = questionnaire.Exc_1;
                existingQuestionnaire.Exc_2 = questionnaire.Exc_2;
                existingQuestionnaire.Exc_3 = questionnaire.Exc_3;
                existingQuestionnaire.ModifiedAt = DateTime.Now;
                
                _context.QuestionnaireExclusion08s.Update(existingQuestionnaire);
            }
            else
            {
                // Pridanie nového záznamu
                _context.QuestionnaireExclusion08s.Add(questionnaire);
            }

            await _context.SaveChangesAsync();
        }

        public async Task AdverserEffectAsync(AdverseEffect exc)
        {
            var existingEntity = await _context.AdverseEffects.FindAsync(exc.Id);
            if (existingEntity != null)
            {
                _context.Entry(existingEntity).State = EntityState.Detached;
            }

            if (exc.Id == 0)
            {
                _context.AdverseEffects.Add(exc);
            }
            else
            {
                _context.AdverseEffects.Update(exc);
            }
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAdvenceAsync(int advenceId)
        {
            var advence = await _context.AdverseEffects.FindAsync(advenceId);
            if (advence != null)
            {
                advence.DeletedAt = DateTime.Now;
                _context.AdverseEffects.Update(advence);
                await _context.SaveChangesAsync();
            }
        }
    }
}
