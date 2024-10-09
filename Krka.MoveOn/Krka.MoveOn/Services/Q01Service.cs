using Krka.MoveOn.Data;
using Krka.MoveOn.Data.Dials;
using Krka.MoveOn.Data.Questionnaires;
using Microsoft.EntityFrameworkCore;

namespace Krka.MoveOn.Services
{
    public class Q01Service(ApplicationDbContext context)
    {
        private readonly ApplicationDbContext _context = context;

        public async Task<List<QuestionnaireGeneral01>> GetQuestionnairesAsync()
        {
            return await _context.QuestionnaireGeneral01s.ToListAsync();
        }

        public async Task<List<DialQGeneral>> GetDialQGeneralsAsync()
        {
            return await _context.DialQGenerals.ToListAsync();
        }


    }    
}
