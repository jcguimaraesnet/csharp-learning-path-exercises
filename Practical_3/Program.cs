namespace Practical_3;

internal class Program
{
    static void Main(string[] args)
    {
        var fidelidade = new Fidelidade();
        fidelidade.AdicionarTransacao("Compra no cartão", 10);
        fidelidade.AdicionarTransacao("Compra de vôo", 20);
        fidelidade.ResgatarPontos(10);
        fidelidade.ConsultarExtrato();
    }
}