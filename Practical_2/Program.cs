namespace Practical_2;

internal class Program
{
    static void Main(string[] args)
    {
        var cartao = new CartaoCredito();
        cartao.AdicionarTransacao("Compra de celular", 1_000);
        cartao.AdicionarTransacao("Compra de notebook", 2_000);
        cartao.ConsultarFatura();
    }
}
