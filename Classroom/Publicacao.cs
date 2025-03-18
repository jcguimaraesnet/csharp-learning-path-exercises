namespace Classroom;

internal abstract class Publicacao
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

    public override string ToString()
    {
        var result = $"{GetType().Name}|{Titulo}|{Ano}|{Editora}";
        return result;
    }

    public void ExibirDados()
    {
        Console.WriteLine("## INFORMAÇÕES BÁSICAS: #####");
        Console.WriteLine($"Título: {Titulo}");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Editora: {Editora}");
        ExibirDadosAdicionais();
        Console.WriteLine("## SEÇÕES: #####");
        foreach (var secao in _secoes)
        {
            Console.WriteLine(secao.ToString());
        }
        Console.WriteLine("#############################\n");
        ExibirDadosAdicionais();
    }

    public abstract void ExibirDadosAdicionais();

    private IList<Secao> _secoes = new List<Secao>();

    public void AdicionarSecao(string titulo, string resumo)
    {
        _secoes.Add(new Secao(titulo, resumo));
    }
}
