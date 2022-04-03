using Bussiness.Abstract;
using Bussiness.Constants;
using Core.Aspects.Autofac.Caching;
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

        [CacheRemoveAspect("IUserDetailService.Get")]
        public IResult Add(UserDetail userDetail)
        {
            _userDetailDal.Add(userDetail);
            return new SuccessResult(Messages.UserDetailAdded);
        }

        [CacheRemoveAspect("IUserDetailService.Get")]
        public IResult Update(UserDetail userDetail)
        {
            _userDetailDal.Update(userDetail);
            return new SuccessResult(Messages.UserDetailUpdated);
        }

        [CacheRemoveAspect("IUserDetailService.Get")]
        public IResult Delete(int userDetailId)
        {
            UserDetail userDetail = _userDetailDal.Get(ud => ud.Id == userDetailId);
            _userDetailDal.Delete(userDetail);
            return new SuccessResult(Messages.UserDetailDeleted);
        }

        [CacheAspect]
        public IDataResult<List<UserDetail>> GetAllDetails()
        {
            return new SuccessDataResult<List<UserDetail>>(Messages.AllDataListed, _userDetailDal.GetAll());
        }

      
    }
}
