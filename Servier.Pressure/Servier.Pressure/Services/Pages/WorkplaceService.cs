using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.EntityFrameworkCore;
using Servier.Pressure.Components.Pages;
using Servier.Pressure.Data;
using Servier.Pressure.Data.Models;
using Servier.Pressure.Helpers;
using Servier.Pressure.Migrations;

namespace Servier.Pressure.Services.Pages;

public class WorkplaceService(ApplicationDbContext context, AuthenticationStateProvider authenticationStateProvider, ILogger<WorkplaceService> logger)
{
    private readonly ApplicationDbContext _context = context;
    private readonly AuthenticationStateProvider _authenticationStateProvider = authenticationStateProvider;
    private readonly ILogger _logger = logger;

    public async Task<WorkPlace> GetWorkplaceByUserIdAsync(string userId)
    {
        WorkPlace? workplace = await _context.WorkPlaces.FirstOrDefaultAsync(p => p.UserId == userId);
        workplace ??= new() { UserId = userId, CreatedAt = DateTime.Now, Workplace = string.Empty };
        return workplace;
    }
    public async Task<OperationResult> SaveWorkplaceAsync(WorkPlace workplace, string userId)
    {
        var existWorkplace = await _context.WorkPlaces.FirstOrDefaultAsync(i => i.Id == workplace.Id);
        if (existWorkplace == null)
        {
            _logger.LogInformation("The workplace for user {user} has been added.", userId);
            _context.WorkPlaces.Add(workplace);
        }
        else 
        {
            _logger.LogInformation("The workplace with id {id} has been updated.", workplace.Id);
            existWorkplace.WorkplaceType = workplace.WorkplaceType;
            existWorkplace.Specialization = workplace.Specialization;
            existWorkplace.PatientsCountAll = workplace.PatientsCountAll;
            existWorkplace.PatientsCountAllUnknown = workplace.PatientsCountAllUnknown;
            existWorkplace.PatientsCountAH = workplace.PatientsCountAH;
            existWorkplace.PatientsCountAHUnknown = workplace.PatientsCountAHUnknown;
        }

        try
        {
            await _context.SaveChangesAsync();
            return OperationResult.SuccessResult();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, ex.Message);
            return OperationResult.FailureResult("Pri ukladaní údajov došlo k neočakávanej chybe.", ex.Message);
        }
    }
}
