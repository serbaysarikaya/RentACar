using Bussiness.Abstract;
using Bussiness.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;
        private readonly IUserDetailService _userDetailService;


        public UserManager(IUserDal userDal, IUserDetailService userDetailService)
        {
            _userDal = userDal;
            _userDetailService = userDetailService;
        }

        public IResult Add(User user)
        {
            _userDal.Add(user);
            var result = AddUserDetail(user.Id);

            if (!result.Success)
            {
                return new ErrorResult();
            }


            return new SuccessResult(Messages.UserAdded);
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult(Messages.UserUpdated);
        }

        public IResult Delete(int userId)
        {
            User user = _userDal.Get(u => u.Id == userId);
            _userDal.Delete(user);
            return new SuccessResult(Messages.UserDeleted);
        }

        public IDataResult<List<UserDto>> GetAllDetails() => new SuccessDataResult<List<UserDto>>(Messages.AllDataListed, _userDal.GetAllDetails());


        public IDataResult<UserDto> GetById(int id)
        {
            return new SuccessDataResult<UserDto>(Messages.AllDataListed, _userDal.GetDetails(id));
        }
        private IResult AddUserDetail(int userId)
        {
            UserDetail userDetail = new()
            {
                UserId = userId
            };
            _userDetailService.Add(userDetail);
            return new SuccessResult();

        }
    }
}
