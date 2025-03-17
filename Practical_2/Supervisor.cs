namespace Practical_2;

internal class Supervisor : Funcionario, IDissidioElegivel
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

    public void AdicionarDissidio()
        => ValorHora *= 1.10;
}
