using AutoMapper;
using CapacityPlanApp.Core.Repository;
using CapacityPlanApp.Database;
using CapacityPlanApp.Models;
using CapacityPlanApp.Models.DTO.Request.CapacityPlanDTO;
using CapacityPlanApp.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapacityPlanApp.Repository
{
    public class CapacityPlanRepository : GenericRepository<CapacityPlan>, ICapacityPlanRepository
    {

        /// <summary>
        /// The mapper
        /// </summary>
        private readonly IMapper _mapper;
        protected DatabaseContext _repositoryContext { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CapacityPlanRepository" /> class.
        /// </summary>
        /// <param name="repositoryContext">The repository context.</param>
        /// <param name="mapper">The mapper.</param>
        public CapacityPlanRepository(
            DatabaseContext repositoryContext,
            IMapper mapper)
            : base(repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _mapper = mapper;
        }

        public async Task<CapacityPlan> GetCapacityPlan(CapacityPlanIdDetails capacityPlanIdDetails)
        {
            var capacityPlan = _repositoryContext.Set<CapacityPlan>()
                .Where(x => x.Id == capacityPlanIdDetails.Id).Include(x => x.CapacityPlanDetails).SingleOrDefault();

            return await Task.FromResult(capacityPlan);
        }


        public void UpdateCapacityPlan(CapacityPlan capacityPlan)
        {
            Update(capacityPlan);
        }

        public void CreateCapacityPlan(CapacityPlan capacityPlan)
        {
            Create(capacityPlan);
        }
    }
}
