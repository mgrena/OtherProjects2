using Krka.MoveOn.Data;
using Krka.MoveOn.Data.Dials;
using Krka.MoveOn.Data.Questionnaires;
using Microsoft.EntityFrameworkCore;

namespace Krka.MoveOn.Services.Questionnaires
{
    public class General01Service(ApplicationDbContext context)
    {
        private readonly ApplicationDbContext _context = context;

        public async Task<QuestionnaireGeneral01> GetQuestionnaireGeneral01ByQuestionnaireIdAsync(int questionnaireId)
        {
            return await _context.QuestionnaireGeneral01s
                                 .FirstOrDefaultAsync(q => q.Questionnaire_id == questionnaireId);
        }

        public async Task<List<DialQGeneral>> GetDialQGeneralsAsync()
        {
            return await _context.DialQGenerals.ToListAsync();
        }

        public async Task SaveQuestionnaireGeneral01Async(QuestionnaireGeneral01 questionnaire)
        {
            if (questionnaire == null)
            {
                throw new ArgumentNullException(nameof(questionnaire));
            }
            
            _context.QuestionnaireGeneral01s.Add(questionnaire);
            await _context.SaveChangesAsync();
           
         
        }
    }
}
