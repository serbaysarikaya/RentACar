using Bussiness.Abstract;
using Bussiness.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
  public class UserDetailManager : IUserDetailService
    {
        private readonly IUserDetailDal _userDetailDal;

        public UserDetailManager(IUserDetailDal 
          userDetailDal)
        {
            _userDetailDal = userDetailDal;
        }

        public IResult Add(UserDetail userDeatail)
        {
            _userDetailDal.Add(userDeatail);
            return new SuccessResult(Messages.UserDetailAdded);
        }

        public IResult Update(UserDetail userDeatail)
        {
            _userDetailDal.Update(userDeatail);
            return new SuccessResult(Messages.UserDetailUpdated);
        }

        public IResult Delete(UserDetail userDeatail)
        {
            _userDetailDal.Delete(userDeatail);
            return new SuccessResult(Messages.UserDetailDeleted);
        }

        public IDataResult<List<UserDetail>> GetAllDetails()
        {
            return new SuccessDataResult<List<UserDetail>>(Messages.AllDataListed, _userDetailDal.GetAll());
        }

      
    }
}
