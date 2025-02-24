namespace Practical_3;

internal class Garcon : Funcionario
{
    public Garcon(string nome, string sobrenome, double valorHora, List<int> mesas) 
        : base(nome, sobrenome, valorHora)
    {
        Mesas = mesas;
    }

    public List<int> Mesas { get; private set; }

    public double CalcularComissao()
        => CalcularSalarioBase() * Mesas.Count / 100;

    private double CalcularSalarioTotal()
    => CalcularSalarioBase() + CalcularComissao();

    public void ExibirSalarioTotal()
        => Console.WriteLine($"Salário total: {CalcularSalarioTotal():C}");

}
