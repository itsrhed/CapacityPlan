using AutoMapper;
using CapacityPlanApp.Core.DTO.Response;
using CapacityPlanApp.Core.Models;
using CapacityPlanApp.Database;
using CapacityPlanApp.Models;
using CapacityPlanApp.Models.DTO.Request.CapacityPlanDTO;
using CapacityPlanApp.Repository.Interfaces;
using CapacityPlanApp.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CapacityPlanApp.Services
{
    public class CapacityPlanService: ICapacityPlanService
    {
        /// <summary>
        /// Gets or sets the repository context.
        /// </summary>
        /// 
        private DatabaseContext _repositoryContext { get; set; }

        /// <summary>
        /// The HTTP context accessor
        /// </summary>
        private readonly IHttpContextAccessor _httpContextAccessor;

        /// <summary>
        /// Gets or sets the mapper.
        /// </summary>
        private IMapper _mapper { get; set; }

        /// <summary>
        /// Gets or sets the Capacity Plan Repository
        /// </summary>
        private ICapacityPlanRepository _capacityPlanRepository { get; set; }

        public CapacityPlanService(
            DatabaseContext repositoryContext,
            ICapacityPlanRepository capacityPlanRepository,
            IHttpContextAccessor httpContextAccessor,
            IMapper mapper)
        {
            _capacityPlanRepository = capacityPlanRepository;
            _repositoryContext = repositoryContext;
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
        }


        public async Task<ApiResponse> GetCapacityPlan(int id)
        {
            var capacityPlan = await _capacityPlanRepository.GetCapacityPlan(new CapacityPlanIdDetails { Id = id });
            //_httpContextAccessor.HttpContext.Response.Headers.Add("X-Pagination", PagedList<Entity>.ToJson(agentAdmins));

            return new ApiResponse(capacityPlan, HttpStatusCode.OK);
        }

        public async Task<ApiResponse> GetCapacityPlans(CapacityPlanQueryParameters capacityPlanQueryParameters)
        {
            var capacityPlans = await _capacityPlanRepository.GetCapacityPlans(capacityPlanQueryParameters);           

            _httpContextAccessor.HttpContext.Response.Headers.Add("X-Pagination", PagedList<CapacityPlan>.ToJson(capacityPlans));

            return new ApiResponse(capacityPlans, HttpStatusCode.OK);
        }

        public async Task<ApiResponse> CreateCapacityPlan(CapacityPlanCreate capacityPlanCreate)
        {
            
            var capacityPlan = _mapper.Map<CapacityPlan>(capacityPlanCreate);

            _capacityPlanRepository.CreateCapacityPlan(capacityPlan);

            // update the database
            await _repositoryContext.SaveChangesAsync();

            return new ApiResponse(capacityPlanCreate, HttpStatusCode.OK);
        }

        public async Task<ApiResponse> UpdateCapacityPlan(CapacityPlanIdDetails capacityPlanIdDetails, CapacityPlanUpdate capacityPlanUpdate)
        {
            var capacityPlanRequest = await _capacityPlanRepository.GetCapacityPlan(capacityPlanIdDetails);
            if (capacityPlanRequest == null)
            {
                return new ApiResponse(HttpStatusCode.NotFound);
            }

            var capacityPlan = _mapper.Map(capacityPlanUpdate, capacityPlanRequest);

            _capacityPlanRepository.UpdateCapacityPlan(capacityPlan);


            // update the database
            await _repositoryContext.SaveChangesAsync();

            return new ApiResponse(capacityPlanUpdate, HttpStatusCode.OK);
        }

    }
}
