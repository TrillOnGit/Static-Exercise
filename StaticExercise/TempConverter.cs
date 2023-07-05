namespace StaticExercise;

public class TempConverter
{
    public static double FahrenheitToCelsius(double fahrNum) => (fahrNum - 32) * (5.0 / 9);

    public static double CelsiusToFahrenheit(double celNum) => celNum * (9.0 / 5) + 32;
}