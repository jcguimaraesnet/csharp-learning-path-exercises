using Practical_1;

namespace Practical_1Tests;

public class FuncionarioTests
{
    class FuncionarioTeste : Funcionario
    {
        public FuncionarioTeste(string nome, string sobrenome, double valorHora) : base(nome, sobrenome, valorHora) { }
        public override void ExibirDadosAdicionais()
        {
            throw new NotImplementedException();
        }
    }

    [Fact]
    public void Funcionario_ObterNomeCompleto_NomeSobrenome()
    {
        //A - arrange
        var nome = "João";
        var sobrenome = "Silva";
        var funcionario = new FuncionarioTeste(nome, sobrenome, 10.0);

        //A - act
        var nomeCompleto = funcionario.ObterNomeCompleto();

        //A - assert
        Assert.True(nomeCompleto == $"{nome} {sobrenome}");
    }

    [Fact]
    public void Funcionario_ValorHora_MenorIgualZero_ArgumentException()
    {
        //A - arrange
        var nome = "João";
        var sobrenome = "Silva";
        var valorHora = 0.0;

        //A - act
        var exception = Assert.Throws<ArgumentException>(() => new FuncionarioTeste(nome, sobrenome, valorHora));
        
        //A - assert
        Assert.Equal("Valor hora deve ser maior que zero.", exception.Message);
    }

    [Fact]
    public void Funcionario_ValorHora_MaiorQueZero()
    {
        //A - arrange
        var nome = "João";
        var sobrenome = "Silva";
        var valorHora = 10.0;

        //A - act
        var funcionario = new FuncionarioTeste(nome, sobrenome, valorHora);
        
        //A - assert
        Assert.True(funcionario.ValorHora == valorHora);
    }

    [Fact]
    public void Funcionario_Nome_Nome()
    {
        //A - arrange
        var nome = "João";
        var sobrenome = "Silva";
        var funcionario = new FuncionarioTeste(nome, sobrenome, 10.0);

        //A - act
        var nomeCompleto = funcionario.Nome;

        //A - assert
        Assert.True(nomeCompleto == nome);
    }

    [Fact]
    public void Funcionario_Sobrenome_Sobrenome()
    {
        //A - arrange
        var nome = "João";
        var sobrenome = "Silva";
        var funcionario = new FuncionarioTeste(nome, sobrenome, 10.0);

        //A - act
        var nomeCompleto = funcionario.Sobrenome;
        
        //A - assert
        Assert.True(nomeCompleto == sobrenome);
    }
}
