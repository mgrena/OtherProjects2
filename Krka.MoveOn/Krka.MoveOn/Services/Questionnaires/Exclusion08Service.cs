using Krka.MoveOn.Data;
using Krka.MoveOn.Data.AdverseEffects;
using Krka.MoveOn.Data.Dials;
using Krka.MoveOn.Data.Questionnaires;
using Krka.MoveOn.Services.Pages;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using static System.Formats.Asn1.AsnWriter;

namespace Krka.MoveOn.Services.Questionnaires
{
    public class Exclusion08Service(ApplicationDbContext context, IServiceProvider serviceProvider, IOptions<ApplicationSettings> options)
    {
        private readonly ApplicationDbContext _context = context;
        private readonly IServiceProvider _serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));
        private readonly ApplicationSettings settings = options.Value;

        public async Task<QuestionnaireExclusion08?> GetQuestionnaireExclusion08ByQuestionnaireIdAsync(string questionnaireId)
        {
            return await Task.Run(() => _context.QuestionnaireExclusion08s
                                 .FirstOrDefault(q => q.Questionnaire_id == questionnaireId));
        }

        public async Task<List<DialQGeneral>> GetDialGeneralAsync()
        {
            return await _context.DialQGenerals.ToListAsync();
        }

        public async Task<List<DialExclusion>> GetDialExclusionAsync()
        {
            return await _context.DialExclusions.ToListAsync();
        }

        public async Task<List<DialAdverseEffect>> GetDialAdverseEffectAsync()
        {
            return await _context.DialAdverseEffects.ToListAsync();
        }

        public async Task<List<AdverseEffect>> GetAdverseEffect(string questionnaireId)
        {
            return await _context.AdverseEffects
               .Where(q => q.QuestionnaireId == questionnaireId && q.DeletedAt == null)
               .ToListAsync();
        }

        public async Task SaveQuestionnaireExlusion08Async(QuestionnaireExclusion08 questionnaire)
        {
            ArgumentNullException.ThrowIfNull(questionnaire);

            var existingQuestionnaire = await _context.QuestionnaireExclusion08s
                .FirstOrDefaultAsync(q => q.Id == questionnaire.Id);

            if (existingQuestionnaire != null)
            {
                //Ukoncije subjekt ucast v studii
                existingQuestionnaire.Exc_Q = questionnaire.Exc_Q;
                if (questionnaire.Exc_Q == 15)
                {
                    existingQuestionnaire.Exc_1 = null;
                    existingQuestionnaire.Exc_2 = null;
                    existingQuestionnaire.Exc_3 = null;
                }
                else
                {
                    existingQuestionnaire.Exc_1 = questionnaire.Exc_1;
                    existingQuestionnaire.Exc_2 = questionnaire.Exc_2;
                    existingQuestionnaire.Exc_3 = questionnaire.Exc_3;
                    existingQuestionnaire.ModifiedAt = DateTime.Now;
                }
                _context.QuestionnaireExclusion08s.Update(existingQuestionnaire);
            }
            else
            {
                // Pridanie nového záznamu
                _context.QuestionnaireExclusion08s.Add(questionnaire);
            }

            // prepnutie stavu na "Pred%case vylucený" a "Aktivný"
            if (questionnaire.Exc_Q == 14 || questionnaire.Exc_Q == 15)
            {
                var questionnaireRecord = await _context.Questionnaires
                    .FirstOrDefaultAsync(q => q.Id == questionnaire.Questionnaire_id);

                if (questionnaireRecord != null)
                {
                    var patient = await _context.Patients
                        .FirstOrDefaultAsync(p => p.Id == questionnaireRecord.PatientId);

                    if (patient != null)
                    {
                        patient.Valid = questionnaire.Exc_Q == 14
                            ? Patient.ValidEnum.Predčasne_vylúčený
                            : Patient.ValidEnum.Aktivný;
                        patient.ModifiedAt = DateTime.Now;
                        _context.Patients.Update(patient);

                        //if (serviceProvider.GetRequiredService<IEmailSender<ApplicationUser>>() is EmailSender emailSender)
                        //{
                        //    var userService = serviceProvider.GetRequiredService<UserService>();
                        //    string? doctorName = "?";
                        //    if (userService != null)
                        //    {
                        //        var user = await userService.GetUserByIdAsync(patient.UserId);
                        //        if (user != null) doctorName = user.FullName;
                        //    }

                        //    string body = string.Format("<p>Dobrý deň,</><p>toto je automaticky generovaný e-mail.</p>" +
                        //        "<p>Na stránke <a href='https://studiamoveon.sk/'>studiamoveon.sk</a> bol predčasne vylúčený pacient {0} lekára {1}.</p>" +
                        //        "<p>S pozdravom,<br>Váš tím podpory</p>", patient.PatientCode, doctorName);
                        //    await emailSender.SendEmailAsync(settings.ExclusionEmail, "studiamoveon.sk predcasne vylucenie", body);
                        //}
                    }
                }
            }


            await _context.SaveChangesAsync();
        }

        public async Task AdverserEffectAsync(AdverseEffect exc)
        {
            var existingEntity = await _context.AdverseEffects.FindAsync(exc.Id);
            if (existingEntity != null)
            {
                _context.Entry(existingEntity).State = EntityState.Detached;
            }

            if (exc.Id == 0)
            {
                _context.AdverseEffects.Add(exc);

                // send info email
                // 1. questionnaire
                var quest = _context.Questionnaires.FirstOrDefault(i => i.Id == exc.QuestionnaireId);
                if (quest != null)
                {
                    // 2. patient
                    var patient = _context.Patients.FirstOrDefault(i => i.Id == quest.PatientId);
                    if (patient != null)
                    {
                        if (_serviceProvider.GetRequiredService<IEmailSender<ApplicationUser>>() is EmailSender emailSender)
                        {
                            var userService = _serviceProvider.GetRequiredService<UserService>();
                            string? doctorName = "?";
                            if (userService != null)
                            {
                                var user = await userService.GetUserByIdAsync(patient.UserId);
                                if (user != null) doctorName = user.FullName;
                            }

                            string body = string.Format("<p>Dobrý deň,</><p>toto je automaticky generovaný e-mail.</p>" +
                                "<p>Na stránke <a href='https://studiamoveon.sk/'>studiamoveon.sk</a> bola zaznamenaná nežiadúca udalosť {0} u pacienta s kódom {1} lekára {2}.</p>" +
                                "<p>S pozdravom,<br>Váš tím podpory</p>", exc.Name, patient.PatientCode, doctorName);
                            await emailSender.SendEmailAsync(settings.ExclusionEmail, "studiamoveon.sk neziaduce ucinky", body);
                        }
                    }
                }
            }
            else
            {
                _context.AdverseEffects.Update(exc);
            }
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAdvenceAsync(int advenceId)
        {
            var advence = await _context.AdverseEffects.FindAsync(advenceId);
            if (advence != null)
            {
                advence.DeletedAt = DateTime.Now;
                _context.AdverseEffects.Update(advence);
                await _context.SaveChangesAsync();
            }
        }
    }
}
