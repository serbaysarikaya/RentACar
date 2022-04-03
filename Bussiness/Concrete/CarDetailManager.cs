using Bussiness.Abstract;
using Bussiness.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Bussiness.Concrete
{
    public class CarDetailManager : ICarDetailService
    {
        private readonly ICarDetailDal _carDetailDal;
        public CarDetailManager(ICarDetailDal carDetailDal)
        {
            _carDetailDal = carDetailDal;
        }


        public IResult Add(CarDetail carDetail)
        {

            _carDetailDal.Add(carDetail);
            return new SuccessResult(Messages.CarDetailAdded);
        }

        public IResult Update(CarDetail carDetail)
        {
            _carDetailDal.Update(carDetail);
            return new SuccessResult(Messages.CarDetailUpdated);
        }

        public IResult Delete(int carDetailId)
        {
            CarDetail carDetail = _carDetailDal.Get(cd => cd.Id == carDetailId);
            _carDetailDal.Delete(carDetail);

            return new SuccessResult(Messages.CarDetailDeleted);
        }

        public IDataResult<List<CarDetail>> GetAll()
        {
            return new SuccessDataResult<List<CarDetail>>(Messages.AllDataListed, _carDetailDal.GetAll());
        }

        public IDataResult<CarDetail> GetById(int id)
        {
            return new SuccessDataResult<CarDetail>(Messages.AllDataListed, _carDetailDal.Get(x => x.Id == id));
        }
    }
}
