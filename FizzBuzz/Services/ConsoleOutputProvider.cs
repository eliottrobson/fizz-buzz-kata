using FizzBuzz.Services.Contracts;

namespace FizzBuzz.Services;

public class ConsoleOutputProvider : IOutputProvider
{
    public void Output(string value)
    {
        Console.WriteLine(value);
    }
}