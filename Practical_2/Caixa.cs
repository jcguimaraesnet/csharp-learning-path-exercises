namespace Practical_2;

internal class Caixa : Funcionario
{
    public Caixa(string nome, string sobrenome, double valorHora, double valorFaturamentoMesAnterior)
        : base(nome, sobrenome, valorHora)
    {
        ValorFaturamentoMesAnterior = valorFaturamentoMesAnterior;
    }

    public double ValorFaturamentoMesAnterior { get; private set; }

    public override void ExibirDadosAdicionais()
    {
        base.ExibirDados();
        Console.WriteLine("## INFORMAÇÕES ADICIONAIS ##");
        Console.WriteLine($"Valor faturamento anterior: {ValorFaturamentoMesAnterior:N2}");
    }
}
