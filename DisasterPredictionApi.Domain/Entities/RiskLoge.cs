using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisasterPredictionApi.Domain.Entities
{
    public class RiskLoge
    {
        [Key]
        public int RiskLogId { get; set; }
        public int RegionId { get; set; }
        public int DisasterTypeId { get; set; }
        public float RiskSore { get; set; }
        public string? RiskLevel { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
