using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisasterPredictionApi.Domain.Entities
{
    public class AlertSettings
    {
        public int Id { get; set; }
        public int RegionId { get; set; }
        public int DisasterTypeId { get; set; }
        public int ThresholdScore { get; set; }
        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
        public DateTimeOffset UpdatedAt { get; set; } = DateTimeOffset.UtcNow;

    }
}
