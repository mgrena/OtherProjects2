﻿using Krka.MoveOn.Data;
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
                             .Where(q => q.PatientId == patientId).OrderBy(q => q.CreatedAt)
                             .ToListAsync();
    }

    /// <summary>
    /// Nacitanie Sekcii z tabulky Questionnaire na zaklade Id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task<Questionnaire> GetQuestionnairesByIdAsync(string id)
    {
        return await _context.Questionnaires
                             .FirstOrDefaultAsync(q => q.Id == id);
    }

    public async Task UpdateQuestionnaireAsync(Questionnaire questionnaire)
    {
        if (questionnaire == null)
        {
            throw new ArgumentNullException(nameof(questionnaire));
        }

        var existingQuestionnaire = await _context.Questionnaires
                                                  .FirstOrDefaultAsync(q => q.Id == questionnaire.Id);

        if (existingQuestionnaire == null)
        {
            throw new InvalidOperationException($"Questionnaire with ID {questionnaire.Id} not found.");
        }

        _context.Entry(existingQuestionnaire).CurrentValues.SetValues(questionnaire);

        await _context.SaveChangesAsync();
    }
}