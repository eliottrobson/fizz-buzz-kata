using FizzBuzz.Interceptors.Contracts;

namespace FizzBuzz.Services.Contracts;

public record DivisibleByInterceptor(IInterceptor Instance, int[] DivisibleBy);

public interface IInterceptorProvider
{
    IReadOnlyList<DivisibleByInterceptor> GetInterceptors();
}