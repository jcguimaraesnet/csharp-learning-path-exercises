namespace Practical_2;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calculo de IMC");
        Console.WriteLine("Informe o peso (kg):");
        if (!double.TryParse(Console.ReadLine(), out double peso))
        {
            Console.WriteLine("Peso inválido. Programa encerrado.");
            return;
        }

        Console.WriteLine("Informe a altura (m):");
        if (!double.TryParse(Console.ReadLine(), out double altura))
        {
            Console.WriteLine("Altura inválida. Programa encerrado.");
            return;
        }

        var imc = peso / Math.Pow(altura, 2);
        string categoria;
        switch (imc)
        {
            case <= 18.5:
                categoria = "Abaixo do peso";
                break;
            case <= 24.9:
                categoria = "Peso normal";
                break;
            case <= 29.9:
                categoria = "Sobrepeso";
                break;
            default:
                categoria = "Obesidade";
                break;
        }

        Console.WriteLine($"Seu IMC é: {imc:F2}");
        Console.WriteLine($"Sua categoria é: {categoria}");
    }
}
