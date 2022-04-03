using Bussiness.Abstract;
using Bussiness.Constants;
using Core.Aspects.Autofac.Caching;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Bussiness.Concrete
{
    public class BrandManager : IBrandService
    {
        private readonly IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        [CacheRemoveAspect("IBrandService.Get")]
        public IResult Add(Brand brand)
        {
            _brandDal.Add(brand);
            return new SuccessResult(Messages.BrandAdded);
        }

        [CacheRemoveAspect("IBrandService.Get")]
        public IResult Update(Brand brand)
        {
            _brandDal.Update(brand);
            return new SuccessResult(Messages.BrandUpdated);
            
        }

        [CacheRemoveAspect("IBrandService.Get")]
        public IResult Delete(int brandId)
        {
            Brand brand = _brandDal.Get(b => b.Id == brandId);
            _brandDal.Delete(brand);
            return new SuccessResult(Messages.BrandDeleted);
        }

        public IDataResult<Brand> GetById(int brandId)
        {
            return new SuccessDataResult<Brand>(Messages.AllDataListed, _brandDal.Get(b => b.Id == brandId));
        }

        public IDataResult<Brand> GetByName(string brandName)
            => new SuccessDataResult<Brand>(Messages.AllDataListed, _brandDal.Get(b => b.Name == brandName));

        [CacheAspect]
        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(Messages.AllDataListed, _brandDal.GetAll());
        }

        [CacheAspect]
        public IDataResult<List<Brand>> GetAllByName(string name) => new SuccessDataResult<List<Brand>>(Messages.AllDataListed, _brandDal.GetAll(b => b.Name == name));
    }
}
