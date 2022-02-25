using Core.DataAccess.EntityFramework;
using Entities.Concrete;
using Entities.DTO;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
    }
}
