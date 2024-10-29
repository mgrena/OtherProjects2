using Krka.MoveOn.Data;
using Krka.MoveOn.Data.Dials;
using Krka.MoveOn.Data.Questionnaires;
using Microsoft.EntityFrameworkCore;

namespace Krka.MoveOn.Services.Questionnaires
{
    public class Initial02Service(ApplicationDbContext context)
    {
        private readonly ApplicationDbContext _context = context;

        public async Task<List<QuestionnaireInitial02>> GetQuestionnaireInitial02(string questionnaireId)
        {
            return await _context.QuestionnaireInitial02s
                .Where(q => q.Questionnaire_id == questionnaireId && q.DeletedAt == null)
                .OrderByDescending(q => q.CreatedAt)
                .ToListAsync();
        }

        public async Task<List<DialActiveIngredient>> GetDialActiveIngredientAsync()
        {
            return await _context.DialActiveIngredients.ToListAsync();
        }

        public async Task SaveInitialAsync(QuestionnaireInitial02 init)
        {
            var existingEntity = await _context.QuestionnaireInitial02s.FindAsync(init.Id);
            if (existingEntity != null)
            {
                _context.Entry(existingEntity).State = EntityState.Detached;
            }

            if (init.Id == 0)
            {
                _context.QuestionnaireInitial02s.Add(init);
            }
            else
            {
                _context.QuestionnaireInitial02s.Update(init);
            }
            await _context.SaveChangesAsync();
        }

        public async Task DeleteInitAsync(int initId)
        {
            var init = await _context.QuestionnaireInitial02s.FindAsync(initId);
            if (init != null)
            {
                init.DeletedAt = DateTime.Now;
                _context.QuestionnaireInitial02s.Update(init);
                await _context.SaveChangesAsync();
            }
        }
    }
}
