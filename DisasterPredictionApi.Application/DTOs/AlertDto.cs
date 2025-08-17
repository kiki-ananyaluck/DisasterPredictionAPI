using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisasterPredictionApi.Application.DTOs
{
    public class AlertDto
    {
        public class CreateSettings
        {
            public int RegionId { get; set; }
            public int DisasterTypeId { get; set; }
            public int ThresholdScore { get; set; }
            
        }
    }
}
