using FizzBuzz.Interceptors;
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
    
    [Fact]
    public void InterceptorProvider_GetInterceptors_GetsOrderedFizzInterceptors()
    {
        // Act
        var interceptors = _reflectionInterceptorProvider.GetInterceptors().ToList();

        // Assert
        var fizzBuzzInterceptor = Assert.Single(interceptors, i => i.Instance is FizzBuzzInterceptor);
        var fizzInterceptor = Assert.Single(interceptors, i => i.Instance is FizzInterceptor);
        var fizzBuzzIndex = interceptors.IndexOf(fizzBuzzInterceptor);
        var fizzIndex = interceptors.IndexOf(fizzInterceptor);
        Assert.True(fizzBuzzIndex < fizzIndex);
    }
    
    [Fact]
    public void InterceptorProvider_GetInterceptors_GetsOrderedBuzzInterceptors()
    {
        // Act
        var interceptors = _reflectionInterceptorProvider.GetInterceptors().ToList();

        // Assert
        var fizzBuzzInterceptor = Assert.Single(interceptors, i => i.Instance is FizzBuzzInterceptor);
        var buzzInterceptor = Assert.Single(interceptors, i => i.Instance is BuzzInterceptor);
        var fizzBuzzIndex = interceptors.IndexOf(fizzBuzzInterceptor);
        var buzzIndex = interceptors.IndexOf(buzzInterceptor);
        Assert.True(fizzBuzzIndex < buzzIndex);
    }
}