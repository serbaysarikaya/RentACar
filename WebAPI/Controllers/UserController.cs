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
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public IActionResult Add(User user)
        {

            var result = _userService.Add(user);

            return Ok(result);


        }
        [HttpPut]
        public IActionResult Update(User user)
        {
            var result = _userService.Update(user);

            return Ok(user);

        }

        [HttpDelete]
        public IActionResult Delete(User user)
        {
            var result = _userService.Delete(user);
            return Ok(result);

        }
        [HttpGet("GetAllDetails")]
        public IActionResult GetAllDetails()
        {
            var result = _userService.GetAllDetails();
            return Ok(result);

        }
        [HttpGet]
        public IActionResult GetById(int id)
        {
            var result = _userService.GetById(id);

            return Ok(id);
        }

    }
}
