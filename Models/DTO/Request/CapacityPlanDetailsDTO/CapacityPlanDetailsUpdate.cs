﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapacityPlanApp.Models.DTO.Request.CapacityPlanDetailsDTO
{
    public class CapacityPlanDetailsUpdate
    {
        public string Name { get; set; }
        public string DateFrom { get; set; }
        public string DateTo { get; set; }
        public bool IsDeleted { get; set; }
    }
}
