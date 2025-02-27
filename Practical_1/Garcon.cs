using System.Linq;

namespace Practical_1;

internal class Garcon : Funcionario
{
    public Garcon(string nome, string sobrenome, double valorHora, List<int> mesas) 
        : base(nome, sobrenome, valorHora)
    {
        Mesas = mesas;
    }

    public List<int> Mesas { get; private set; }

    public override void ExibirDadosAdicionais()
    {
        base.ExibirDados();
        Console.WriteLine("## INFORMAÇÕES ADICIONAIS ##");
        Console.WriteLine($"Mesas: {string.Join(", ", Mesas)}");
    }
}
