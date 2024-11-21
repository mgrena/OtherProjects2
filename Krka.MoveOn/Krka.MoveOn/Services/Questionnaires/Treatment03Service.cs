using Krka.MoveOn.Data;
using Krka.MoveOn.Data.Dials;
using Krka.MoveOn.Data.Questionnaires;
using Microsoft.EntityFrameworkCore;

namespace Krka.MoveOn.Services.Questionnaires;

public class Treatment03Service(ApplicationDbContext context)
{
    private readonly ApplicationDbContext _context = context;

    public async Task<List<QuestionnaireTreatment03>> GetQuestionnaireTreatment03(string questionnaireId)
    {
        return await _context.QuestionnaireTreatment03s
            .Where(q => q.Questionnaire_id == questionnaireId && q.DeletedAt == null)
            .OrderByDescending(q => q.CreatedAt)
            .ToListAsync();
    }

    public async Task<QuestionnaireTreatment03?> GetQuestionnaireTreatment03ByQuestionnaireIdAsync(string questionnaireId)
    {
        return await Task.Run(() => {
            var items = _context.QuestionnaireTreatment03s.Where(q => q.Questionnaire_id == questionnaireId);
            // find item with yes answer
            var itemYes = items.FirstOrDefault(q => q.TreatQ1 == 14 && q.DeletedAt == null);
            if (itemYes != null) { return itemYes; }
            // check for item with no answer
            var itemNo = items.FirstOrDefault(q => q.TreatQ1 == 15 && q.DeletedAt == null);
            if (itemNo != null) { return itemNo; }
            // exists deleted items, return answer no
            var itemsDeleted = items.Where(q => q.DeletedAt != null);
            if (itemsDeleted.Any())
                return new QuestionnaireTreatment03() { Questionnaire_id = questionnaireId, TreatQ1 = 15, CreatedAt = DateTime.Now, ModifiedAt = DateTime.Now };
            // return nothing
            return null;
        });
    }

    public async Task<List<DialIndication>> GetDialIndicationAsync()
    {
        return await _context.DialIndication.ToListAsync();
    }

    public async Task<List<DialActiveIngredient>> GetDialActiveIngredientAsync()
    {
        return await _context.DialActiveIngredients.ToListAsync();
    }

    public async Task<List<DialQGeneral>> GetDialGeneralAsync()
    {
        return await _context.DialQGenerals.ToListAsync();
    }

    public async Task SaveTreatmentAsync(QuestionnaireTreatment03 treat)
    {
        if (treat.TreatQ1 == 15)
        {
            var relatedEntities = await _context.QuestionnaireTreatment03s
                .Where(q => q.Questionnaire_id == treat.Questionnaire_id && q.DeletedAt == null)
                .ToListAsync();

            foreach (var entity in relatedEntities)
            {
                entity.Treat_1 = null;
                entity.Treat_2 = null;
                entity.Treat_3 = null;
                entity.OtherIndication = null;
                entity.DeletedAt = DateTime.Now;
                entity.ModifiedAt = DateTime.Now;
                _context.QuestionnaireTreatment03s.Update(entity);
            }
        }

        if (treat.Id == 0)
        {
            var newEntity = new QuestionnaireTreatment03() { Questionnaire_id = treat.Questionnaire_id, TreatQ1 = treat.TreatQ1, OtherIndication = treat.OtherIndication, OtherTreat = treat.OtherTreat, Treat_1 = treat.Treat_1, Treat_2 = treat.Treat_2, 
                                                             Treat_3 = treat.Treat_3, ModifiedAt = DateTime.Now, CreatedAt = DateTime.Now};
            if (newEntity.TreatQ1 == null && newEntity.Treat_1 != null)
                newEntity.TreatQ1 = 14;

            // check for existing no items
            var noitems = _context.QuestionnaireTreatment03s.Where(q => q.Questionnaire_id == treat.Questionnaire_id && q.DeletedAt == null && q.TreatQ1 == 15);
            foreach (var item in noitems)
                item.DeletedAt = DateTime.Now;

            _context.QuestionnaireTreatment03s.Add(newEntity);
        }
        else
        {
            var existingEntity = await _context.QuestionnaireTreatment03s.FirstAsync(d => d.Id == treat.Id);
            existingEntity.TreatQ1 = treat.TreatQ1;
            existingEntity.Treat_1 = treat.Treat_1;
            existingEntity.Treat_2 = treat.Treat_2;
            existingEntity.Treat_3 = treat.Treat_3;
            existingEntity.OtherIndication = treat.OtherIndication;
            existingEntity.OtherTreat = treat.OtherTreat;
            existingEntity.ModifiedAt = DateTime.Now;
            _context.QuestionnaireTreatment03s.Update(existingEntity);
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
