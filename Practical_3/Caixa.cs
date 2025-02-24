namespace Practical_3;

internal class Caixa : Funcionario
{
    public Caixa(string nome, string sobrenome, double valorHora, int valorFaturamentoMesAnterior)
        : base(nome, sobrenome, valorHora)
    {
        ValorFaturamentoMesAnterior = valorFaturamentoMesAnterior;
    }
    
    public int ValorFaturamentoMesAnterior { get; private set; }

    private double CalcularBonus()
        => ValorFaturamentoMesAnterior * 0.01;

    private double CalcularSalarioTotal()
        => CalcularSalarioBase() + CalcularBonus();

    public void ExibirSalarioTotal()
        => Console.WriteLine($"Salário total: {CalcularSalarioTotal():C}");
}
