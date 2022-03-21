using Bussiness.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserDetailsController : ControllerBase
    {
        private readonly IUserDetailService _userDetailService;

        public UserDetailsController(IUserDetailService userDetailService)
        {
            _userDetailService = userDetailService;
        }

        [HttpPost]
        public IActionResult Add(UserDetail userDetail)
        {
            var result = _userDetailService.Add(userDetail);

            return result.Success ? Ok(result) : BadRequest(result);;

        }

        [HttpPut]
        public IActionResult Update(UserDetail userDetail) 
        {
            var result = _userDetailService.Update(userDetail);
            return result.Success ? Ok(result) : BadRequest(result);;
        }
        [HttpDelete]
        public IActionResult Delete(UserDetail userDetail)
        {
            var result = _userDetailService.Delete(userDetail);

            return result.Success ? Ok(result) : BadRequest(result);;
        }
        [HttpGet]

        public IActionResult GetAllDetails() 
       {

            var result = _userDetailService.GetAllDetails();
            return result.Success ? Ok(result) : BadRequest(result);;
        }


    }
}
