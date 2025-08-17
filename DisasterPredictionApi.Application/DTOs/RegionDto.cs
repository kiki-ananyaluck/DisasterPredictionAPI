using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisasterPredictionApi.Application.DTOs
{
    public class RegionDto
    {
        public class Create
        {
            public int RegionId { get; set; }
            public int DisasterTypeId { get; set; }

        }


    }
}
