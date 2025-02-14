using System.Drawing;

namespace Classroom;

internal class Program
{
    static void Main(string[] args)
    {
        Colorful.Console.WriteAscii("HAMBURGUERIA", Color.FromArgb(244, 212, 255));

        var funcionario = new Funcionario("João", "Silva", new DateOnly(2015, 1, 1), 50_000);
        Console.WriteLine($"Nome completo: {funcionario.NomeCompleto()}");
        Console.WriteLine($"Salário: {funcionario.Salario:C}");
        Console.WriteLine($"Valor da hora extra: {funcionario.CalcularHoraExtra():C}");
        Console.WriteLine($"Menor de idade: {funcionario.MenorIdade()}");
        Console.WriteLine($"Classificação de renda: {funcionario.ClassificarRenda()}");

        //exemplo de funcionario com try catch
        try
        {
            var funcionarioComSalarioInvalido = new Funcionario("Maria", "Santos", new DateOnly(2000, 1, 1), 0.00);
            Console.WriteLine($"Nome completo: {funcionarioComSalarioInvalido.NomeCompleto()}");
            Console.WriteLine($"Salário: {funcionarioComSalarioInvalido.Salario:C}");
            Console.WriteLine($"Valor da hora extra: {funcionarioComSalarioInvalido.CalcularHoraExtra():C}");
            Console.WriteLine($"Menor de idade: {funcionarioComSalarioInvalido.MenorIdade()}");
            Console.WriteLine($"Classificação de renda: {funcionarioComSalarioInvalido.ClassificarRenda()}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro na execução do programa. Erro ocorrido: {ex.Message}");
            Console.WriteLine("Encerrando o programa...");
            return;
        }
    }
}
