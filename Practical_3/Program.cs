namespace Practical_3;

internal class Program
{
    static void Main(string[] args)
    {
        var colecaoFuncionarios = new List<Funcionario>();

        var garcon = new Garcon("João", "da Silva", 2_000, [1, 2, 4]);
        garcon.AdicionarDependente("Maria", new DateOnly(2000, 1, 1));
        var supervisor = new Supervisor("Maria", "da Silva", 2_500, Turno.Manha);
        supervisor.AdicionarDependente("José", new DateOnly(2000, 1, 1));
        supervisor.AdicionarDependente("Ana", new DateOnly(2000, 1, 1));
        var caixa = new Caixa("José", "da Silva", 3_000, 1);

        var hamburgueria = new Hamburgueria("Hamburgueria do JC", "Rio de Janeiro");
        hamburgueria.AdicionarFuncionario(garcon);
        hamburgueria.AdicionarFuncionario(supervisor);
        hamburgueria.AdicionarFuncionario(caixa);

        hamburgueria.GerarRelatorio();
        hamburgueria.ExibirRelatorio();
    }
}
