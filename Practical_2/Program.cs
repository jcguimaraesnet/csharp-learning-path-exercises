namespace Practical_2;

public enum CaraCoroa
{
    Cara = 1,
    Coroa
}

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Jogo de cara ou coroa");
        int opcaoCorreta;
        int opcaoUsuario;
        do
        {
            Console.Clear();
            opcaoCorreta = Random.Shared.Next(1, 3);
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Cara");
            Console.WriteLine("2 - Coroa");
            if (!int.TryParse(Console.ReadLine(), out opcaoUsuario) || opcaoUsuario < 1 || opcaoUsuario > 2)
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                continue;
            }
            if (opcaoUsuario != opcaoCorreta)
            {
                Console.WriteLine("Errou! Tente novamente.");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        } while (opcaoUsuario != opcaoCorreta);

        Console.WriteLine($"Parabéns! Você acertou! A opção correta era {(CaraCoroa)opcaoCorreta}.");
    }
}
