using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Caching;
using Microsoft.Extensions.DependencyInjection;
using Core.Utilities.Interceptors;
using Core.Utilities.IoC;
using System.Linq;

namespace Core.Aspects.Autofac.Caching
{
    public class CacheAspect : MethodInterception
    {
        private readonly int _duration;
        private readonly ICacheManager _cacheManager;
        public CacheAspect(int duration = 60)
        {
            _duration = duration;
            _cacheManager = ServiceTool.ServiceProvider.GetService<ICacheManager>();
        }

        public override void Intercept(IInvocation invocation)
        {
            if (invocation.Method.ReflectedType == null) return;

            var methodName = $"{invocation.Method.ReflectedType.FullName}.{invocation.Method.Name}"; // ICarService.GetAllDetails
            var arguments = invocation.Arguments.ToList(); // null
            var key = $"{methodName}({string.Join(",", arguments.Select(x => x?.ToString() ?? "<Null>"))})"; // ICarService.GetAllDetails(<Null>)

            if (_cacheManager.IsAdd(key))
            {
                invocation.ReturnValue = _cacheManager.Get(key);
                return;
            }

            invocation.Proceed();
            _cacheManager.Add(key, invocation.ReturnValue, _duration);
        }

    }
}
