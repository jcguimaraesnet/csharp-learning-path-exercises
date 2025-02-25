namespace Practical_1;

public class Funcionario
{
    public Funcionario(string nome, string sobrenome, double valorHora)
    {
        Nome = nome;
        Sobrenome = sobrenome;
        _valorHora = valorHora;
    }

    private double _valorHora;

    public string Nome { get; private set; }
    public string Sobrenome { get; private set; }
    public double ValorHora
    {
        get { return _valorHora; }
        private set
        {
            _valorHora = value <= 0
                ? throw new ArgumentException("Valor hora deve ser maior que zero.")
                : value;
        }
    }

    private string ObterNomeCompleto() => $"{Nome} {Sobrenome}";

    public virtual void ExibirDados()
    {
        Console.WriteLine();
        Console.WriteLine("## INFORMAÇÕES BÁSICAS DE FUNCIONÁRIO: ##");
        Console.WriteLine($"Nome completo: {this.ObterNomeCompleto()}");
        Console.WriteLine($"Tipo de funcionário: {this.GetType().Name}");
        Console.WriteLine($"Valor hora: {ValorHora:C2}");
    }
}
