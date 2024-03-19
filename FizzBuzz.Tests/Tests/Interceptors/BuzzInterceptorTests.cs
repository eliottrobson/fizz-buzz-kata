using System.Reflection;
using FizzBuzz.Interceptors;
using FizzBuzz.Interceptors.Contracts;

namespace FizzBuzz.Tests.Tests.Interceptors;

public class BuzzInterceptorTests
{
    private readonly BuzzInterceptor _buzzInterceptor = new();

    [Fact]
    public void BuzzInterceptor_Value_IsBuzz()
    {
        // Assert
        Assert.Equal("Buzz", _buzzInterceptor.Value);
    }
    
    [Fact]
    public void BuzzInterceptor_DivisibleBy_5()
    {
        // Arrange
        var divisibleBy = _buzzInterceptor.GetType().GetCustomAttribute<DivisibleByAttribute>();
        
        // Assert
        Assert.NotNull(divisibleBy);
        Assert.Equal([5], divisibleBy.Numbers);
    }
}