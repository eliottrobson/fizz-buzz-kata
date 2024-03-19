using FizzBuzz.Services.Contracts;

namespace FizzBuzz.Services;

public class RangeProvider : IRangeProvider
{
    public IEnumerable<int> GetRange()
    {
        return Enumerable.Range(1, 100);
    }
}