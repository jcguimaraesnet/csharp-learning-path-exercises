namespace Practical_3;

internal class Supervisor : Funcionario
{
    public Supervisor(string nome, string sobrenome, double valorHora, Turno turno)
        : base(nome, sobrenome, valorHora)
    {
        Turno = turno;
    }

    public Turno Turno { get; private set; }

    public override void ExibirDadosAdicionais()
    {
        Console.WriteLine("## INFORMAÇÕES ADICIONAIS ##");
        Console.WriteLine($"Turno: {string.Join(", ", Turno)}");
    }

    private double CalcularAdicionalNoturno()
    {
        return Turno switch
        {
            Turno.Madrugada => ValorHora * 0.2,
            _ => ValorHora * 0.1
        };
    }

    protected override double CalcularSalarioAdicional()
        => CalcularAdicionalNoturno();
}
