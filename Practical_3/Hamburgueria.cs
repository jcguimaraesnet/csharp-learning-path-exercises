namespace Practical_3;

public class Hamburgueria
{
    public Hamburgueria(string nome, string endereco)
    {
        Nome = nome;
        Endereco = endereco;
    }

    public string Nome { get; private set; }
    public string Endereco { get; private set; }
    
    private List<Funcionario> _funcionarios = new List<Funcionario>();
    public void AdicionarFuncionario(Funcionario funcionario)
    {
        _funcionarios.Add(funcionario);
    }

    public IList<Funcionario> ListarFuncionarios()
        => _funcionarios.ToList();

    string _dados = $@"{Environment.CurrentDirectory}\dados.txt";
    public void ExportarDados()
    {
        
        if (File.Exists(_dados))
            File.Delete(_dados);

        var dados = _funcionarios.Select(func => func.ToString()).ToArray();
        File.WriteAllLines(_dados, dados);
    }

    public void ImportarDados()
    {
        if (!File.Exists(_dados))
        {
            Console.WriteLine("Arquivo de dados não encontrado.");
            return;
        }

        var dados = File.ReadAllLines(_dados);
        _funcionarios = dados.Select(d => ConverteStrToFuncionario(d)).ToList();
    }

    private Funcionario ConverteStrToFuncionario(string str)
    {
        var partes = str.Split("|");
        var tipo = partes[0];
        var nome = partes[1];
        var sobrenome = partes[2];
        var valorHora = double.Parse(partes[3]);
        Funcionario funcionario = tipo switch
        {
            "Garcon" => new Garcon(nome, sobrenome, valorHora),
            "Supervisor" => new Supervisor(nome, sobrenome, valorHora),
            "Caixa" => new Caixa(nome, sobrenome, valorHora),
            _ => throw new ArgumentException("Tipo de funcionário inválido.")
        };
        return funcionario;
    }
}
