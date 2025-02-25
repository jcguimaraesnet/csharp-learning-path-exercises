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

    public void ExibirDados()
    {
        this.ExibirDados(ConsoleColor.White);
    }

    public void ExibirDados(ConsoleColor consoleColor)
    {
        Console.ForegroundColor = consoleColor;
        base.ExibirDadosBasicos();
        Console.WriteLine("## INFORMAÇÕES ADICIONAIS: ##");
        Console.WriteLine($"Data de Edição: {DataEdicao:dd/MM/yyyy}");
        Console.WriteLine($"Cidade: {Cidade}");
        Console.WriteLine("#############################");
    }
}
