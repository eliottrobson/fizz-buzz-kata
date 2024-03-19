using FizzBuzz.Interceptors.Contracts;
using FizzBuzz.Services;

namespace FizzBuzz.Tests.Tests.Services;

public class ReflectionInterceptorProviderTests
{
    private readonly ReflectionInterceptorProvider _reflectionInterceptorProvider = new();

    [DivisibleBy(1)]
    public class TestInterceptor : IInterceptor
    {
        public string Value => "TEST";
    }
    
    [Fact]
    public void InterceptorProvider_GetInterceptors_GetsInterceptors()
    {
        // Act
        var interceptors = _reflectionInterceptorProvider.GetInterceptors();

        // Assert
        var testInterceptor = Assert.Single(interceptors, i => i.Instance.GetType() == typeof(TestInterceptor));
        Assert.Equal([1], testInterceptor.DivisibleBy);
    }
}