using CapacityPlanApp.Models.DTO.Request.CapacityPlanDetailsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapacityPlanApp.Models.DTO.Request.CapacityPlanDTO
{
    public class CapacityPlanUpdate
    {
        public string CapView { get; set; }
        public string WeekStart { get; set; }
        public string Status { get; set; }

        public CapacityPlanDetailsUpdate CapacityPlanDetails { get; set; }

        public bool IsDeleted { get; set; }
    }
}
