namespace Practical_4;

public class Temperatura
{
    public required double Celsius { get; init; }
    public double ConverterParaFahrenheit()
        => Celsius * 1.8 + 32;
}
