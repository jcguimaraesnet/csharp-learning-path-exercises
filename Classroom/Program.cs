using System.Drawing;
using System.Globalization;

namespace Classroom;

internal class Program
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
        Colorful.Console.WriteAscii("BIBLIOTECA", Color.FromArgb(244, 212, 255));

        var jornal = new Jornal("Folha de São Paulo", 2021, "Folha de São Paulo", new DateOnly(2021, 1, 5), "São Paulo");
        jornal.AdicionarSecao("Politica", "Editorial de política do brasil e do RJ");
        jornal.AdicionarSecao("Esportes", "Notícias sobre futebol e basquete");
        var revista = new Revista("Superinteressante", 2021, "Abril", 1, "1234-5678");
        revista.AdicionarSecao("Ciência", "Artigos sobre descobertas científicas");
        revista.AdicionarSecao("Tecnologia", "Notícias sobre lançamentos de produtos");
        var livro = new Livro("O Senhor dos Anéis", 1954, "Martins Fontes", "J.R.R. Tolkien", "978-0-395-19395-7");
        livro.AdicionarSecao("Prólogo", "O longo esperado festim");
        livro.AdicionarSecao("Capítulo 1", "Uma sombra do passado");

        var biblioteca = new Biblioteca("Biblioteca Alberto Einstein", "Centro / RJ");
        biblioteca.AdicionarPublicacao(jornal);
        biblioteca.AdicionarPublicacao(revista);
        biblioteca.AdicionarPublicacao(livro);

        biblioteca.ExportarDados();
        
        var novaBiblioteca = new Biblioteca("Biblioteca Nova", "Centro / RJ");
        novaBiblioteca.ImportarDados();
        
        foreach (var publicacao in novaBiblioteca.ListarPublicacoes())
        {
            publicacao.ExibirDados();
        }
    }
}
