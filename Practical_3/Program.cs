namespace Practical_3;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Apurar notas de aluno");

        Console.WriteLine("Informe o nome do aluno:");
        var nome = Console.ReadLine();

        Console.WriteLine("Informe a primeira nota:");
        if (!double.TryParse(Console.ReadLine(), out var nota1))
        {
            Console.WriteLine("Nota inválida! Programa será encerrado.");
            return;
        }

        Console.WriteLine("Informe a segunda nota:");
        if (!double.TryParse(Console.ReadLine(), out var nota2))
        {
            Console.WriteLine("Nota inválida! Programa será encerrado.");
            return;
        }

        Console.WriteLine("Informe a terceira nota:");
        if (!double.TryParse(Console.ReadLine(), out var nota3))
        {
            Console.WriteLine("Nota inválida! Programa será encerrado.");
            return;
        }

        Aluno aluno = new()
        {
            Nome = nome,
            Nota1 = nota1,
            Nota2 = nota2,
            Nota3 = nota3
        };

        Console.WriteLine($"Média: {aluno.CalcularMedia()}");
        Console.WriteLine($"Situação: {aluno.Situacao()}");
    }
}