using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface ICarDetailService
    {

        IResult Add(CarDetail car);
        IResult Update(CarDetail car);
        IResult Delete(CarDetail car);
        IDataResult<CarDetail> GetById(int id);
        IDataResult<List<CarDetail>> GetAll();

    }
}
