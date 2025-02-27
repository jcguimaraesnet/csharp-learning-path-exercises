namespace Classroom;

internal class Revista : Publicacao
{
    public Revista(string titulo, int ano, string editora, int numeroEdicao, string issn)
        : base(titulo, ano, editora)
    {
        NumeroEdicao = numeroEdicao;
        ISSN = issn;
    }

    public int NumeroEdicao { get; set; }
    public string ISSN { get; set; }

    public override void ExibirDadosAdicionais()
    {
        Console.WriteLine("## INFORMAÇÕES ADICIONAIS: ##");
        Console.WriteLine($"Número da Edição: {NumeroEdicao}");
        Console.WriteLine($"ISSN: {ISSN}");
        Console.WriteLine("#############################");
    }
}
