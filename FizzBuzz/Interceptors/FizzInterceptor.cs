using FizzBuzz.Interceptors.Contracts;
using JetBrains.Annotations;

namespace FizzBuzz.Interceptors;

[DivisibleBy(3, Order = 20), UsedImplicitly /* Activator.CreateInstance */]
public sealed class FizzInterceptor : IInterceptor
{
    public string Value => "Fizz";
}