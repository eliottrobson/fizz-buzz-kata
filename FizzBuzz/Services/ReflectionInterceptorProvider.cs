using FizzBuzz.Services.Contracts;

namespace FizzBuzz.Services;

public class ReflectionInterceptorProvider : IInterceptorProvider
{
    public IReadOnlyList<DivisibleByInterceptor> GetInterceptors()
    {
        // TODO: get interceptors via reflection
        return [];
    }
}