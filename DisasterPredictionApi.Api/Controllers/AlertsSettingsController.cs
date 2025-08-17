using DisasterPredictionApi.Application.DTOs;
using DisasterPredictionApi.Application.Interfaces;
using DisasterPredictionApi.Domain.Entities;
using DisasterPredictionApi.Infrastructure;
using DisasterPredictionApi.Infrastructure.Data;
using DisasterPredictionApi.Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;


namespace DisasterPredictionApi.Api.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class AlertsSettingsController : ControllerBase
    {
        private readonly IAlertSettingRepository _alertSettingsRepository;
        private readonly AppDbContext _dbContext;

        public AlertsSettingsController(IAlertSettingRepository alertSettingsRepository, AppDbContext context)
        {
            _alertSettingsRepository = alertSettingsRepository;
            _dbContext = context;
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AlertDto.CreateSettings req)
        {
            try
            {
                var data = new AlertSettings
                {
                    RegionId = req.RegionId,
                    DisasterTypeId = req.DisasterTypeId,
                    ThresholdScore = req.ThresholdScore,
                    CreatedAt = DateTimeOffset.UtcNow,
                    UpdatedAt = DateTimeOffset.UtcNow,
                };

                await _alertSettingsRepository.Add(data);
                await _dbContext.SaveChangesAsync();
                return StatusCode(StatusCodes.Status201Created, new
                {
                    message = "Created successfully",
                    status = 201,
                    results = data
                });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
