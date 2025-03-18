namespace Classroom;

public abstract class Publicacao
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

    public void ExibirDados()
    {
        Console.WriteLine("## INFORMAÇÕES BÁSICAS: #####");
        Console.WriteLine($"Título: {Titulo}"); 
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Editora: {Editora}");
        ExibirDadosAdicionais();
        Console.WriteLine();
    }

    public abstract void ExibirDadosAdicionais();
}
