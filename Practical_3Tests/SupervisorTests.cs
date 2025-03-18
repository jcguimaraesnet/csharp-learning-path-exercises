using Practical_3;

namespace Practical_3Tests;

public class SupervisorTests
{
    [Fact]
    public void Supervisor_Turno_Obter()
    {
        //A - arrange
        var nome = "João";
        var sobrenome = "Silva";
        var valorHora = 10.0;
        var turno = Turno.Tarde;

        //A - act
        var supervisor = new Supervisor(nome, sobrenome, valorHora, turno);

        //A - assert
        Assert.True(supervisor.Turno == turno);
    }

    [Fact]
    public void Supervisor_AdicionarDissidio()
    {
        //A - arrange
        var nome = "João";
        var sobrenome = "Silva";
        var valorHora = 10.0;
        var turno = Turno.Tarde;
        var supervisor = new Supervisor(nome, sobrenome, valorHora, turno);

        //A - act
        supervisor.AdicionarDissidio();

        //A - assert
        Assert.True(supervisor.ValorHora == 11.0);
    }
}
