using CapacityPlanApp.Models;
using CapacityPlanApp.Models.DTO.Request.CapacityPlanDetailsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapacityPlanApp.Repository.Interfaces
{
    public interface ICapacityPlanDetailsRepository
    {
        /// <summary>
        /// Gets Capacity Plan
        /// </summary>
        /// <param name="capacityPlanDetailsIdDetails"></param>
        /// <returns></returns>
        Task<CapacityPlanDetails> GetCapacityPlanDetails(CapacityPlanDetailsIdDetails capacityPlanDetailsIdDetails);

        /// <summary>
        /// Updates Capacity Plan Details
        /// </summary>
        /// <param name="capacityPlanDetails"></param>
        void UpdateCapacityPlanDetails(CapacityPlanDetails capacityPlanDetails);

        /// <summary>
        /// Creates Capacity Plan Details
        /// </summary>
        /// <param name="capacityPlanDetails"></param>
        void CreateCapacityPlanDetails(CapacityPlanDetails capacityPlanDetails);
    }
}
