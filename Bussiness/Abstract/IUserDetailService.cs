using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
  public  interface IUserDetailService
    {
        IResult Add(UserDetail user);
        IResult Update(UserDetail user);
        IResult Delete(UserDetail user);
        IDataResult<List<UserDetail>> GetAllDetails();
    }
}
