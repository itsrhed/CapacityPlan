using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CapacityPlanApp.Models;
using CapacityPlanApp.Models.DTO.Request.CapacityPlanDetailsDTO;

namespace CapacityPlanApp.Models.DTO.Request.CapacityPlanDTO
{
    public class CapacityPlanCreate
    {
        public string CapView { get; set; }
        public string WeekStart { get; set; }
        public string Status { get; set; }

        public CapacityPlanDetailsCreate CapacityPlanDetails { get; set; }

        public bool IsDeleted { get; set; }

        public CapacityPlanCreate()
        {
            IsDeleted = false;
        }
    }
}
