namespace Classroom;

internal class Biblioteca
{
    public Biblioteca(string nome, string localizacao)
    {
        Nome = nome;
        Localizacao = localizacao;
    }

    public delegate void PublicacaoAdicionadaHandler(object sender, Publicacao publicacao);
    public event PublicacaoAdicionadaHandler PublicacaoAdicionada;
    public event EventHandler<Publicacao> PublicacaoAdicionada2;

    private IList<Publicacao> _publicacoes = new List<Publicacao>();

    public string Nome { get; private set; }
    public string Localizacao { get; private set; }

    public void AdicionarPublicacao(Publicacao publicacao)
    {
        _publicacoes.Add(publicacao);
        PublicacaoAdicionada?.Invoke(this, publicacao);
        PublicacaoAdicionada2?.Invoke(this, publicacao);
    }

    public List<Publicacao> ListarPublicacoes()
    {
        return _publicacoes.ToList();
    }

    private string _dadosExportacao = $@"{Environment.CurrentDirectory}\dados.txt";

    public void ExportarDados()
    {
        if (File.Exists(_dadosExportacao))
            File.Delete(_dadosExportacao);

        var dados = _publicacoes.Select(pub => pub.ToString()).ToArray();
        File.WriteAllLines(_dadosExportacao, dados);
    }

    public void ImportarDados()
    {
        if (!File.Exists(_dadosExportacao))
        {
            Console.WriteLine("Arquivo de dados não encontrado.");
            return;
        }

        var dados = File.ReadAllLines(_dadosExportacao);
        _publicacoes = dados.Select(d => ConverteStrToPublicacao(d)).ToList();
    }

    private Publicacao ConverteStrToPublicacao(string str)
    {
        var partes = str.Split("|");
        var tipo = partes[0];
        var titulo = partes[1];
        var ano = int.Parse(partes[2]);
        var editora = partes[3];

        Publicacao publicacao = tipo switch
        {
            "Revista" => new Revista(titulo, ano, editora),
            "Jornal" => new Jornal(titulo, ano, editora),
            "Livro" => new Livro(titulo, ano, editora),
            _ => throw new ArgumentException("Tipo de publicação inválido.")
        };

        return publicacao;
    }

    public void ExibirPublicacoes(Action<string> imprimir)
    {
        foreach (var publicacao in _publicacoes)
        {
            imprimir(publicacao.ToString());
        }
    }

}
