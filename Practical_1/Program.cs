namespace Practical_1;

internal class Program
{
    private static string[] produtos = ["Beef Burguer", "Fish Burguer"];
    private static double[] precos = [12.50, 15.00];

    static void Main(string[] args)
    {
        List<Pedido> pedidos = new();

        int opcao;
        do
        {
            Console.Clear();
            Console.WriteLine("Hamburgueria - Caixa registradora");
            Console.WriteLine("Escolha o hamburguer desejado:");
            Console.WriteLine($"1 - {produtos[0]} ({precos[0]:C})");
            Console.WriteLine($"2 - {produtos[1]} ({precos[1]:C})");
            Console.WriteLine("3 - Calcular total do pedido");
            Console.WriteLine("4 - Sair");
            Console.WriteLine("Digite a opção desejada:");

            if (!int.TryParse(Console.ReadLine(), out opcao) || (opcao < 1 || opcao > 4))
            {
                Console.WriteLine("Opção inválida. Programa encerrado.");
                return;
            }

            switch (opcao)
            {
                case 1:
                    AdicionarPedido(pedidos, opcao);
                    break;
                case 2:
                    AdicionarPedido(pedidos, opcao);
                    break;
                case 3:
                    CalcularTotalPedido(pedidos);
                    break;
            }
        } while (opcao != 4);


        Console.WriteLine("Obrigado por utilizar nosso sistema de caixa!");
    }

    static void AdicionarPedido(List<Pedido> pedidos, int opcao)
    {
        Console.WriteLine("Informe a quantidade do produto:");
        if (!int.TryParse(Console.ReadLine(), out var quantidade))
        {
            throw new OperationCanceledException("Quantidade inválida. Programa encerrado.");
        }

        try
        {
            pedidos.Add(new Pedido()
            {
                Nome = produtos[opcao - 1],
                Preco = precos[opcao - 1],
                Quantidade = quantidade
            });
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Ocorreu um erro inesperado na execução do programa. Erro ocorrido {ex.Message}.");
            Console.WriteLine("Programa encerrado.");
        }

        Console.WriteLine("Pedido adicionado com sucesso!");
        Console.WriteLine("Digite qualquer tecla para continuar...");
        Console.ReadKey();
    }

    static void CalcularTotalPedido(List<Pedido> pedidos)
    {
        double totalPedido = pedidos.Sum(pedido => pedido.CalcularTotalPedido());

        Console.WriteLine($"Total do pedido: {totalPedido:C}");
        Console.WriteLine("Digite qualquer tecla para continuar...");
        Console.ReadKey();
    }
}
