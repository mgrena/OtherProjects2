using Krka.MoveOn.Data;
using Krka.MoveOn.Data.Dials;
using Microsoft.EntityFrameworkCore;

namespace Krka.MoveOn.Services.Questionnaires;

public class Treatment03Service(ApplicationDbContext context)
{
    private readonly ApplicationDbContext _context = context;

    public async Task<List<DialActiveIngredient>> GetActiveIngredient() { 
        var list = await _context.DialActiveIngredients.Where(i => i.Type_q == 2).ToListAsync();
        return list;
    }
}
