using Bussiness.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly IBrandService _brandService;
        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpPost]
        public IActionResult Add(Brand brand)
        {
            var result = _brandService.Add(brand);
            return Ok(result);

        }

        [HttpPut]
        public IActionResult Update(Brand brand)
        {
            var result = _brandService.Update(brand);
            return Ok(result);

        }

        [HttpDelete]
        public IActionResult Delete(Brand brand)
        {
            var result = _brandService.Delete(brand);
            return Ok(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _brandService.GetById(id);

            return Ok(result);

        }

        [HttpGet("getbyname")]
        public IActionResult GetByName(string name)
        {
            var result = _brandService.GetAllByName(name);

            return Ok(result);
        }
        [HttpGet]
        public IActionResult GetAllByName(string name)
        {

            var result = _brandService.GetAllByName(name);
            return Ok(result);

        }

    }
}
