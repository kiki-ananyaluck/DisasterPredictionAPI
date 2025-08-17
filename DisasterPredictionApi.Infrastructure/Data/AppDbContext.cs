using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DisasterPredictionApi.Domain.Entities;

namespace DisasterPredictionApi.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Alerts> Alerts => Set<Alerts>();
        public DbSet<AlertSettings> AlertsSettings => Set<AlertSettings>();
        public DbSet<MastDisasterType> MastDisasters => Set<MastDisasterType>();
        public DbSet<MastRegions> MastRegions => Set<MastRegions>();
        public DbSet<Regions> Regions => Set<Regions>();
        public DbSet<RiskLoge> RiskLoges => Set<RiskLoge>();


    }
}
