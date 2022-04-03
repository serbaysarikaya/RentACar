using Bussiness.Abstract;
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
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpPut]
        public IActionResult Update(CarDetail carDetail)
        {
            var result = _carDetailService.Update(carDetail);
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpDelete]
        public IActionResult Delete(int carDetailId)
        {
            var result = _carDetailService.Delete(carDetailId);

            return result.Success ? Ok(result) : BadRequest(result);
        }
        
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _carDetailService.GetById(id);
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _carDetailService.GetAll();
            return result.Success ? Ok(result) : BadRequest(result);
        }


    }
}
