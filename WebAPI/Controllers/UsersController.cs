using Bussiness.Abstract;
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
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public IActionResult Add(User user)
        {

            var result = _userService.Add(user);

            return result.Success ? Ok(result) : BadRequest(result);


        }
        [HttpPut]
        public IActionResult Update(User user)
        {
            var result = _userService.Update(user);

            return result.Success ? Ok(result) : BadRequest(result);

        }

        [HttpDelete]
        public IActionResult Delete(int userId)
        {
            var result = _userService.Delete(userId);
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpGet]
        public IActionResult GetAllDetails()
        {
            var result = _userService.GetAllDetails();
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _userService.GetById(id);

            return result.Success ? Ok(result) : BadRequest(result);
        }

    }
}
