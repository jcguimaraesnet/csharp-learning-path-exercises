namespace Practical_2;

internal class Garcon : Funcionario
{
    public Garcon(string nome, string sobrenome, double valorHora, List<int> mesas) 
        : base(nome, sobrenome, valorHora)
    {
        Mesas = mesas;
    }

    public List<int> Mesas { get; private set; }

    public void ExibirDados()
    {
        base.ExibirDadosBasicos();
        Console.WriteLine($"Mesas: {string.Join(", ", Mesas)}");
    }
}
