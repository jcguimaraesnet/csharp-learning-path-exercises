using System.Drawing;

namespace Classroom;

internal class Program
{
    static void Main(string[] args)
    {
        Colorful.Console.WriteAscii("HAMBURGUERIA", Color.FromArgb(244, 212, 255));

        var funcionario = new Funcionario() 
        { 
            PrimeiroNome = "Júlio", 
            Sobrenome = "Guimarães", 
            DataNascimento = new DateOnly(2015, 1, 1), 
            Salario = 50_000 
        };

        Console.WriteLine($"Nome completo: {funcionario.NomeCompleto()}");
        Console.WriteLine($"Salário: {funcionario.Salario:C}");
        Console.WriteLine($"Valor da hora extra: {funcionario.CalcularHoraExtra():C}");
        Console.WriteLine($"Valor da hora extra (com adicional noturno): {funcionario.CalcularHoraExtra(true):C}");
        Console.WriteLine($"Menor de idade: {funcionario.MenorIdade()}");
        Console.WriteLine($"Classificação de renda: {funcionario.ClassificarRenda()}");
        Console.WriteLine($"Elegível para o Bolsa Família: {funcionario.ClassificarRenda().ElegivelBolsaFamilia()}");

        //exemplo de funcionario com try catch
        try
        {
            var funcionarioComSalarioInvalido = new Funcionario()
            {
                PrimeiroNome = "Júlio",
                Sobrenome = "Guimarães",
                DataNascimento = new DateOnly(2027, 1, 1),
                Salario = 50_000
            };

            Console.WriteLine($"Nome completo: {funcionarioComSalarioInvalido.NomeCompleto()}");
            Console.WriteLine($"Salário: {funcionarioComSalarioInvalido.Salario:C}");
            Console.WriteLine($"Valor da hora extra: {funcionarioComSalarioInvalido.CalcularHoraExtra():C}");
            Console.WriteLine($"Valor da hora extra (com adicional noturno): {funcionarioComSalarioInvalido.CalcularHoraExtra(true):C}");
            Console.WriteLine($"Menor de idade: {funcionarioComSalarioInvalido.MenorIdade()}");
            Console.WriteLine($"Classificação de renda: {funcionarioComSalarioInvalido.ClassificarRenda()}");
            Console.WriteLine($"Elegível para o Bolsa Família: {funcionarioComSalarioInvalido.ClassificarRenda().ElegivelBolsaFamilia()}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro na execução do programa. Erro ocorrido: {ex.Message}");
            Console.WriteLine("Encerrando o programa...");
            return;
        }
    }
}
