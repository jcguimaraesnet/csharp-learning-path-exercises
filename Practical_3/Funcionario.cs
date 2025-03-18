namespace Practical_3;

public abstract class Funcionario
{
    public Funcionario(string nome, string sobrenome, double valorHora)
    {
        Nome = nome;
        Sobrenome = sobrenome;
        _valorHora = valorHora;
    }

    private const double _quantidadeHorasMensais = 160;
    private double _valorHora;

    public string Nome { get; private set; }
    public string Sobrenome { get; private set; }
    public double ValorHora
    {
        get { return _valorHora; }
        protected set
        {
            _valorHora = value <= 0
                ? throw new ArgumentException("Valor hora deve ser maior que zero.")
                : value;
        }
    }

    private string ObterNomeCompleto() => $"{Nome} {Sobrenome}";

    public void ExibirDados()
    {
        string result = "\n\n## INFORMAÇÕES BÁSICAS DE FUNCIONÁRIO: ##\n";
        result += $"Nome completo: {this.ObterNomeCompleto()}\n";
        result += $"Tipo de funcionário: {this.GetType().Name}\n";
        result += $"Valor hora: {ValorHora:C2}\n";
        result += $"Salário Base: {CalcularSalarioBase():C2}\n";
        result += $"Auxilio dependente: {CalcularAuxilioDependentes():C2}\n";
        result += $"Salário total: {CalcularSalarioTotal():C2}\n";
        Console.WriteLine(result);
        ExibirDadosAdicionais();
    }

    public override string ToString()
    {
        var dados = $"{GetType().Name}|{Nome}|{Sobrenome}|{ValorHora}";
        return dados;
    }

    public abstract void ExibirDadosAdicionais();

    public double CalcularSalarioBase()
        => ValorHora * _quantidadeHorasMensais;

    private IList<Dependente> _dependentes = new List<Dependente>();

    public void AdicionarDependente(string nome, DateOnly dataNascimento)
    {
        var dependente = new Dependente(nome, dataNascimento);
        _dependentes.Add(dependente);
    }

    private double CalcularAuxilioDependentes()
    {
        const double valorAuxilioPorDependente = 500;
        return valorAuxilioPorDependente * _dependentes.Count;
    }

    private double CalcularSalarioTotal()
        => CalcularSalarioBase() + CalcularAuxilioDependentes();
}
