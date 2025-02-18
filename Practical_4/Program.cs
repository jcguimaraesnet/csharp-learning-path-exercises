namespace Practical_4;

internal class Program
{
    static void Main(string[] args)
    {
        var pedido = new Pedido();
        pedido.AdicionarItem("Camisa", 50, 2);
        pedido.AdicionarItem("Calça", 100, 1);
        Console.WriteLine($"Total do pedido: {pedido.Total}");
    }
}
