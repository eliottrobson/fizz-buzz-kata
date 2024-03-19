using FizzBuzz.Interceptors.Contracts;
using JetBrains.Annotations;

namespace FizzBuzz.Interceptors;

[DivisibleBy(3, 5, Order = 10), UsedImplicitly /* Activator.CreateInstance */]
public sealed class FizzBuzzInterceptor : IInterceptor
{
    public string Value => "FizzBuzz";
}