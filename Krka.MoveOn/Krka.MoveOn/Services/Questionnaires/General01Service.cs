using Krka.MoveOn.Data;
using Krka.MoveOn.Data.Dials;
using Krka.MoveOn.Data.Questionnaires;
using Krka.MoveOn.Data.RelationalTables;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Krka.MoveOn.Services.Questionnaires
{
    public class General01Service(ApplicationDbContext context)
    {
        private readonly ApplicationDbContext _context = context;

        public async Task<QuestionnaireGeneral01?> GetQuestionnaireGeneral01ByQuestionnaireIdAsync(string questionnaireId)
        {
            return await _context.QuestionnaireGeneral01s
                                 .FirstOrDefaultAsync(q => q.Questionnaire_id == questionnaireId);
        }

        public async Task<List<DialQGeneral>> GetDialQGeneralsAsync()
        {
            return await _context.DialQGenerals.ToListAsync();
        }

        public async Task SaveQuestionnaireGeneral01Async(QuestionnaireGeneral01 questionnaire)
        {
            ArgumentNullException.ThrowIfNull(questionnaire);

            questionnaire.ProgressPercentage = 100;

            var existingQuestionnaire = await _context.QuestionnaireGeneral01s
                .FirstOrDefaultAsync(q => q.Id == questionnaire.Id);

            if (existingQuestionnaire != null)
            {
                existingQuestionnaire.Gen_1 = questionnaire.Gen_1;
                existingQuestionnaire.Gen_2_DG = questionnaire.Gen_2_DG;
                existingQuestionnaire.Gen_3_DG = questionnaire.Gen_3_DG;
                existingQuestionnaire.Gen_4_DG = questionnaire.Gen_4_DG;
                existingQuestionnaire.Gen_5_D = questionnaire.Gen_5_D;
                existingQuestionnaire.Gen_6_DG = questionnaire.Gen_6_DG;

                // Anamnéza užívania antipsychotík
                existingQuestionnaire.Gen_7_DG = questionnaire.Gen_7_DG;

                if (questionnaire.Gen_7_DG == 17)
                {
                    //tabulka Gen7YesRelational
                    var relatedItems = await _context.Gen7YesRelationals
                        .Where(r => r.GenQuestId == questionnaire.Id)
                        .ToListAsync();

                    foreach (var relatedItem in relatedItems) 
                    {
                        relatedItem.Gen_7_1_DM = null;
                        relatedItem.Gen_7_1_1 = null;
                        relatedItem.Gen_7_1_2 = null;
                        relatedItem.Gen_7_1_4 = null;
                        relatedItem.Gen_7_2 = null;
                        relatedItem.Gen_7_4 = null;
                        relatedItem.DeletedAt = DateTime.Now;
                    }

                    _context.Gen7YesRelationals.UpdateRange(relatedItems);
                }                

                existingQuestionnaire.Gen_8 = questionnaire.Gen_8;

                //Bol pacient už kvôli tomuto príznaku vyšetrený .ortopédom, psychiatrom a pod.?
                existingQuestionnaire.Gen_10 = questionnaire.Gen_10;
                if (questionnaire.Gen_10 == 15)
                {
                    existingQuestionnaire.Gen_10_1 = null;
                    existingQuestionnaire.Gen_10_1_1 = null;
                }
                else
                {
                    existingQuestionnaire.Gen_10_1 = questionnaire.Gen_10_1;
                    existingQuestionnaire.Gen_10_1_1 = questionnaire.Gen_10_1_1;
                }

                existingQuestionnaire.Gen_11 = questionnaire.Gen_11;
                existingQuestionnaire.Gen_12 = questionnaire.Gen_12;

                //Pacientovi je diagnostikované/je podozrenie na (Ak zada "Iný parkinsonský syndróm ")
                existingQuestionnaire.Gen_13 = questionnaire.Gen_13;

                if (questionnaire.Gen_13 == 54 || questionnaire.Gen_13 == 56)
                {
                    existingQuestionnaire.Gen_13_1 = null;

                }
                else
                {
                    existingQuestionnaire.Gen_13_1 = questionnaire.Gen_13_1;
                }

                existingQuestionnaire.ModifiedAt = DateTime.Now;

                _context.QuestionnaireGeneral01s.Update(existingQuestionnaire);
            }
            else
            {
                // Pridanie nového záznamu
                _context.QuestionnaireGeneral01s.Add(questionnaire);
            }

            await _context.SaveChangesAsync();

        }

        public async Task SaveGen9DSRelationAsync(int genId, IEnumerable<int?> selectedIds)
        {
            var existingRelations = await _context.Gen9DSRelationals
                .Where(r => r.GenQuestId == genId)
                .ToListAsync();

            foreach (var relation in existingRelations)
            {
                if (selectedIds.Contains(relation.Gen9DSAnswerId))
                {
                    relation.CreatedAt = DateTime.Now;
                }
                else
                {
                    relation.CreatedAt = null;
                }

                relation.ModifiedAt = DateTime.Now;
            }

            foreach (var selectedId in selectedIds)
            {
                var gen9DSRelational = new Gen9DSRelational
                {
                    GenQuestId = genId,
                    Gen9DSAnswerId = selectedId,
                    CreatedAt = DateTime.Now,
                    ModifiedAt = DateTime.Now,
                };

                await _context.Gen9DSRelationals.AddAsync(gen9DSRelational);
            }

            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<int>> LoadSelectedGen9DSAsync(int genId)
        {
            return await _context.Gen9DSRelationals
                .Where(r => r.GenQuestId == genId && r.CreatedAt != null)
                .Select(r => r.Gen9DSAnswerId!.Value)
                .ToListAsync();
        }

        public async Task<List<Gen7YesRelational>> LoadGen7YesTableAsync(int id)
        {
            return await _context.Gen7YesRelationals
                .Where(r => r.GenQuestId == id && r.DeletedAt == null)
                .ToListAsync();
        }

        public async Task DeleteGen7YesAsync(int gen7YesId)
        {
            var gen7Yes = await _context.Gen7YesRelationals.FindAsync(gen7YesId);
            if (gen7Yes != null)
            {
                gen7Yes.DeletedAt = DateTime.Now;
                _context.Gen7YesRelationals.Update(gen7Yes);
                await _context.SaveChangesAsync();
            }
        }

        public async Task SaveGen7YesRelationAsync(int genId, Gen7YesRelational gen7YesRelational)
        {
            gen7YesRelational.GenQuestId = genId;

            var existingItem = await _context.Gen7YesRelationals.FirstOrDefaultAsync(r => r.Id == gen7YesRelational.Id);

            if (existingItem == null) 
            {
                await _context.Gen7YesRelationals.AddAsync(gen7YesRelational);
            }
            else
            {
                existingItem.Gen_7_1_DM = gen7YesRelational.Gen_7_1_DM;
                if (existingItem.Gen_7_1_DM != 34)
                {
                    existingItem.Gen_7_1_1 = null;
                    existingItem.Gen_7_1_2 = null;
                    existingItem.Gen_7_1_4 = null;
                    existingItem.Gen_7_2 = gen7YesRelational.Gen_7_2;
                    existingItem.Gen_7_4 = gen7YesRelational.Gen_7_4;
                }
                else
                {
                    existingItem.Gen_7_2 = null;
                    existingItem.Gen_7_4 = null;
                    existingItem.Gen_7_1_1 = gen7YesRelational.Gen_7_1_1;
                    existingItem.Gen_7_1_2 = gen7YesRelational.Gen_7_1_2;
                    existingItem.Gen_7_1_4 = gen7YesRelational.Gen_7_1_4;
                }

              

                existingItem.ModifiedAt = DateTime.Now;
            }

            await _context.SaveChangesAsync();
        }
    }
}
