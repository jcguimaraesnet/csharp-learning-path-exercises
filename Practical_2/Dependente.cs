namespace Practical_2;

public class Dependente
{
    public Dependente(string nome, DateOnly dataNascimento)
    {
        Nome = nome;
        DataNascimento = dataNascimento;
    }

    public string Nome { get; private set; }
    public DateOnly DataNascimento { get; private set; }
}
