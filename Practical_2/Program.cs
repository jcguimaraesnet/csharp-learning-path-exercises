namespace Practical_2;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calculo de IMC");

        Console.WriteLine("Informe o peso:");
        if (!double.TryParse(Console.ReadLine(), out var peso))
        {
            Console.WriteLine("Peso inválido! Programa será encerrado.");
            return;
        }

        Console.WriteLine("Informe a altura:");
        if (!double.TryParse(Console.ReadLine(), out var altura))
        {
            Console.WriteLine("Altura inválida! Programa será encerrado.");
            return;
        }

        IMC imc = new()
        {
            Peso = peso,
            Altura = altura
        };

        Console.WriteLine($"IMC: {imc.CalcularIMC():N2}");
        Console.WriteLine($"Situação: {imc.Situacao()}");
    }
}
