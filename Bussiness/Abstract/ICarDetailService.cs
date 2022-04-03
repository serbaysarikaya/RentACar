using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Bussiness.Abstract
{
    public interface ICarDetailService
    {

        IResult Add(CarDetail carDetail);
        IResult Update(CarDetail carDetail);
        IResult Delete(int carDetailId);
        IDataResult<CarDetail> GetById(int id);
        IDataResult<List<CarDetail>> GetAll();

    }
}
