using Bussiness.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserDetailController : ControllerBase
    {
        private readonly IUserDetailService _userDetailService;

        public UserDetailController(IUserDetailService userDetailService)
        {
            _userDetailService = userDetailService;
        }

        [HttpPost]
        public IActionResult Add(UserDetail userDetail)
        {
            var result = _userDetailService.Add(userDetail);

            return Ok(result);

        }

        [HttpPut]
        public IActionResult Update(UserDetail userDetail) 
        {
            var result = _userDetailService.Update(userDetail);
            return Ok(result);
        }
        [HttpDelete]
        public IActionResult Delete(UserDetail userDetail)
        {
            var result = _userDetailService.Delete(userDetail);

            return Ok(result);
        }
        [HttpGet]

        public IActionResult GetAllDetails() 
       {

            var result = _userDetailService.GetAllDetails();
            return Ok(result);
        }


    }
}
