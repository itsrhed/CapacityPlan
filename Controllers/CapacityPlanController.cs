using CapacityPlanApp.Models.DTO.Request;
using CapacityPlanApp.Models.DTO.Request.CapacityPlanDTO;
using CapacityPlanApp.Models.DTO.Request.CapacityPlanDetailsDTO;
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

        private readonly ICapacityPlanDetailsService _capacityPlanDetailsService;

        public CapacityPlanController(ICapacityPlanService capacityPlanService, ICapacityPlanDetailsService capacityPlanDetailsService)
        {
            _capacityPlanService = capacityPlanService;
            _capacityPlanDetailsService = capacityPlanDetailsService;
        }

        // GET: api/<ValuesController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

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

        // PUT api/<ValuesController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

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
