namespace Practical_4;

public class Pedido
{
    private double _totalPedido;
    private List<ItemPedido> _itens = new();

    public void AdicionarItem(string descricao, double preco, int quantidade)
    {
        var item = new ItemPedido(descricao, preco, quantidade);
        _itens.Add(item);
        Total += item.CalcularTotalItem();
    }

    public double Total { get; private set; }
}