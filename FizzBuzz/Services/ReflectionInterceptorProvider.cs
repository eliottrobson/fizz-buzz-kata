using System.Reflection;
using FizzBuzz.Interceptors.Contracts;
using FizzBuzz.Services.Contracts;

namespace FizzBuzz.Services;

public class ReflectionInterceptorProvider : IInterceptorProvider
{
    public IReadOnlyList<DivisibleByInterceptor> GetInterceptors()
    {
        var interceptorType = typeof(IInterceptor);
        var divisibleByAttributeType = typeof(DivisibleByAttribute);
        var interceptors = AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(a => a.GetTypes())
            // Classes implementing IInterceptor and DivisibleBy attribute
            .Where(t =>
                t is { IsClass: true, IsAbstract: false } &&
                t.GetInterfaces().Any(i => i == interceptorType) &&
                t.IsDefined(divisibleByAttributeType, false)
            )
            // Project out divisible by attribute details
            .Select(t => 
            {
                var attributeData = t.GetCustomAttribute<DivisibleByAttribute>()!;
                return new
                {
                    Instance = (IInterceptor)Activator.CreateInstance(t)!,
                    attributeData.Numbers,
                    Priority = attributeData.Order
                };
            });
        
        return interceptors
            .OrderBy(v => v.Priority)
            .Select(x => new DivisibleByInterceptor(x.Instance, x.Numbers))
            .ToList();
    }
}