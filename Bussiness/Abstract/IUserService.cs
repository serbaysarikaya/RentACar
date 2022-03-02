using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
   public interface IUserService
    {

        IResult Add(User user);
        IResult Update(User user);
        IResult Delte(User user);
        IDataResult<List<UserDto>> GetAllDetails();
    }
}
