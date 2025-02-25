namespace Classroom;

internal class Publicacao
{
    public Publicacao(string titulo, int ano, string editora)
    {
        Titulo = titulo;
        Ano = ano;
        Editora = editora;
    }

    public string Titulo { get; private set; }
    public int Ano { get; private set; }
    public string Editora { get; private set; }

    protected void ExibirDadosBasicos()
    {
        Console.WriteLine();
        Console.WriteLine("## INFORMAÇÕES BÁSICAS: #####");
        Console.WriteLine($"Título: {Titulo}");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Editora: {Editora}");
    }
}
