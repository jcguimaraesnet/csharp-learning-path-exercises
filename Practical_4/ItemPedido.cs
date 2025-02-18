namespace Practical_4;

internal class ItemPedido
{
    public ItemPedido(string descricao, double preco, int quantidade)
    {
        Descricao = descricao;
        Preco = preco;
        Quantidade = quantidade;
    }

    private int _quantidade;

    public string Descricao { get; }
    public double Preco { get; }
    public int Quantidade { 
        get => _quantidade;
        private set
        {
            _quantidade = value <= 0
                ? throw new ArgumentException("Quantidade deve ser maior que zero.")
                : value;
        }
    }

    public double CalcularTotalItem()
        => Preco * Quantidade;
}
