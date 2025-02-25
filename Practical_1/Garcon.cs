namespace Practical_1;

internal class Garcon : Funcionario
{
    public Garcon(string nome, string sobrenome, double valorHora, List<int> mesas) 
        : base(nome, sobrenome, valorHora)
    {
        Mesas = mesas;
    }

    public List<int> Mesas { get; private set; }

    public override void ExibirDados()
    {
        base.ExibirDados();
        Console.WriteLine($"Mesas: {string.Join(", ", Mesas)}");
    }
}
