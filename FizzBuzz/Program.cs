using FizzBuzz;
using FizzBuzz.Services;
using FizzBuzz.Services.Contracts;
using Microsoft.Extensions.DependencyInjection;

var serviceProvider = new ServiceCollection()
    .AddTransient<IRangeProvider, RangeProvider>()
    .AddTransient<INumberProvider, DivisibleByNumberProvider>()
    .AddTransient<IOutputProvider, ConsoleOutputProvider>()
    .AddTransient<IInterceptorProvider, ReflectionInterceptorProvider>()
    .AddTransient<Runtime>()
    .BuildServiceProvider();

var runtime = serviceProvider.GetRequiredService<Runtime>();
runtime.Run();