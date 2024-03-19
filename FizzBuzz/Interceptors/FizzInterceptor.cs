using FizzBuzz.Interceptors.Contracts;
using JetBrains.Annotations;

namespace FizzBuzz.Interceptors;

[DivisibleBy(3), UsedImplicitly /* Activator.CreateInstance */]
public sealed class FizzInterceptor : IInterceptor
{
    public string Value => "Fizz";
}