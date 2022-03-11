using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<RacContext, User>, IUserDal
    {
        public List<UserDto> GetAllDetails()
        {
            using (RacContext context = new RacContext())
            {
                var result = from u in context.Users
                             join ud in context.UserDetails on u.Id equals ud.UserId
                             select new UserDto
                             {
                                 Id = u.Id,
                                 Firstname = ud.Firstname,
                                 Lastname = ud.Lastname,
                                 BirthDate = ud.BirthDate,
                                 Email = ud.Email,
                                 Phone = ud.Phone,
                                 CreateDate = u.CreateDate,
                                 Status = u.Status
                             };

                return result.ToList(); 
            }
        }

        public UserDto GetDetails(int userId)
        {
            using RacContext context = new();

            var result = from u in context.Users
                         where u.Id == userId
                         join ud in context.UserDetails on u.Id equals ud.UserId
                         select new UserDto
                         {
                             Id = u.Id,
                             Firstname = ud.Firstname,
                             Lastname = ud.Lastname,
                             BirthDate = ud.BirthDate,
                             Email = ud.Email,
                             Phone = ud.Phone,
                             CreateDate = u.CreateDate,
                             Status = u.Status
                         };

            return result.FirstOrDefault();
        }
    }
}
