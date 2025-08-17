using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisasterPredictionApi.Domain.Entities
{
    public class MastRegions
    {
        [Key]
        public int RegionId { get; set; }
        public string? Name { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
    }
}
