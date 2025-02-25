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

    public virtual void ExibirDados()
    {
        Console.WriteLine("## INFORMAÇÕES BÁSICAS: #####");
        Console.WriteLine($"Título: {Titulo}");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Editora: {Editora}");
    }

    public override string ToString()
        => $"## INFORMAÇÕES BÁSICAS: #####\n" +
            "Título: {Titulo}\n" +
            "Ano: {Ano}\n" +
            "Editora: {Editora}\n";
}
