namespace Practical_1;

internal class Program
{
    static void Main(string[] args)
    {
        var func1 = new Garcon("João", "da Silva", 2_000, [1, 2, 4]);
        var func2 = new Supervisor("Maria", "da Silva", 2_500, Turno.Manha);
        var func3 = new Caixa("José", "da Silva", 3_000, 1);

        func1.ExibirDados();
        func2.ExibirDados();
        func3.ExibirDados();
    }
}
