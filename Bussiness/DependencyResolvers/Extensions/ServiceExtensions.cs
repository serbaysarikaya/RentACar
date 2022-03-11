using Bussiness.Abstract;
using Bussiness.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.Extensions.DependencyInjection;

namespace Bussiness.DependencyResolvers.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddMyDependencies(this IServiceCollection services)
        {
            services.AddSingleton<ICarService, CarManager>();
            services.AddSingleton<ICarDetailService, CarDetailManager>();
            services.AddSingleton<IUserDetailService, UserDetailManager>();
            services.AddSingleton<IUserService, UserManager>();
            services.AddSingleton<IBrandService, BrandManager>();
            services.AddSingleton<IColorService, ColorManager>();


            services.AddSingleton<ICarDal, EfCarDal>();
            services.AddSingleton<ICarDetailDal, EfCarDetailDal>();
            services.AddSingleton<IUserDal, EfUserDal>();
            services.AddSingleton<IUserDetailDal, EfUserDetailDal>();
            services.AddSingleton<IBrandDal, EfBrandDal>();
            services.AddSingleton<IColorDal, EfColorDal>();

            return services;
        }
    }
}
