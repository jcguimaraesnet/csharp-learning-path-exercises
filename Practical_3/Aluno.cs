namespace Practical_3;

internal class Aluno
{
    public required string Nome { get; init; }
    public required double Nota1 { get; init; }
    public required double Nota2 { get; init; }
    public required double Nota3 { get; init; }

    public double CalcularMedia()
        => (Nota1 + Nota2 + Nota3) / 3;

    public string Situacao()
    {
        switch (CalcularMedia())
        {
            case < 5:
                return "Reprovado";
            case < 7:
                return "Recuperação";
            default:
                return "Aprovado";
        }
    }
}
