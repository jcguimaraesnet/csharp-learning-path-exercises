namespace Practical_1;

public class Pedido
{
    private readonly int _quantidade;
    public required string Nome { get; init; }
    public required double Preco { get; init; }
    public required int Quantidade
    {
        get
        {
            return _quantidade;
        }
        init
        {
            _quantidade = value <= 0
                ? throw new ArgumentException("Quantidade deve ser maior que zero.")
                : value;
        }
    }

    public double CalcularTotalPedido()
    {
        var totalPedido = Preco * Quantidade;
        if (totalPedido > 200) totalPedido *= 0.9;
        return totalPedido;
    }
}