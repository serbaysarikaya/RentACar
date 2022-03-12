using Bussiness.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;


namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorController : ControllerBase
    {

        private readonly IColorService _colorService;

        public ColorController(IColorService colorService)
        {
            _colorService = colorService;
        }

        [HttpPost]
        public IActionResult Add(Color color)
        {
            var result = _colorService.Add(color);
            return Ok(result);
        }

        [HttpPut]
        public IActionResult Update(Color color)
        {
            var result = _colorService.Update(color);
            return Ok(result);

        }

        [HttpDelete]
        public IActionResult Delete(Color color)
        {
            var result = _colorService.Delte(color);
            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _colorService.GetAll();

            return Ok(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id) 
        {
            var resul = _colorService.GetById( id);
            return Ok(resul);
        }
        [HttpGet("getbyname")]
        public IActionResult GetByName(string name)
        {
            var resul = _colorService.GetByName(name);
            return Ok(resul);
        }

        [HttpGet("getallbyname")]
        public IActionResult GetAllByName(string name)
        {
            var resul = _colorService.GetAllByName(name);
            return Ok(resul);
        }

    }
}
