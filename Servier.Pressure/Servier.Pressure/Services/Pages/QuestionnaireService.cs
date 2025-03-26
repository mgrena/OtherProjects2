using Microsoft.AspNetCore.Components.Authorization;
using Servier.Pressure.Data;

namespace Servier.Pressure.Services.Pages;

public class QuestionnaireService(ApplicationDbContext context, ILogger<QuestionnaireService> logger)
{
    private readonly ApplicationDbContext _context = context;
    private readonly ILogger _logger = logger;


}
