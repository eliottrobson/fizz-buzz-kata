using FizzBuzz.Services.Contracts;

namespace FizzBuzz.Services;

public class DivisibleByNumberProvider : INumberProvider
{
    public string GetOutput(int number)
    {
        // TODO
        return number.ToString();
    }
}