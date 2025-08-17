using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisasterPredictionApi.Domain.Entities
{
    public class Alerts
    {
        public int Id { get; set; }
        public int RegionId { get; set; }
        public int DisasterTypeId { get; set; }
        public string? RiskLevel { get; set; }
        public string? Message { get; set; }
        public bool IsSent { get; set; } = true;
        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
    }
}
