using FizzBuzz;
using Microsoft.Extensions.DependencyInjection;

var serviceProvider = new ServiceCollection()
    .AddTransient<Runtime>()
    .BuildServiceProvider();

var runtime = serviceProvider.GetRequiredService<Runtime>();
runtime.Run();