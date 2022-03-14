using Bussiness.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        //CarManager _carService = new CarManager(new EfCarDal());
        
        private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _carService.GetAll();
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpGet("getdetails")]
        public IActionResult GetAllDetails()
        {
            var result = _carService.GetAllDetails();
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpPost]
        public IActionResult Add(Car car)
        {
            var result = _carService.Add(car);
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpPut]
        public IActionResult Update(Car car)
        {
            var result = _carService.Update(car);
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpDelete]
        public IActionResult Delete(Car car)
        {
            var result = _carService.Delete(car);
            return result.Success ? Ok(result) : BadRequest(result);
        }
    }
}
