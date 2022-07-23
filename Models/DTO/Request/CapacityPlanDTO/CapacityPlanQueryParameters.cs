using CapacityPlanApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapacityPlanApp.Models.DTO.Request.CapacityPlanDTO
{
    public class CapacityPlanQueryParameters: QueryParamaters
    {
        public CapacityPlanQueryParameters()
        {
            OrderBy = "Id";
        }
    }
}
