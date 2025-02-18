namespace Practical_2;

internal class Transacao
{
    public Transacao(string descricao, double valor)
    {
        Valor = valor;
        Descricao = descricao;
    }

    public string Descricao { get; }
    public double Valor { get; }
}
