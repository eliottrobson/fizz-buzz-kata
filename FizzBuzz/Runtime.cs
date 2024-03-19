using FizzBuzz.Services.Contracts;

namespace FizzBuzz;

internal class Runtime(
    IRangeProvider rangeProvider,
    INumberProvider numberProvider,
    IOutputProvider outputProvider
)
{
    public void Run()
    {
        foreach (var number in rangeProvider.GetRange())
        {
            var value = numberProvider.GetOutput(number);
            outputProvider.Output(value);
        }
    }
}