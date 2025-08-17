using DisasterPredictionApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisasterPredictionApi.Application.Interfaces
{
    public interface IRegionRepository : IRepository<Regions>
    {
    }
}
