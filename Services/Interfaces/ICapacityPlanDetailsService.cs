using CapacityPlanApp.Core.DTO.Response;
using CapacityPlanApp.Models.DTO.Request.CapacityPlanDetailsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapacityPlanApp.Services.Interfaces
{
    public interface ICapacityPlanDetailsService
    {
        Task<ApiResponse> GetCapacityPlanDetails(int id);

        Task<ApiResponse> CreateCapacityPlanDetails(CapacityPlanDetailsCreate capacityPlanDetailsCreate);

        Task<ApiResponse> UpdateCapacityPlanDetails(CapacityPlanDetailsIdDetails capacityPlanDetailsIdDetails, CapacityPlanDetailsUpdate capacityPlanDetailsUpdate);
    }
}
