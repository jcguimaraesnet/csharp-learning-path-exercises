namespace Practical_3;

internal class Transacao
{
    public const double cambioDolarReal = 5.80;

    public Transacao(string descricao, double valor)
    {
        Valor = valor;
        Descricao = descricao;
    }

    public string Descricao { get; }
    public double Valor { get; }

    public int CalcularPontos()
    {
        return (int)(Valor/cambioDolarReal);
    }
}
