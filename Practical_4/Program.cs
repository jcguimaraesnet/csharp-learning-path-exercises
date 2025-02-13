namespace Practical_4;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Conversor de temperatura de celsius para fahrenheit");
        Console.WriteLine("Informe a temperatura em celsius:");
        if (!double.TryParse(Console.ReadLine(), out double celsius))
        {
            Console.WriteLine("Temperatura inválida. Programa encerrado.");
            return;
        }

        var fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine($"Temperatura em °C de {celsius:N2} equivale a temperatura {fahrenheit:N2} em °F.");
    }
}
