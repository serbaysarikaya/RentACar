using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
  public  interface IColorService
    {
        IResult Add(Color color);
        IResult Update(Color color);
        IResult Delete(int colorId);
        IDataResult<Color> GetById(int colorId);
        IDataResult<Color> GetByName(string colorName);
        IDataResult<List<Color>> GetAll();
        IDataResult<List<Color>> GetAllByName(string name);


    }
}
