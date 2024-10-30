using Krka.MoveOn.Data;
using Krka.MoveOn.Data.Dials;
using Krka.MoveOn.Data.Questionnaires;
using Microsoft.EntityFrameworkCore;

namespace Krka.MoveOn.Services.Questionnaires
{
    public class General01Service(ApplicationDbContext context)
    {
        private readonly ApplicationDbContext _context = context;

        public async Task<QuestionnaireGeneral01?> GetQuestionnaireGeneral01ByQuestionnaireIdAsync(string questionnaireId)
        {
            return await Task.Run(() => _context.QuestionnaireGeneral01s
                                 .FirstOrDefaultAsync(q => q.Questionnaire_id == questionnaireId));
        }

        public async Task<List<DialQGeneral>> GetDialQGeneralsAsync()
        {
            return await _context.DialQGenerals.ToListAsync();
        }

        public async Task SaveQuestionnaireGeneral01Async(QuestionnaireGeneral01 questionnaire)
        {
            if (questionnaire == null)
            {
                throw new ArgumentNullException(nameof(questionnaire));
            }

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
                    existingQuestionnaire.Gen_7_1_DM = null;
                    existingQuestionnaire.Gen_7_2 = null;
                    existingQuestionnaire.Gen_7_3_DU = null;
                    existingQuestionnaire.Gen_7_4 = null;
                    existingQuestionnaire.Gen_7_1_1 = null;
                    existingQuestionnaire.Gen_7_1_2 = null;
                    existingQuestionnaire.Gen_7_1_3_DU = null;
                    existingQuestionnaire.Gen_7_1_4 = null;
                }
                else
                {
                    existingQuestionnaire.Gen_7_1_DM = questionnaire.Gen_7_1_DM;
                    existingQuestionnaire.Gen_7_2 = questionnaire.Gen_7_2;
                    existingQuestionnaire.Gen_7_3_DU = questionnaire.Gen_7_3_DU;
                    existingQuestionnaire.Gen_7_4 = questionnaire.Gen_7_4;
                    existingQuestionnaire.Gen_7_1_1 = questionnaire.Gen_7_1_1;
                    existingQuestionnaire.Gen_7_1_2 = questionnaire.Gen_7_1_2;
                    existingQuestionnaire.Gen_7_1_3_DU = questionnaire.Gen_7_1_3_DU;
                    existingQuestionnaire.Gen_7_1_4 = questionnaire.Gen_7_1_4;
                }

                existingQuestionnaire.Gen_8 = questionnaire.Gen_8;
                existingQuestionnaire.Gen_9_DS = questionnaire.Gen_9_DS;

                //Bol pacient už kvôli tomuto príznaku vyšetrený .ortopédom, psychiatrom a pod.?
                existingQuestionnaire.Gen_10 = questionnaire.Gen_10;
                if (questionnaire.Gen_10 == 15)
                {
                    existingQuestionnaire.Gen_10_1 = null;
                }
                else
                {
                    existingQuestionnaire.Gen_10_1 = questionnaire.Gen_10_1;
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
    }
}
