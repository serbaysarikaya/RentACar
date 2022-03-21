using Autofac;
using Bussiness.Abstract;
using Bussiness.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;


namespace Bussiness.DependencyResolvers.Autofac
{
    public  class AutofacBussinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //Service
            builder.RegisterType<CarManager>().As<ICarService>();
            builder.RegisterType<CarDetailManager>().As<ICarDetailService>();
            builder.RegisterType<UserDetailManager>().As<IUserDetailService>();
            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<BrandManager>().As<IBrandService>();
            builder.RegisterType<ColorManager>().As<IColorService>();

            //Dal
            builder.RegisterType<EfCarDal>().As<ICarDal>();
            builder.RegisterType<EfCarDetailDal>().As<ICarDetailDal>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();
            builder.RegisterType<EfUserDetailDal>().As<IUserDetailDal>();
            builder.RegisterType<EfBrandDal>().As<IBrandDal>();
            builder.RegisterType<EfColorDal>().As<IColorDal>();
        }

    }
}
