using CapacityPlanApp.Core.Models;
using CapacityPlanApp.Models;
using CapacityPlanApp.Models.DTO.Request.CapacityPlanDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapacityPlanApp.Repository.Interfaces
{
    public interface ICapacityPlanRepository
    {
        /// <summary>
        /// Gets Capacity Plan
        /// </summary>
        /// <param name="capacityPlanIdDetails"></param>
        /// <returns></returns>
        Task<CapacityPlan> GetCapacityPlan(CapacityPlanIdDetails capacityPlanIdDetails);

        /// <summary>
        /// Gets Paged Capacity Plan
        /// </summary>
        /// <param name="capacityPlanQueryParameters"></param>
        /// <returns></returns>
        Task<PagedList<CapacityPlan>> GetCapacityPlans(CapacityPlanQueryParameters capacityPlanQueryParameters);

        /// <summary>
        /// Updates Capacity Plan
        /// </summary>
        /// <param name="capacityPlan"></param>
        void UpdateCapacityPlan(CapacityPlan capacityPlan);
        
        /// <summary>
        /// Creates Capacity Plan
        /// </summary>
        /// <param name="capacityPlan"></param>
        void CreateCapacityPlan(CapacityPlan capacityPlan);
    }
}
