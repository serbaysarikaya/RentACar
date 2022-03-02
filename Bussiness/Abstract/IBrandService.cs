

using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Bussiness.Abstract
{
    public interface IBrandService
    {
        IResult Add(Brand brand);
        IResult Update(Brand brand);
        IResult Delete(Brand brand);
        IDataResult<Brand> GetById(int brandId);
        IDataResult<Brand> GetByName(string brandName);
        IDataResult<List<Brand>> GetAll();
        IDataResult<List<Brand>> GetAllByName(string name);
    }
}
