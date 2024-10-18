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
            .Where(q => q.Questionnaire_id == questionnaireId && q.DeletedAt == null)
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

    public async Task SaveTreatmentAsync(QuestionnaireTreatment03 treat)
    {
        var existingEntity = await _context.QuestionnaireTreatment03s.FindAsync(treat.Id);
        if (existingEntity != null)
        {
            _context.Entry(existingEntity).State = EntityState.Detached;
        }

        if (treat.Id == 0)
        {
            _context.QuestionnaireTreatment03s.Add(treat);
        }
        else
        {
            _context.QuestionnaireTreatment03s.Update(treat);
        }
        await _context.SaveChangesAsync();
    }


    public async Task DeleteTreatAsync(int treatId)
    {
        var treat = await _context.QuestionnaireTreatment03s.FindAsync(treatId);
        if (treat != null)
        {
            treat.DeletedAt = DateTime.Now;
            _context.QuestionnaireTreatment03s.Update(treat);
            await _context.SaveChangesAsync();
        }
    }
}
