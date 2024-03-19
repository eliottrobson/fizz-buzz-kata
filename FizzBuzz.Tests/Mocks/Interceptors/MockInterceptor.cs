using FizzBuzz.Interceptors.Contracts;

namespace FizzBuzz.Tests.Mocks.Interceptors;

public class MockInterceptor(string output) : IInterceptor
{
    public string Value => output;
}