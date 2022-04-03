using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTO;
using System.Collections.Generic;

namespace Bussiness.Abstract
{
    public interface ICarService
    {
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(int carId);
        IDataResult<List<Car>> GetAll();
        IDataResult<List<CarDto>> GetAllDetails();
    }
}
