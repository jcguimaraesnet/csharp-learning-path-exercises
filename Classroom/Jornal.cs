namespace Classroom;

internal class Jornal : Publicacao
{
    public Jornal(string titulo, int ano, string editora, DateOnly dataEdicao, string cidade)
        : base(titulo, ano, editora)
    {
        DataEdicao = dataEdicao;
        Cidade = cidade;
    }

    public DateOnly DataEdicao { get; set; }
    public string Cidade { get; set; }

    public override void ExibirDados()
    {
        base.ExibirDados();
        Console.WriteLine("## INFORMAÇÕES ADICIONAIS: ##");
        Console.WriteLine($"Data de Edição: {DataEdicao:dd/MM/yyyy}");
        Console.WriteLine($"Cidade: {Cidade}");
        Console.WriteLine("#############################");
    }

    public override string ToString()
    {
        return base.ToString() +
            "## INFORMAÇÕES ADICIONAIS: ##\n" +
            $"Data de Edição: {DataEdicao:dd/MM/yyyy}\n" +
            $"Cidade: {Cidade}\n" +
            "#############################\n";

    }
}
