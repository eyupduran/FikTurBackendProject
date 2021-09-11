using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlansController : ControllerBase
    {
        IPlanService _planService;

        public PlansController(IPlanService planService)
        {
            _planService = planService;
        }


        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            //Dependency chain -- bağımlılık zinciri
            var result = _planService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Plan plan)
        {
            var result = _planService.Add(plan);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Plan plan)
        {
            var result = _planService.Delete(plan);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Plan plan)
        {
            var result = _planService.Update(plan);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("getByTourOrderId")]
        public IActionResult GetAllByTourOrder(int id)
        {
            //Dependency chain -- bağımlılık zinciri
            var result = _planService.GetAllByTourOrderId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet(" getById")]
        public IActionResult GetById(int id)
        {
            //Dependency chain -- bağımlılık zinciri
            var result = _planService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet(" getAllPlanAndTourOrderDetailsByTourId")]
        public IActionResult GetAllPlanAndTourOrderDetailsByTourId(int tourId)
        {
            //Dependency chain -- bağımlılık zinciri
            var result = _planService.GetAllPlanAndTourOrderDetailsByTourId(tourId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
