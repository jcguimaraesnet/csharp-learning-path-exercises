namespace Practical_3;

internal class Program
{
    static void Main(string[] args)
    {
        var numeros = new[] { 1, 2, 3, 4, 5 };
        for (var i = numeros.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(numeros[i]);
        }
    }
}
