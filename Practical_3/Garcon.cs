namespace Practical_3;

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
        Console.WriteLine($"Salário total: {CalcularSalarioTotal():C}");
    }

    private double CalcularComissao()
        => CalcularSalarioBase() * Mesas.Count / 100;

    private double CalcularSalarioTotal()
    => CalcularSalarioBase() + CalcularComissao();

}
