namespace Classroom;

internal class Program
{
    public delegate int Operacao(int x, int y);
    public delegate void Operacao3(int x, int y);
    public delegate void Callback(int result);

    static void Main(string[] args)
    {
        //exemplo final
        var jornal = new Jornal("Folha de São Paulo", 2021, "Folha de São Paulo", new DateOnly(2021, 1, 5), "São Paulo");
        var revista = new Revista("Superinteressante", 2021, "Abril", 1, "1234-5678");
        var livro = new Livro("O Senhor dos Anéis", 1954, "Martins Fontes", "J.R.R. Tolkien", "978-0-395-19395-7");

        var biblioteca = new Biblioteca("Biblioteca Alberto Einstein", "Centro / RJ");
        biblioteca.PublicacaoAdicionada += ImprimirPublicacaoAdicionada;
        biblioteca.PublicacaoAdicionada2 += ImprimirPublicacaoAdicionada;

        biblioteca.AdicionarPublicacao(jornal);
        biblioteca.AdicionarPublicacao(revista);
        biblioteca.AdicionarPublicacao(livro);

        biblioteca.ExibirPublicacoes(Console.WriteLine);
        biblioteca.ExibirPublicacoes(ImprimirPersonalizado);
    }

    static void ImprimirPersonalizado(string mensagem)
    {
        Console.BackgroundColor = ConsoleColor.Green;
        Console.WriteLine(mensagem);
        Console.BackgroundColor = ConsoleColor.Black;
    }

    static void ImprimirPublicacaoAdicionada(object? sender, Publicacao publicacao)
    {
        Console.WriteLine($"Publicação adicionada: {publicacao.Titulo}");
    }
}
