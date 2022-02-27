using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<RacContext, Car>, ICarDal
    {
        public List<CarDto> GetAllDetails()
        {
            // using RacContext context = new RacContext();
            using RacContext context = new();

            var result = from c in context.Cars
                         join cd in context.CarDetails on c.CarDetailId equals cd.Id
                         join b in context.Brands on c.BrandId equals b.Id
                         join clr in context.Colors on cd.ColorId equals clr.Id
                         select new CarDto
                         {
                             Id = c.Id,
                             Brand = b.Name,
                             Model = c.Model,
                             Color = clr.Name,
                             Kilometer = cd.Kilometer,
                             ModelYear = cd.ModelYear,
                             Damaged = cd.Damaged
                         };

            return result.OrderBy(b => b.Brand).ToList();
        }
    }
}
