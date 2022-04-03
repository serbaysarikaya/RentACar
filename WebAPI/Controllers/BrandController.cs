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
            return result.Success ? Ok(result) : BadRequest(result);

        }

        [HttpPut]
        public IActionResult Update(Brand brand)
        {
            var result = _brandService.Update(brand);
            return result.Success ? Ok(result) : BadRequest(result);

        }

        [HttpDelete]
        public IActionResult Delete(int brandId)
        {
            var result = _brandService.Delete(brandId);
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _brandService.GetById(id);

            return result.Success ? Ok(result) : BadRequest(result);

        }

        [HttpGet("getbyname")]
        public IActionResult GetByName(string name)
        {
            var result = _brandService.GetAllByName(name);

            return result.Success ? Ok(result) : BadRequest(result);
        }
        [HttpGet]
        public IActionResult GetAllByName(string name)
        {

            var result = _brandService.GetAllByName(name);
            return result.Success ? Ok(result) : BadRequest(result);

        }

    }
}
