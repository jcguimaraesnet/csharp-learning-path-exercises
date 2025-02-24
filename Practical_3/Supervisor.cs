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

    private double CalcularSalarioTotal()
        => CalcularSalarioBase() + CalcularAdicionalNoturno();

    public void ExibirSalarioTotal()
        => Console.WriteLine($"Salário total: {CalcularSalarioTotal():C}");

}

