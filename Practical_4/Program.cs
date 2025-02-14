namespace Practical_4;

internal class Program
{
    static void Main(string[] args)
    {
        var notas = new float[4];
        float somaNotas = 0;
        float maiorNota = 0;
        float menorNota = 0;
        for (var i = 0; i < notas.Length; i++)
        {
            Console.WriteLine("Informe a nota escolar:");
            if (!float.TryParse(Console.ReadLine(), out notas[i]))
            {
                Console.WriteLine("Nota inválida! Programa será encerrado.");
                return;
            }
            somaNotas += notas[i];
            if (notas[i] > maiorNota) maiorNota = notas[i];
            if (i == 0) menorNota = notas[i];
            if (notas[i] < menorNota) menorNota = notas[i];
        }
        Console.WriteLine($"Média: {somaNotas / notas.Length}");
        Console.WriteLine($"Maior nota: {maiorNota}");
        Console.WriteLine($"Menor nota: {menorNota}");
    }
}
