using DisasterPredictionApi.Application.DTOs;
using DisasterPredictionApi.Application.Interfaces;
using DisasterPredictionApi.Domain.Entities;
using DisasterPredictionApi.Infrastructure;
using DisasterPredictionApi.Infrastructure.Data;
using DisasterPredictionApi.Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace DisasterPredictionApi.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class AlertsController : Controller
    {
        private readonly IAlertRepository _alertRepository;
        private readonly AppDbContext _dbContext;

        public AlertsController(IAlertRepository alertRepository, AppDbContext context)
        {
            _alertRepository = alertRepository;
            _dbContext = context;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllAlerts()
        {
            try
            {
                var alert = await _alertRepository.GetAll();
                return Ok(alert);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }
}
