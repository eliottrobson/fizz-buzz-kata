using FizzBuzz.Interceptors.Contracts;
using JetBrains.Annotations;

namespace FizzBuzz.Interceptors;

[DivisibleBy(5), UsedImplicitly /* Activator.CreateInstance */]
public sealed class BuzzInterceptor : IInterceptor
{
    public string Value => "Buzz";
}