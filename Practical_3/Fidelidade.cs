namespace Practical_3;

internal class Fidelidade
{
    private const int _pontuacaoInicial = 50;
    private List<Transacao> _transacoes = new();

    public int Pontuacao { get; private set; } = _pontuacaoInicial;

    public void AdicionarTransacao(string descricao, double valor)
    {
        var transacao = new Transacao(descricao, valor);
        _transacoes.Add(transacao);
        Pontuacao += transacao.CalcularPontos();
    }

    public void ResgatarPontos(int pontos)
    {
        if (pontos > Pontuacao)
        {
            throw new ArgumentException("Pontuação insuficiente.");
        }
        Pontuacao -= pontos;
    }

    public void ConsultarExtrato()
    {
        Console.WriteLine($"Pontuação: {Pontuacao}");
        Console.WriteLine("Transações:");
        foreach (var transacao in _transacoes)
        {
            Console.WriteLine($"{transacao.Descricao}: {transacao.Valor:C2}");
        }
    }
}
