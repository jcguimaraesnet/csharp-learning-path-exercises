using System.Drawing;
using System.Globalization;

namespace Classroom;

internal class Program
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
        Colorful.Console.WriteAscii("HAMBURGUERIA", Color.FromArgb(244, 212, 255));

        var conta = new ContaBancaria(500);
        Console.WriteLine($"Saldo inicial: {conta.Saldo:C}");
        conta.Depositar(500);
        conta.Sacar(1200);
        Console.WriteLine($"Saldo final: {conta.Saldo:C}");
    }
}
