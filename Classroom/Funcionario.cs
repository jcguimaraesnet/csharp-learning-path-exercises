namespace Classroom;

public class Funcionario
{
    private readonly string _primeiroNome;
    private readonly string _sobrenome;
    private readonly double _salario;
    private DateOnly? _dataNascimento;

    public required string PrimeiroNome 
    { 
        get => _primeiroNome;
        init
        {
            _primeiroNome = string.IsNullOrWhiteSpace(value) 
                ? throw new ArgumentException("Nome não pode ser nulo ou vazio.") 
                : value;
        }
    }
    public required string Sobrenome
    {
        get => _sobrenome;
        init
        {
            _sobrenome = string.IsNullOrWhiteSpace(value)
                ? throw new ArgumentException("Sobrenome não pode ser nulo ou vazio.")
                : value;
        }
    }

    
    public DateOnly? DataNascimento 
    { 
        get => _dataNascimento;
        set => _dataNascimento = value.HasValue && value.Value >= DateOnly.FromDateTime(DateTime.Now)
            ? throw new ArgumentException("Data de nascimento não pode ser maior que a data atual.")
            : value;
    }
    public required double Salario
    {
        get { return _salario; }
        init
        {
            _salario = value <= 0
                ? throw new ArgumentException("Salário deve ser maior que zero.")
                : value;
        }
    }

    public string NomeCompleto() 
        => $"{PrimeiroNome} {Sobrenome}".ToUpper();

    public double CalcularHoraExtra(bool adicionalNoturno = false)
    {
        const int qtdeHorasMes = 160;
        const double fatorHoraExtra = 1.4;
        double fatorAdicionalNoturno = adicionalNoturno ? 1.6 : 1.0;
        return Salario / qtdeHorasMes * fatorHoraExtra * fatorAdicionalNoturno;
    }

    //método com sobrecarga (overload)
    //public double CalcularHoraExtra(bool adicionalNoturno)
    //{
    //    const int qtdeHorasMes = 160;
    //    const double fatorHoraExtra = 1.4;
    //    double fatorAdicionalNoturno = adicionalNoturno ? 1.6 : 1.0;
    //    return Salario / qtdeHorasMes * fatorHoraExtra * fatorAdicionalNoturno;
    //}

    public bool MenorIdade()
        => DataNascimento?.AddYears(18) > DateOnly.FromDateTime(DateTime.Now);

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
