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
        return await Task.Run(() => {
            var items = _context.QuestionnaireDrugEffect09s.Where(q => q.Questionnaire_id == questionnaireId);
            // find item with yes answer
            var itemYes = items.FirstOrDefault(q => q.De_1 == 14 && q.DeletedAt == null);
            if (itemYes != null) { return itemYes; }
            // check for item with no answer
            var itemNo = items.FirstOrDefault(q => q.De_1 == 15 && q.DeletedAt == null);
            if (itemNo != null) { return itemNo; }
            // exists deleted items, return answer no
            var itemsDeleted = items.Where(q => q.DeletedAt != null);
            if (itemsDeleted.Any())
                return new QuestionnaireDrugEffect09() { Questionnaire_id = questionnaireId, De_1 = 15, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now };
            // return nothing
            return null;
        });
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
        if (drugEffect.De_1 == 15)
        {
            var relatedEntities = await _context.QuestionnaireDrugEffect09s
                .Where(q => q.Questionnaire_id == drugEffect.Questionnaire_id && q.DeletedAt == null)
                .ToListAsync();

            foreach (var entity in relatedEntities)
            {
                entity.De_2 = null;
                entity.De_3 = null;
                entity.De_4 = null;
                entity.De_5 = null;
                entity.DeletedAt = DateTime.Now;
                entity.ModifiedAt = DateTime.Now;
                _context.QuestionnaireDrugEffect09s.Update(entity);
            }
        }

        if (drugEffect.Id == 0)
        {
            var newEntity = new QuestionnaireDrugEffect09()
                { Questionnaire_id = drugEffect.Questionnaire_id, De_1 = drugEffect.De_1, De_2 = drugEffect.De_2, De_3 = drugEffect.De_3, De_4 = drugEffect.De_4, De_5 = drugEffect.De_5, 
                  ModifiedAt = DateTime.Now, CreatedAt = DateTime.Now };
            if (newEntity.De_1 == null && newEntity.De_2 != null)
                newEntity.De_1 = 14;

            // check for existing no items
            var noitems = _context.QuestionnaireDrugEffect09s.Where(q => q.Questionnaire_id == drugEffect.Questionnaire_id && q.DeletedAt == null && q.De_1 == 15);
            foreach (var item in noitems)
                item.DeletedAt = DateTime.Now;

            _context.QuestionnaireDrugEffect09s.Add(newEntity);
        }
        else
        {
            var existingEntity = await _context.QuestionnaireDrugEffect09s.FirstAsync(d => d.Id == drugEffect.Id);
            existingEntity.De_1 = drugEffect.De_1;
            existingEntity.De_2 = drugEffect.De_2;
            existingEntity.De_3 = drugEffect.De_3;
            existingEntity.De_4 = drugEffect.De_4;
            existingEntity.De_5 = drugEffect.De_5;
            existingEntity.ModifiedAt = DateTime.Now;
            _context.QuestionnaireDrugEffect09s.Update(existingEntity);
        }
        await _context.SaveChangesAsync();
    }
}
