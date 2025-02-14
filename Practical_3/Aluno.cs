namespace Practical_3;

internal class Aluno
{
    public string Nome { get; set; }
    public double Nota1 { get; set; }
    public double Nota2 { get; set; }
    public double Nota3 { get; set; }

    public double CalcularMedia()
    {
        return (Nota1 + Nota2 + Nota3) / 3;
    }

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
