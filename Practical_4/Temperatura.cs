namespace Practical_4;

public class Temperatura
{
    public double Celsius { get; set; }
    public double ConverterParaFahrenheit()
    {
        return Celsius * 1.8 + 32;
    }
}
