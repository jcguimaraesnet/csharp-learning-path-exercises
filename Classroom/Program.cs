namespace Classroom;

internal class Program
{
    static void Main(string[] args)
    {
        //EXEMPLO 1
        var horasExtras = new int[12];
        int somaHorasExtras = 0;
        for (var i = 0; i < horasExtras.Length; i++)
        {
            horasExtras[i] = Random.Shared.Next(1, 50);
            Console.WriteLine(horasExtras[i]);
            somaHorasExtras += horasExtras[i];
        }
        Console.WriteLine($"Soma das horas extras: {somaHorasExtras}");

        //EXEMPLO 2
        var nomeDosDiasDaSemana = new[] { "Domingo", "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado" };
        foreach (var nomeDia in nomeDosDiasDaSemana)
        {
            Console.WriteLine(nomeDia);
        }

        //EXEMPLO 3
        Console.WriteLine("Informe um número aleatório:");
        if (!int.TryParse(Console.ReadLine(), out var contagemRegressiva))
        {
            Console.WriteLine("Número inválido!");
        }
        while (contagemRegressiva > 0)
        {
            Console.WriteLine($"Número {contagemRegressiva--}");
            Thread.Sleep(1000);
        }

        //EXEMPLO 4
        var diaQueEuNasci = DiasDaSemana.Sexta;
        Console.WriteLine($"Eu nasci no dia da semana: {(int)diaQueEuNasci}");
        foreach (var dia in Enum.GetValues(typeof(DiasDaSemana)))
        {
            Console.WriteLine($"Dia: {Convert.ToInt32(dia)}");
        }

        //EXEMPLO 5
        var opcaoMenu = 0;
        var precoHamburguer = new[] { 12.50, 15.50 };
        do
        {
            Console.Clear();

            Console.WriteLine("Informe uma opção de menu: \n1 - beef burguer\n2 - Fish burguer \n3 - Sair");
            if (!int.TryParse(Console.ReadLine(), out opcaoMenu) || (opcaoMenu < 1 || opcaoMenu > 2))
            {
                Console.WriteLine("Opção inválida!");
                continue;
            }

            if (opcaoMenu == 3)
            {
                Console.WriteLine("Encerrando o programa...");
                break;
            }

            Console.WriteLine("Informe a quantidade de hamburgueres desejado:");
            if (!int.TryParse(Console.ReadLine(), out var quantidade))
            {
                Console.WriteLine("Quantidade inválida!");
                continue;
            }

            var totalDoPedido = precoHamburguer[opcaoMenu - 1] * quantidade;
            Console.WriteLine($"Total do pedido: {totalDoPedido:C}");
            Console.WriteLine("Digite qualquer tecla para reiniciar...");
            Console.ReadKey();

        } while (true);
    }
}
