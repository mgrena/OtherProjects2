using Krka.MoveOn.Data;
using Krka.MoveOn.Data.Dials;
using Krka.MoveOn.Data.Questionnaires;
using Microsoft.EntityFrameworkCore;

namespace Krka.MoveOn.Services.Questionnaires;

public class Treatment03Service(ApplicationDbContext context)
{
    private readonly ApplicationDbContext _context = context;

    public async Task<List<QuestionnaireTreatment03>> GetQuestionnaireTreatment03(int questionnaireId)
    {
        return await _context.QuestionnaireTreatment03s
            .Where(q => q.Questionnaire_id == questionnaireId)
            .ToListAsync();
    }


    public async Task<List<DialIndication>> GetDialIndicationAsync()
    {
        return await _context.DialIndication.ToListAsync();
    }

    public async Task<List<DialActiveIngredient>> GetDialActiveIngredientAsync()
    {
        return await _context.DialActiveIngredients.ToListAsync();
    }

}
