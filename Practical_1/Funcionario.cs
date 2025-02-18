namespace Practical_1;

public class Funcionario
{
    public Funcionario(string nome, Cargo cargo, double salario)
    {
        Nome = nome;
        Cargo = cargo;
        Salario = salario;
    }

    private double _salario;

    public string Nome { get; private set; }
    public Cargo Cargo { get; private set; }
    public double Salario
    {
        get { return _salario; }
        private set
        {
            _salario = value <= 0
                ? throw new ArgumentException("Salário deve ser maior que zero.")
                : value;
        }
    }

    public void AumentarSalario()
        => Salario *= (Cargo == Cargo.Gerente) ? 1.2 : 1.1;

}