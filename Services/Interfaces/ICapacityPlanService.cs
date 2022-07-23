using CapacityPlanApp.Core.DTO.Response;
using CapacityPlanApp.Models.DTO.Request.CapacityPlanDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapacityPlanApp.Services.Interfaces
{
    public interface ICapacityPlanService
    {
        Task<ApiResponse> GetCapacityPlan(int id);

        Task<ApiResponse> CreateCapacityPlan(CapacityPlanCreate capacityPlanCreate);

        Task<ApiResponse> UpdateCapacityPlan(CapacityPlanIdDetails capacityPlanIdDetails, CapacityPlanUpdate capacityPlanUpdate);
    }
}
