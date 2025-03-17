namespace Practical_1;

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

    public IList<Funcionario> ListarGarcons()
        => _funcionarios.Where(f => f is Garcon).ToList();

    public IList<Funcionario> ListarSupervisores()
        => _funcionarios.Where(f => f is Supervisor).ToList();

    public IList<Funcionario> ListarCaixas()
        => _funcionarios.Where(f => f is Caixa).ToList();
}
