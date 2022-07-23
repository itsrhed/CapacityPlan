using CapacityPlanApp.Models.DTO.Request;
using CapacityPlanApp.Models.DTO.Request.CapacityPlanDTO;
using CapacityPlanApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CapacityPlanApp.Controllers
{
    [Produces("application/json")]
    [Consumes("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class CapacityPlanController : ControllerBase
    {
        private readonly ICapacityPlanService _capacityPlanService;


        public CapacityPlanController(ICapacityPlanService capacityPlanService)
        {
            _capacityPlanService = capacityPlanService;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetCapacityPlans([FromQuery] CapacityPlanQueryParameters capacityPlanQueryParameters)
        {
            var result = await _capacityPlanService.GetCapacityPlans(capacityPlanQueryParameters);
            return StatusCode((int)result.Code, result.Value);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCapacityPlan(int id)
        {
            var result = await _capacityPlanService.GetCapacityPlan(id);
            return StatusCode((int)result.Code, result.Value);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public async Task<IActionResult> CreateCapacityPlan([FromBody] CapacityPlanCreate capacityPlanCreate)
        {
            var result = await _capacityPlanService.CreateCapacityPlan(capacityPlanCreate);
            return StatusCode((int)result.Code, result.Value);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCapacityPlan(int id, [FromBody] CapacityPlanUpdate capacityPlanUpdate)
        {
            var result = await _capacityPlanService.UpdateCapacityPlan(new CapacityPlanIdDetails { Id = id }, capacityPlanUpdate);
            return StatusCode((int)result.Code, result.Value);
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
