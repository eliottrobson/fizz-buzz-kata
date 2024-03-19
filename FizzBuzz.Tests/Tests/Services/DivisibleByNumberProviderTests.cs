using FizzBuzz.Services;

namespace FizzBuzz.Tests.Tests.Services;

public class DivisibleByNumberProviderTests
{
    private readonly DivisibleByNumberProvider _divisibleByNumberProvider = new();

    [Theory]
    [InlineData(1, "1")]
    [InlineData(2, "2")]
    public void NumberProvider_GetOutput_NotDivisibleByReturnsOriginalValue(int notDivisible, string expectedValue)
    {
        // Act
        var output = _divisibleByNumberProvider.GetOutput(notDivisible);

        // Assert
        Assert.Equal(expectedValue, output);
    }
    
    [Theory]
    [InlineData(3)]
    [InlineData(6)]
    public void NumberProvider_GetOutput_DivisibleBy3ReturnsInterceptedValue(int divisibleBy3)
    {
        // Act
        var output = _divisibleByNumberProvider.GetOutput(divisibleBy3);

        // Assert
        Assert.Equal("DIV_BY_3", output);
    }
    
    [Theory]
    [InlineData(15)]
    [InlineData(30)]
    public void NumberProvider_GetOutput_DivisibleByMultipleReturnsInterceptedValue(int divisibleBy3And5)
    {
        // Act
        var output = _divisibleByNumberProvider.GetOutput(divisibleBy3And5);

        // Assert
        Assert.Equal("DIV_BY_3_AND_5", output);
    }
}