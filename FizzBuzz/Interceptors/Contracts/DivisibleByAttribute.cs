namespace FizzBuzz.Interceptors.Contracts;

[AttributeUsage(AttributeTargets.Class)]
public sealed class DivisibleByAttribute(params int[] numbers) : Attribute
{
    /// <summary>
    /// The numbers that this class applies divisible by logic to 
    /// </summary>
    public int[] Numbers { get; } = numbers;
}