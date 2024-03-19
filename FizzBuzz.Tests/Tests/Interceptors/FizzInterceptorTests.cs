using System.Reflection;
using FizzBuzz.Interceptors;
using FizzBuzz.Interceptors.Contracts;

namespace FizzBuzz.Tests.Tests.Interceptors;

public class FizzInterceptorTests
{
    private readonly FizzInterceptor _fizzInterceptor = new();

    [Fact]
    public void FizzInterceptor_Value_IsFizz()
    {
        // Assert
        Assert.Equal("Fizz", _fizzInterceptor.Value);
    }
    
    [Fact]
    public void FizzInterceptor_DivisibleBy_3()
    {
        // Arrange
        var divisibleBy = _fizzInterceptor.GetType().GetCustomAttribute<DivisibleByAttribute>();
        
        // Assert
        Assert.NotNull(divisibleBy);
        Assert.Equal([3], divisibleBy.Numbers);
    }
}