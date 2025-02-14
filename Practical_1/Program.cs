namespace Practical_1;

internal class Program
{
    static void Main(string[] args)
    {
        string[] produtos = ["Beef Burguer", "Fish Burguer"];
        double[] precos = [ 12.50, 15.00 ];


        Console.Clear();
        Console.WriteLine("Hamburgueria - Caixa registradora");
        Console.WriteLine("Escolha o hamburguer desejado:");
        Console.WriteLine($"1 - {produtos[0]} ({precos[0]:C})");
        Console.WriteLine($"2 - {produtos[1]} ({precos[1]:C})");
        if (!int.TryParse(Console.ReadLine(), out int opcao) || (opcao < 1 || opcao > 2))
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

        try
        {
            var pedido = new Pedido(produtos[opcao - 1], precos[opcao - 1], quantidade);
            Console.WriteLine($"Total do pedido: {pedido.CalcularTotalPedido():C}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Ocorreu um erro inesperado na execução do programa. Erro ocorrido {ex.Message}.");
            Console.WriteLine("Programa encerrado.");
        }

        Console.WriteLine("Obrigado por utilizar nosso sistema de caixa!");
    }
}
