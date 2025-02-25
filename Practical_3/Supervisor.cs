namespace Practical_3;

internal class Supervisor : Funcionario
{
    public Supervisor(string nome, string sobrenome, double valorHora, Turno turno)
        : base(nome, sobrenome, valorHora)
    {
        Turno = turno;
    }

    public Turno Turno { get; private set; }

    public double CalcularAdicionalNoturno()
    {
        return Turno switch
        {
            Turno.Madrugada => ValorHora * 0.2,
            _ => ValorHora * 0.1
        };
    }

    protected override double CalcularSalario()
        => base.CalcularSalario() + CalcularAdicionalNoturno();
}
