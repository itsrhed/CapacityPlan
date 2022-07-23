using AutoMapper;
using CapacityPlanApp.Core.DTO.Response;
using CapacityPlanApp.Database;
using CapacityPlanApp.Models;
using CapacityPlanApp.Models.DTO.Request.CapacityPlanDetailsDTO;
using CapacityPlanApp.Repository.Interfaces;
using CapacityPlanApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CapacityPlanApp.Services
{
    public class CapacityPlanDetailsService : ICapacityPlanDetailsService
    {
        /// <summary>
        /// Gets or sets the repository context.
        /// </summary>
        /// 
        private DatabaseContext _repositoryContext { get; set; }

        /// <summary>
        /// Gets or sets the mapper.
        /// </summary>
        private IMapper _mapper { get; set; }

        /// <summary>
        /// Gets or sets the Capacity Plan Repository
        /// </summary>
        private ICapacityPlanDetailsRepository _capacityPlanDetailsRepository { get; set; }

        public CapacityPlanDetailsService(
            DatabaseContext repositoryContext,
            ICapacityPlanDetailsRepository capacityPlanDetailsRepository,
            IMapper mapper)
        {
            _capacityPlanDetailsRepository = capacityPlanDetailsRepository;
            _repositoryContext = repositoryContext;
            _mapper = mapper;
        }


        public async Task<ApiResponse> GetCapacityPlanDetails(int id)
        {
            var capacityPlanDetails = await _capacityPlanDetailsRepository.GetCapacityPlanDetails(new CapacityPlanDetailsIdDetails { Id = id });
            //_httpContextAccessor.HttpContext.Response.Headers.Add("X-Pagination", PagedList<Entity>.ToJson(agentAdmins));

            return new ApiResponse(capacityPlanDetails, HttpStatusCode.OK);
        }

        public async Task<ApiResponse> CreateCapacityPlanDetails(CapacityPlanDetailsCreate capacityPlanDetailsCreate)
        {

            var capacityPlanDetails = _mapper.Map<CapacityPlanDetails>(capacityPlanDetailsCreate);
            _capacityPlanDetailsRepository.CreateCapacityPlanDetails(capacityPlanDetails);

            // update the database
            await _repositoryContext.SaveChangesAsync();

            return new ApiResponse(capacityPlanDetailsCreate, HttpStatusCode.OK);
        }

        public async Task<ApiResponse> UpdateCapacityPlanDetails(CapacityPlanDetailsIdDetails capacityPlanDetailsIdDetails, CapacityPlanDetailsUpdate capacityPlanDetailsUpdate)
        {
            var capacityPlanDetailsRequest = await _capacityPlanDetailsRepository.GetCapacityPlanDetails(capacityPlanDetailsIdDetails);
            if (capacityPlanDetailsRequest == null)
            {
                return new ApiResponse(HttpStatusCode.NotFound);
            }

            var capacityPlanDetails = _mapper.Map(capacityPlanDetailsUpdate, capacityPlanDetailsRequest);
            _capacityPlanDetailsRepository.UpdateCapacityPlanDetails(capacityPlanDetails);

            // update the database
            await _repositoryContext.SaveChangesAsync();

            return new ApiResponse(capacityPlanDetailsUpdate, HttpStatusCode.OK);
        }

    }
}
