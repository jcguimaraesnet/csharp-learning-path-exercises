namespace Practical_1;

internal class Program
{
    static void Main(string[] args)
    {
        const double beefBurguer = 12.50;
        const double fishBurguer = 15.00;
        Console.WriteLine("Hamburgueria - Caixa registradora");
        Console.WriteLine("Escolha o hamburguer desejado:");
        Console.WriteLine($"1 - Beef Burguer ({beefBurguer:C})");
        Console.WriteLine($"2 - Fish Burguer ({fishBurguer:C})");
        if (!int.TryParse(Console.ReadLine(), out int opcao))
        {
            Console.WriteLine("Opção inválida. Programa encerrado.");
            return;
        }

        Console.WriteLine("Informe a quantidade desejada:");
        if (!int.TryParse(Console.ReadLine(), out int quantidade))
        {
            Console.WriteLine("Quantidade inválida. Programa encerrado.");
            return;
        }

        double totalPedido;
        switch (opcao)
        {
            case 1:
                totalPedido = beefBurguer * quantidade;
                break;
            case 2:
                totalPedido = fishBurguer * quantidade;
                break;
            default:
                Console.WriteLine("Opção inválida. Programa encerrado.");
                return;
        }

        Console.WriteLine($"Total do pedido: {totalPedido:C}");
    }
}
