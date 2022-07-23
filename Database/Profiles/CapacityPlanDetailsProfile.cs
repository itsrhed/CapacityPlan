using AutoMapper;
using CapacityPlanApp.Models;
using CapacityPlanApp.Models.DTO.Request.CapacityPlanDetailsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapacityPlanApp.Database.Profiles
{
    public class CapacityPlanDetailsProfile : Profile
    {
        public CapacityPlanDetailsProfile()
        {
            CreateMap<CapacityPlanDetails, CapacityPlanDetailsCreate>()
            .ReverseMap();

            CreateMap<CapacityPlanDetails, CapacityPlanDetailsUpdate>()
            .ReverseMap();
        }
    }
}
