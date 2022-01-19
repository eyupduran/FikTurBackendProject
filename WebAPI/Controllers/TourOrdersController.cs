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
            var result = _tourService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getByUserId")]
        public IActionResult GetByUserId(int userId)
        {
            var result = _tourService.GetByUserId(userId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getAllTourOrderAndAnswerByUserId")]
        public IActionResult GetAllTourOrderAndAnswerByUserId(int userId)
        {
            var result = _tourService.GetAllTourOrderAndAnswerByUserId(userId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("getOneTourOrderDetailsById")]
        public IActionResult GetOneTourOrderDetailsById(int id)
        {
            
            var result = _tourService.GetOneTourOrderDetailsById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getAllTourOrderDetails")]
        public IActionResult GetAllTourOrderDetails()
        {

            var result = _tourService.GetAllTourOrderDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
