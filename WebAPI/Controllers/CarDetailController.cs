﻿using Bussiness.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarDetailController : ControllerBase
    {
        private readonly ICarDetailService _carDetailService;

        public CarDetailController(ICarDetailService carDetailService)
        {
            _carDetailService = carDetailService;
        }

         [HttpPost]
        public IActionResult Add(CarDetail carDetail)
        {
            var result = _carDetailService.Add(carDetail);
            return Ok(result);
        }

        [HttpPut]
        public IActionResult Update(CarDetail carDetail)
        {
            var result = _carDetailService.Update(carDetail);
            return Ok(result);
        }

        [HttpDelete]
        public IActionResult Delete(CarDetail carDetail)
        {
            var result = _carDetailService.Delete(carDetail);

            return Ok(result);
        }
        
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _carDetailService.GetById(id);
            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _carDetailService.GetAll();
            return Ok(result);
        }


    }
}