using Practical_2;

namespace Practical_2Tests;

public class GarconTests
{
    [Fact]
    public void Garcon_Mesas_Obter()
    {
        //A - arrange
        var nome = "João";
        var sobrenome = "Silva";
        var valorHora = 10.0;
        var mesas = new List<int> { 1, 2, 3 };
        var garcon = new Garcon(nome, sobrenome, valorHora, mesas);

        //A - act
        var mesasObtidas = garcon.Mesas;

        //A - assert
        Assert.True(mesas.SequenceEqual(mesasObtidas));
    }

}
