namespace Practical_4;

internal class Program
{
    static void Main(string[] args)
    {
        List<int> numeros = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var numeroImpares = numeros.Where(n => n % 2 != 0).ToList();

        //exemplo com foreach com expressão lambda
        numeroImpares.ForEach(numeroImpares => Console.WriteLine(numeroImpares));

        //exemplo com foreach tradicional
        //foreach (var numero in numeroImpares)
        //{
        //    Console.WriteLine(numero);
        //}
    }
}
