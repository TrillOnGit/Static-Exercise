namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"2C is equal to {TempConverter.CelsiusToFahrenheit(2.0)}F.");
            Console.WriteLine($"2F is equal to {TempConverter.FahrenheitToCelsius(2.0)}C.");
        }
    }
}
