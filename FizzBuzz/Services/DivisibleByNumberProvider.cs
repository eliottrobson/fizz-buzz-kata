using FizzBuzz.Services.Contracts;

namespace FizzBuzz.Services;

public class DivisibleByNumberProvider(IInterceptorProvider interceptorProvider) : INumberProvider
{
    private IReadOnlyCollection<DivisibleByInterceptor>? _interceptors;

    public string GetOutput(int number)
    {
        _interceptors ??= interceptorProvider.GetInterceptors();
        
        foreach (var interceptor in _interceptors)
        {
            // If all the numbers are divisible, replace with the value output
            if (interceptor.DivisibleBy.All(v => number % v == 0))
            {
                return interceptor.Instance.Value;
            }
        }

        // Return number if there is no value to replace with
        return number.ToString();
    }
}