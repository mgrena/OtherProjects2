using Krka.MoveOn.Data;
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


    }    
}
