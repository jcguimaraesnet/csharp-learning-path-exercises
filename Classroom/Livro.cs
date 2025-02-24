namespace Classroom;

internal class Livro : Publicacao
{
    public Livro(string titulo, int ano, string editora, string autor, string isbn) 
        : base(titulo, ano, editora)
    {
        Autor = autor;
        ISBN = isbn;
    }

    public string Autor { get; set; }
    public string ISBN { get; set; }

    public override void ExibirDados()
    {
        base.ExibirDados();
        Console.WriteLine("## INFORMAÇÕES ADICIONAIS: ##");
        Console.WriteLine($"Autor: {Autor}");
        Console.WriteLine($"ISBN: {ISBN}");
        Console.WriteLine("#############################");
    }
}
