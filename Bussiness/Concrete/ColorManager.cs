using Bussiness.Abstract;
using Bussiness.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class ColorManager : IColorService
    {
        private readonly IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult Add(Color color)
        {
            _colorDal.Add(color);
            return new SuccessResult(Messages.ColorAdded);
        }

        public IResult Update(Color color)
        {
            _colorDal.Update(color);
            return new SuccessResult(Messages.ColorUpdated);
        }

        public IResult Delete(int colorId)
        {
            Color color = _colorDal.Get(c => c.Id == colorId);
            _colorDal.Delete(color);
            return new SuccessResult(Messages.ColorDeleted);
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(Messages.AllDataListed, _colorDal.GetAll());
        }

        public IDataResult<Color> GetById(int colorId)
        {
            return new SuccessDataResult<Color>(Messages.AllDataListed, _colorDal.Get(c => c.Id == colorId));
        }

        public IDataResult<Color> GetByName(string colorName)
        {
            return new SuccessDataResult<Color>(Messages.AllDataListed, _colorDal.Get(c => c.Name == colorName));
        }

        public IDataResult<List<Color>> GetAllByName(string name) => new SuccessDataResult<List<Color>>(Messages.AllDataListed, _colorDal.GetAll(b => b.Name == name));

    }
}
