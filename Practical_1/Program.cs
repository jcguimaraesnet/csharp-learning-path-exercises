namespace Practical_1;

internal class Program
{
    static void Main(string[] args)
    {
        var colecaoFuncionarios = new List<Funcionario>()
        {
            new Garcon("João", "da Silva", 2_000, [1, 2, 4]),
            new Supervisor("Maria", "da Silva", 2_500, Turno.Manha),
            new Caixa("José", "da Silva", 3_000, 1),
            new Garcon("João", "da Silva", 4_000, [1, 5, 6]),
            new Supervisor("Maria", "da Silva", 4_500, Turno.Tarde),
            new Caixa("José", "da Silva", 5_000, 1),
            new Garcon("João", "da Silva", 6_000, [1, 7, 8]),
            new Supervisor("Maria", "da Silva", 6_500, Turno.Madrugada),
            new Caixa("José", "da Silva", 7_000, 1),
            new Garcon("João", "da Silva", 7_000, [1, 9, 10]),
        };

        foreach (var funcionario in colecaoFuncionarios)
        {
            funcionario.ExibirDados();
        }
    }
}
