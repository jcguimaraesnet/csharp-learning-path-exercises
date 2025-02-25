namespace Practical_2;

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
    }
}
