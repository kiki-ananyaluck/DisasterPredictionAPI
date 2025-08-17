using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DisasterPredictionApi.Application.Interfaces;
using DisasterPredictionApi.Domain.Entities;
using DisasterPredictionApi.Infrastructure.Data;

namespace DisasterPredictionApi.Infrastructure.Repositories
{
    public class AlertSettingRepository : BaseRepository<AlertSettings>, IAlertSettingRepository
    {
        private readonly AppDbContext _dbContext;
        public AlertSettingRepository(AppDbContext context) : base(context)
        {
            _dbContext = context;
        }
    }
}
