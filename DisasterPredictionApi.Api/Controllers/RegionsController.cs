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
    public class RegionsController : ControllerBase
    {
        private readonly IRegionRepository _regionRepository;
        private readonly AppDbContext _dbContext;

        public RegionsController(IRegionRepository regionRepository, AppDbContext context)
        {
            _regionRepository = regionRepository;
            _dbContext = context;
        }


        [HttpPost]
        public async Task<IActionResult> Create([FromBody] RegionDto.Create req)
        {
            try
            {
                var data = new Regions
                {
                    RegionId = req.RegionId,
                    DisasterTypeId = req.DisasterTypeId,
                    CreatedAt = DateTimeOffset.UtcNow,
                    UpdatedAt = DateTimeOffset.UtcNow,
                };

                await _regionRepository.Add(data);
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
