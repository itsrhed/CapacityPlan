using AutoMapper;
using CapacityPlanApp.Core.Repository;
using CapacityPlanApp.Database;
using CapacityPlanApp.Models;
using CapacityPlanApp.Models.DTO.Request.CapacityPlanDetailsDTO;
using CapacityPlanApp.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapacityPlanApp.Repository
{
    public class CapacityPlanDetailsRepository : GenericRepository<CapacityPlanDetails>, ICapacityPlanDetailsRepository
    {
        /// <summary>
        /// The mapper
        /// </summary>
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="CapacityPlanDetailsRepository" /> class.
        /// </summary>
        /// <param name="repositoryContext">The repository context.</param>
        /// <param name="mapper">The mapper.</param>
        public CapacityPlanDetailsRepository(
            DatabaseContext repositoryContext,
            IMapper mapper)
            : base(repositoryContext)
        {
            _mapper = mapper;
        }

        public async Task<CapacityPlanDetails> GetCapacityPlanDetails(CapacityPlanDetailsIdDetails capacityPlanDetailsIdDetails)
        {
            var capacityPlanDetails = FindByCondition(x => x.Id == capacityPlanDetailsIdDetails.Id).SingleOrDefault();

            return await Task.FromResult(capacityPlanDetails);
        }


        public void UpdateCapacityPlanDetails(CapacityPlanDetails capacityPlanDetails)
        {
            Update(capacityPlanDetails);
        }

        public void CreateCapacityPlanDetails(CapacityPlanDetails capacityPlanDetails)
        {
            Create(capacityPlanDetails);
        }
    }
}
