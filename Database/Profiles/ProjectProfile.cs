using AutoMapper;
using CapacityPlanApp.Models;
using CapacityPlanApp.Models.DTO.Request.ProjectDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapacityPlanApp.Database.Profiles
{
    public class ProjectProfile : Profile
    {
        public ProjectProfile()
        {
            CreateMap<Project, ProjectCreate>()
            .ReverseMap();

            CreateMap<Project, ProjectUpdate>()
            .ReverseMap();
        }
    }

}
