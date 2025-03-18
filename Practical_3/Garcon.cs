namespace Practical_3;

internal class Garcon : Funcionario
{
    public Garcon(string nome, string sobrenome, double valorHora)
        : base(nome, sobrenome, valorHora)
    {
    }

    public Garcon(string nome, string sobrenome, double valorHora, List<int> mesas) 
        : base(nome, sobrenome, valorHora)
    {
        Mesas = mesas;
    }

    public List<int> Mesas { get; private set; } = new List<int>();

    public override void ExibirDadosAdicionais()
    {
        Console.WriteLine("## INFORMAÇÕES ADICIONAIS ##");
        Console.WriteLine($"Mesas: {string.Join(", ", Mesas)}");
    }
}
