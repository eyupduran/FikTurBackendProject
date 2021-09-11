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
    public class FromCitiesController : ControllerBase
    {
        private IFromCityService _cityService;

        public FromCitiesController(IFromCityService cityService)
        {
            _cityService = cityService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            //Dependency chain -- bağımlılık zinciri
            var result = _cityService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(FromCity city )
        {
            var result = _cityService.Add(city);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(FromCity city)
        {
            var result = _cityService.Delete(city);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(FromCity city)
        {
            var result = _cityService.Update(city);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")] //içine yazdığımız sadece bir isimlendirme
        public IActionResult GetById(int id)
        {
            var result = _cityService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
