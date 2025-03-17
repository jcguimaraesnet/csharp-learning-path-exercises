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
        var result = "## INFORMAÇÕES BÁSICAS: #####\n";
        result += $"Título: {Titulo}\n";
        result += $"Ano: {Ano}\n";
        result += $"Editora: {Editora}\n";
        result += "## SEÇÕES: #####\n";
        foreach (var secao in _secoes)
        {
            result += secao.ToString() + "\n";
        }
        result += "#############################\n\n";
        return result;
    }

    public void ExibirDados()
    {
        Console.WriteLine(ToString());
        ExibirDadosAdicionais();
    }

    public abstract void ExibirDadosAdicionais();

    private IList<Secao> _secoes = new List<Secao>();

    public void AdicionarSecao(string titulo, string resumo)
    {
        _secoes.Add(new Secao(titulo, resumo));
    }
}
