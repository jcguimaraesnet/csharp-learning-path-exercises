namespace Practical_2;

internal class Caixa : Funcionario
{
    public Caixa(string nome, string sobrenome, double valorHora, int valorFaturamentoMesAnterior)
        : base(nome, sobrenome, valorHora)
    {
        ValorFaturamentoMesAnterior = valorFaturamentoMesAnterior;
    }
    public int ValorFaturamentoMesAnterior { get; private set; }

    public void ExibirDados()
    {
        base.ExibirDadosBasicos();
        Console.WriteLine($"Valor Faturamento Mês Anterior: {ValorFaturamentoMesAnterior}");
    }
}
