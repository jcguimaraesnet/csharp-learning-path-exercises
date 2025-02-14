namespace Practical_1;

public class Pedido
{
    private int _quantidade;
    public Pedido(string nome, double preco, int quantidade)
    {
        Nome = nome;
        Preco = preco;
        Quantidade = quantidade;
    }
    public string Nome { get; private set; }
    public double Preco { get; private set; }
    public int Quantidade
    {
        get
        {
            return _quantidade;
        }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Quantidade deve ser maior que zero.");
            }
            _quantidade = value;
        }
    }

    public double CalcularTotalPedido()
    {
        var totalPedido = Preco * Quantidade;
        if (totalPedido > 200) totalPedido *= 0.9;
        return totalPedido;
    }
}