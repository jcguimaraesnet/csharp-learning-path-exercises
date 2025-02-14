namespace Practical_4;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Conversão de temperatura de celsius para fahrenheit com POO");

        Console.WriteLine("Informe a temperatura em celsius:");
        if (!double.TryParse(Console.ReadLine(), out var celsius))
        {
            Console.WriteLine("Temperatura inválida! Programa será encerrado.");
            return;
        }

        Temperatura temperatura = new()
        {
            Celsius = celsius
        };

        Console.WriteLine($"Temperatura em Fahrenheit: {temperatura.ConverterParaFahrenheit():N2}");
    }
}
