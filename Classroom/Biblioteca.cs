namespace Classroom;

internal class Biblioteca
{
    public Biblioteca(string nome, string localizacao)
    {
        Nome = nome;
        Localizacao = localizacao;
    }

    private IList<Publicacao> publicacaos = new List<Publicacao>();

    public string Nome { get; private set; }
    public string Localizacao { get; private set; }

    public void AdicionarPublicacao(Publicacao publicacao)
    {
        publicacaos.Add(publicacao);
    }

    public List<Publicacao> ListarLivros()
    {
        return publicacaos.Where(p => p is Livro).ToList();
    }

    public List<Publicacao> ListarRevistas()
    {
        return publicacaos.Where(p => p is Revista).ToList();
    }

    public List<Publicacao> ListarJornais()
    {
        return publicacaos.Where(p => p is Jornal).ToList();
    }
}
