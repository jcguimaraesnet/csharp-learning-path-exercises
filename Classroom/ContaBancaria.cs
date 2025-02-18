namespace Classroom;

internal class ContaBancaria
{
    private const double limiteChequeEspecial = 500;
    public double Saldo { get; private set; }

    public ContaBancaria(double saldoInicial)
    {
        Saldo = saldoInicial;
    }

    public void Depositar(double valor)
    {
        if (valor <= 0)
        {
            throw new ArgumentException("Valor do depósito deve ser maior que zero.");
        }
        Saldo += valor;
    }

    public void Sacar(double valor)
    {
        if (valor <= 0)
        {
            throw new ArgumentException("Valor do saque deve ser maior que zero.");
        }

        if (valor > Saldo + limiteChequeEspecial)
        {
            throw new ArgumentException("Saldo insuficiente.");
        }
        Saldo -= valor;
    }
}
