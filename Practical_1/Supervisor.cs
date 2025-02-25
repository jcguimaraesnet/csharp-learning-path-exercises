namespace Practical_1;

internal class Supervisor : Funcionario
{
    public Supervisor(string nome, string sobrenome, double valorHora, Turno turno)
        : base(nome, sobrenome, valorHora)
    {
        Turno = turno;
    }

    public Turno Turno { get; private set; }

    public override void ExibirDados()
    {
        base.ExibirDados();
        Console.WriteLine($"Turno: {Turno}");
    }
}
