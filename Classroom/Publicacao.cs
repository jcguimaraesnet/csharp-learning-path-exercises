namespace Classroom;

internal class Publicacao
{
    public Publicacao(string titulo, int ano, string editora)
    {
        Titulo = titulo;
        Ano = ano;
        Editora = editora;
    }

    public string Titulo { get; set; }
    public int Ano { get; set; }
    public string Editora { get; set; }

    public virtual void ExibirDados()
    {
        Console.WriteLine();
        Console.WriteLine("## INFORMAÇÕES BÁSICAS: #####");
        Console.WriteLine($"Título: {Titulo}");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Editora: {Editora}");
        Console.WriteLine("#############################");
    }
}
