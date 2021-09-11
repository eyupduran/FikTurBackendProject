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
    public class TourOrdersController : ControllerBase
    {
       private ITourOrderService _tourService;

        public TourOrdersController(ITourOrderService tourService)
        {
            _tourService = tourService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            //Dependency chain -- bağımlılık zinciri
            var result = _tourService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]  
        public IActionResult Add(TourOrder tourOrder )
        {
            var result = _tourService.Add(tourOrder);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(TourOrder tourOrder)
        {
            var result = _tourService.Delete(tourOrder);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(TourOrder tourOrder)
        {
            var result = _tourService.Update(tourOrder);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getById")]
        public IActionResult GetById(int id)
        {
            //Dependency chain -- bağımlılık zinciri
            var result = _tourService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("getAllTourOrderDetailsById")]
        public IActionResult GetAllTourOrderDetailsById(int id)
        {
            
            var result = _tourService.GetAllTourOrderDetailsById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


    }
}
