using System.Drawing;
using System.Globalization;

namespace Classroom;

internal class Program
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
        Colorful.Console.WriteAscii("BIBLIOTECA", Color.FromArgb(244, 212, 255));

        var colecaoPublicacoes = new List<Publicacao>
        {
            new Jornal("Folha de São Paulo", 2021, "Folha de São Paulo", new DateOnly(2021, 1, 5), "São Paulo"),
            new Jornal("O Globo", 2021, "O Globo", new DateOnly(2021, 1, 5), "Rio de Janeiro"),
            new Jornal("O Estado de São Paulo", 2021, "Estadão", new DateOnly(2021, 1, 5), "São Paulo"),
            new Jornal("Correio Braziliense", 2021, "Correio Braziliense", new DateOnly(2021, 1, 5), "Brasília"),
            new Revista("Superinteressante", 2021, "Abril", 1, "1234-5678"),
            new Revista("Veja", 2021, "Abril", 1, "1234-5678"),
            new Revista("IstoÉ", 2021, "Três", 1, "1234-5678"),
            new Revista("Exame", 2021, "Abril", 1, "1234-5678"),
            new Livro("O Senhor dos Anéis", 1954, "Martins Fontes", "J.R.R. Tolkien", "978-0-395-19395-7"),
            new Livro("O Hobbit", 1937, "Martins Fontes", "J.R.R. Tolkien", "978-0-395-19395-7"),
            new Livro("O Silmarillion", 1977, "Martins Fontes", "J.R.R. Tolkien", "978-0-395-19395-7"),
            new Livro("O Código Da Vinci", 2003, "Arqueiro", "Dan Brown", "978-0-395-19395-7")
        };

        foreach (var publicacao in colecaoPublicacoes)
        {
            //Console.WriteLine(publicacao.ExibirDados());
            Console.WriteLine(publicacao);
        }
    }
}
