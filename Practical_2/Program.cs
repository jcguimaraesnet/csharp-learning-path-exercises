namespace Practical_2;

internal class Program
{
    static void Main(string[] args)
    {
        List<string> frutas = ["Banana", "bergamota", "Maçã", "Pera", "Uva"];
        frutas.Where(f => f.StartsWith("B", StringComparison.CurrentCultureIgnoreCase))
              .ToList()
              .ForEach(f => Console.WriteLine(f));
    }
}
