using AutoMapper;
using CapacityPlanApp.Models;
using CapacityPlanApp.Models.DTO.Request.CapacityPlanDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapacityPlanApp.Database.Profiles
{
    public class CapacityPlanProfile: Profile
    {
        public CapacityPlanProfile()
        {
            CreateMap<CapacityPlan, CapacityPlanCreate>()
            .ReverseMap();

            CreateMap<CapacityPlan, CapacityPlanUpdate>()
            .ReverseMap();
        }

    }
}
