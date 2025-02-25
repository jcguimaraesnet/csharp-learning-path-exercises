namespace Practical_3;

internal class Supervisor : Funcionario
{
    public Supervisor(string nome, string sobrenome, double valorHora, Turno turno)
        : base(nome, sobrenome, valorHora)
    {
        Turno = turno;
    }

    public Turno Turno { get; private set; }

    public void ExibirDados()
    {
        base.ExibirDadosBasicos();
        Console.WriteLine($"Turno: {Turno}");
        Console.WriteLine($"Salário total: {CalcularSalarioTotal():C}");
    }

    private double CalcularAdicionalNoturno()
    {
        return Turno switch
        {
            Turno.Madrugada => ValorHora * 0.2,
            _ => ValorHora * 0.1
        };
    }

    private double CalcularSalarioTotal()
        => CalcularSalarioBase() + CalcularAdicionalNoturno();
}
