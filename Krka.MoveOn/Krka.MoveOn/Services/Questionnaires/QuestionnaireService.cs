using Krka.MoveOn.Data;
using Krka.MoveOn.Data.Dials;
using Krka.MoveOn.Data.Questionnaires;
using Microsoft.EntityFrameworkCore;

namespace Krka.MoveOn.Services.Questionnaires;

public class QuestionnaireService(ApplicationDbContext context)
{
    private readonly ApplicationDbContext _context = context;

    public async Task SaveQuestionnaireAsync(Questionnaire questionnaire)
    {
        if (questionnaire == null)
        {
            throw new ArgumentNullException(nameof(questionnaire));
        }

        _context.Questionnaires.Add(questionnaire);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Nacitanie Sekcii z tabulky Questionnaire na zaklade PatientId (Entry, Goind, Result)
    /// </summary>
    /// <param name="patientId"></param>
    /// <returns></returns>
    public async Task<List<Questionnaire>> GetQuestionnairesByPatientIdAsync(int patientId)
    {
        return await _context.Questionnaires
                             .Where(q => q.PatientId == patientId)
                             .ToListAsync();
    }
}
