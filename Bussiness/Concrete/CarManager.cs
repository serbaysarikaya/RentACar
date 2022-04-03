using Bussiness.Abstract;
using Bussiness.Constants;
using Core.Aspects.Autofac.Caching;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO;
using System.Collections.Generic;

namespace Bussiness.Concrete
{
    public class CarManager : ICarService
    {
        private readonly ICarDal _carDal;
        private readonly ICarDetailService _carDetailService;

        public CarManager(ICarDal carDal, ICarDetailService carDetailService)
        {
            _carDal = carDal;
            _carDetailService = carDetailService;
        }

        #region Public Method

        [CacheRemoveAspect("ICarService.Get")]
        public IResult Add(Car car)
        {
            _carDal.Add(car);

            var result = AddCarDetail(car.Id);

            if(!result.Success)
            {
                return new ErrorResult();
            }

            return new SuccessResult(Messages.CarAdded);
        }

        [CacheRemoveAspect("ICarService.Get")]
        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }

        public IResult Delete(Car car)
        {
            Car car = _carDal.Get(c => c.Id == carId);
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);

        }

        [CacheAspect]
        public IDataResult<List<CarDto>> GetAllDetails() => new SuccessDataResult<List<CarDto>>(Messages.AllDataListed, _carDal.GetAllDetails());

        [CacheAspect]
        public IDataResult<List<Car>> GetAll() => new SuccessDataResult<List<Car>>(Messages.AllDataListed, _carDal.GetAll());

        #endregion

        #region Private Methods

        private IResult AddCarDetail(int carId)
        {
            CarDetail carDetail = new()
            {
                CarId = carId
            };

            _carDetailService.Add(carDetail);
            return new SuccessResult();
        }

        #endregion
    }
}
