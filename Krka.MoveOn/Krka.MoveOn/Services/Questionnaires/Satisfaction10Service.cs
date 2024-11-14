using Krka.MoveOn.Data;
using Krka.MoveOn.Data.Dials;
using Krka.MoveOn.Data.Questionnaires;
using Krka.MoveOn.Migrations;
using Microsoft.EntityFrameworkCore;

namespace Krka.MoveOn.Services.Questionnaires;

public class Satisfaction10Service(ApplicationDbContext context)
{
    private readonly ApplicationDbContext _context = context;

    public async Task<QuestionnaireSatisfaction10> GetQuestionnaireSatisfaction10(string questionnaireId)
    {
        return await Task.Run(() => _context.QuestionnaireSatisfaction10s
            .FirstOrDefault(q => q.Questionnaire_id == questionnaireId));
    }


    public async Task SaveSatisfactionAsync(QuestionnaireSatisfaction10 satisfaction)
    {
        var existingEntity = await _context.QuestionnaireSatisfaction10s.FindAsync(satisfaction.Id);
        if (existingEntity != null)
        {
            _context.Entry(existingEntity).State = EntityState.Detached;
        }

        satisfaction.ProgressPercentage = 
            ((satisfaction.SF_1 != null ? 100 : 0) +
            (satisfaction.SF_2 != null ? 100 : 0) +
            (satisfaction.SF_3 != null ? 100 : 0) +
            (satisfaction.SF_4 != null ? 100 : 0)) / 4;

        if (satisfaction.Id == 0)
        {
            _context.QuestionnaireSatisfaction10s.Add(satisfaction);
        }
        else
        {
            _context.QuestionnaireSatisfaction10s.Update(satisfaction);
        }
        await _context.SaveChangesAsync();
    }



}
