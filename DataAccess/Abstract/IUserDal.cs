using Core.DataAccess.EntityFramework;
using Entities.Concrete;
using Entities.DTO;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        UserDto GetDetails(int userId);
        List<UserDto> GetAllDetails();
    }
}
