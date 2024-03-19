using FizzBuzz.Services.Contracts;

namespace FizzBuzz.Tests.Tests;

public class RuntimeTests
{
    private readonly IRangeProvider _rangeProvider;
    private readonly INumberProvider _numberProvider;
    private readonly IOutputProvider _outputProvider;
    private readonly Runtime _runtime;
    
    public RuntimeTests()
    {
        _rangeProvider = Substitute.For<IRangeProvider>();
        _numberProvider = Substitute.For<INumberProvider>();
        _outputProvider = Substitute.For<IOutputProvider>();
        _runtime = new Runtime(_rangeProvider, _numberProvider, _outputProvider);
    }
    
    [Theory]
    [InlineData("TEST_VALUE_1")]
    [InlineData("TEST_VALUE_2")]
    public void Runtime_Run_OutputsNumberProviderValues(string testValuePrefix)
    {
        // Arrange
        _rangeProvider.GetRange().Returns(new List<int> { 1, 2 });
        _numberProvider.GetOutput(Arg.Any<int>()).Returns(x => $"{testValuePrefix}_{x.Arg<int>()}");
        
        // Act
        _runtime.Run();

        // Assert
        _outputProvider.Received().Output($"{testValuePrefix}_1");
        _outputProvider.Received().Output($"{testValuePrefix}_2");
    }
}