namespace Practical_3;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calcular média escolar com base em tres notas");
        Console.WriteLine("Informe o nome do aluno");
        var nome = Console.ReadLine();
        Console.WriteLine("Informe a primeira nota");
        if (!double.TryParse(Console.ReadLine(), out double nota1))
        {
            Console.WriteLine("Nota inválida. Programa encerrado.");
            return;
        }
        Console.WriteLine("Informe a segunda nota");
        if (!double.TryParse(Console.ReadLine(), out double nota2))
        {
            Console.WriteLine("Nota inválida. Programa encerrado.");
            return;
        }
        Console.WriteLine("Informe a terceira nota");
        if (!double.TryParse(Console.ReadLine(), out double nota3))
        {
            Console.WriteLine("Nota inválida. Programa encerrado.");
            return;
        }
        var media = (nota1 + nota2 + nota3) / 3;
        string situacao;
        switch (media)
        {
            case < 5:
                situacao = "Reprovado";
                break;
            case < 7:
                situacao = "Recuperação";
                break;
            default:
                situacao = "Aprovado";
                break;
        }
        Console.WriteLine($"O aluno {nome} obteve média de {media:F2} e está {situacao}.");
    }
}
