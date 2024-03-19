namespace FizzBuzz.Services.Contracts;

public interface IRangeProvider
{
    IEnumerable<int> GetRange();
}