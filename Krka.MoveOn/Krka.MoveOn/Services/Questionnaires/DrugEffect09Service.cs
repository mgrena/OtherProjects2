using Krka.MoveOn.Data;
using Krka.MoveOn.Data.Dials;
using Krka.MoveOn.Data.Questionnaires;
using Microsoft.EntityFrameworkCore;

namespace Krka.MoveOn.Services.Questionnaires;

public class DrugEffect09Service(ApplicationDbContext context)
{
    private readonly ApplicationDbContext _context = context;

    public async Task<List<QuestionnaireDrugEffect09>> GetQuestionnaireDrugEffect09(string questionnaireId)
    {
        return await _context.QuestionnaireDrugEffect09s
            .Where(q => q.Questionnaire_id == questionnaireId && q.DeletedAt == null)
            .OrderByDescending(q => q.CreatedAt)
            .ToListAsync();
    }

    public async Task<QuestionnaireDrugEffect09?> GetQuestionnaireDrugEffect09ByQuestionnaireIdAsync(string questionnaireId)
    {
        return await Task.Run(() => _context.QuestionnaireDrugEffect09s
                             .FirstOrDefault(q => q.Questionnaire_id == questionnaireId));
    }

    public async Task<List<DialQGeneral>> GetDialGeneralAsync()
    {
        return await _context.DialQGenerals.ToListAsync();
    }

    public async Task<List<DialIndication>> GetDialIndicationAsync()
    {
        return await _context.DialIndication.ToListAsync();
    }

    public async Task<List<DialActiveIngredient>> GetDialActiveIngredientAsync()
    {
        return await _context.DialActiveIngredients.ToListAsync();
    }

    public async Task SaveDrugEffectAsync(QuestionnaireDrugEffect09 drugEffect)
    {
        var existingEntity = await _context.QuestionnaireDrugEffect09s.FindAsync(drugEffect.Id);
        if (existingEntity != null)
        {
            _context.Entry(existingEntity).State = EntityState.Detached;
        }

        if (drugEffect.Id == 0)
        {
            _context.QuestionnaireDrugEffect09s.Add(drugEffect);
        }
        else
        {
            _context.QuestionnaireDrugEffect09s.Update(drugEffect);
        }
        await _context.SaveChangesAsync();
    }
}
