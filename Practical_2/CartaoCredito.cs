namespace Practical_2;

internal class CartaoCredito
{
    private const double limiteInicial = 5_000;
    private List<Transacao> listaTransacao = new ();

    public double Limite { get; private set; } = limiteInicial;

    public void AdicionarTransacao(string descricao, double valor)
    {
        if (valor > Limite)
        {
            throw new ArgumentException("Limite excedido.");
        }
        Limite -= valor;
        listaTransacao.Add(new Transacao(descricao, valor));
    }

    public void ConsultarFatura()
    {
        Console.WriteLine($"Limite disponível: {Limite:C2}");
        Console.WriteLine("Transações:");
        foreach (var transacao in listaTransacao)
        {
            Console.WriteLine($"{transacao.Descricao}: {transacao.Valor:C2}");
        }
    }
}
