using System.Reflection;
using FizzBuzz.Interceptors;
using FizzBuzz.Interceptors.Contracts;

namespace FizzBuzz.Tests.Tests.Interceptors;

public class FizzBuzzInterceptorTests
{
    private readonly FizzBuzzInterceptor _fizzBuzzInterceptor = new();

    [Fact]
    public void FizzBuzzInterceptor_Value_IsFizzBuzz()
    {
        // Assert
        Assert.Equal("FizzBuzz", _fizzBuzzInterceptor.Value);
    }
    
    [Fact]
    public void FizzInterceptor_DivisibleBy_3And5()
    {
        // Arrange
        var divisibleBy = _fizzBuzzInterceptor.GetType().GetCustomAttribute<DivisibleByAttribute>();
        
        // Assert
        Assert.NotNull(divisibleBy);
        Assert.Equal([3, 5], divisibleBy.Numbers);
    }
}