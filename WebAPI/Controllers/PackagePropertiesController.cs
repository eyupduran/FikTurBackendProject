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
    public class PackagePropertiesController : ControllerBase
    {
        private IPackagePropertyService _propertyService;

        public PackagePropertiesController(IPackagePropertyService propertyService)
        {
            _propertyService = propertyService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _propertyService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(PackageProperty packageProperty)
        {
            var result = _propertyService.Add(packageProperty);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(PackageProperty packageProperty)
        {
            var result = _propertyService.Delete(packageProperty);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(PackageProperty packageProperty)
        {
            var result = _propertyService.Update(packageProperty);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getById")]
        public IActionResult GetById(int id)
        {
            var result = _propertyService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getOnePackagePropertyDetailsById")]
        public IActionResult GetAllPackagePropertyDetailsById(int id)
        {
            var result = _propertyService.GetOnePackagePropertyDetailsById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
