namespace Practical_1;

internal class Caixa : Funcionario
{
    public Caixa(string nome, string sobrenome, double valorHora, int valorFaturamentoMesAnterior)
        : base(nome, sobrenome, valorHora)
    {
        ValorFaturamentoMesAnterior = valorFaturamentoMesAnterior;
    }
    public int ValorFaturamentoMesAnterior { get; private set; }

    public override void ExibirDados()
    {
        base.ExibirDados();
        Console.WriteLine($"Valor Faturamento Mês Anterior: {ValorFaturamentoMesAnterior}");
    }
}
