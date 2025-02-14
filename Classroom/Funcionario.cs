namespace Classroom;

public class Funcionario
{
    public enum ClasseRenda
    {
        E = 1_500,
        D = 5_000,
        C = 10_000,
        B = 20_000,
        A = 20_001
    }

    public Funcionario(string primeiroNome, string sobrenome, DateOnly dataNascimento, double salario)
    {
        PrimeiroNome = primeiroNome;
        Sobrenome = sobrenome;
        DataNascimento = dataNascimento;
        Salario = salario;
    }

    private double _salario;

    public string PrimeiroNome { get; private set; }
    public string Sobrenome { get; private set; }
    public DateOnly DataNascimento { get; private set; }
    public double Salario
    {
        get { return _salario; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("Salário deve ser maior que zero.");
            _salario = value;
        }
    }

    public string NomeCompleto()
    {
        return $"{PrimeiroNome} {Sobrenome}".ToUpper();
    }

    public double CalcularHoraExtra()
    {
        const int qtdeHorasMes = 160;
        const double fatorHoraExtra = 1.4;
        return Salario / qtdeHorasMes * fatorHoraExtra;
    }

    public bool MenorIdade()
    {
        return DataNascimento.AddYears(18) > DateOnly.FromDateTime(DateTime.Now);
    }

    public ClasseRenda ClassificarRenda()
    {
        switch (Salario)
        {
            case <= (int)ClasseRenda.E:
                return ClasseRenda.E;
            case <= (int)ClasseRenda.D:
                return ClasseRenda.D;
            case <= (int)ClasseRenda.C:
                return ClasseRenda.C;
            case <= (int)ClasseRenda.B:
                return ClasseRenda.B;
            default:
                return ClasseRenda.A;
        }
    }
}
