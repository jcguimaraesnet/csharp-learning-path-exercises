namespace Practical_3;

internal class Program
{
    static void Main(string[] args)
    {
        const string IdentificadorCitrico = "Citrico";
        const string IdentificadorNaoCitrico = "Não Citrico";
        Dictionary<string, string> frutas = new();
        List<string> frutasCitricas = ["Laranja", "Limão", "Tangerina"];
        List<string> frutasNaoCitricas = ["Banana", "Maçã", "Pera"];
        frutas.Add(frutasCitricas[0], IdentificadorCitrico);
        frutas.Add(frutasCitricas[1], IdentificadorCitrico);
        frutas.Add(frutasCitricas[2], IdentificadorCitrico);
        frutas.Add(frutasNaoCitricas[0], IdentificadorNaoCitrico);
        frutas.Add(frutasNaoCitricas[1], IdentificadorNaoCitrico);
        frutas.Add(frutasNaoCitricas[2], IdentificadorNaoCitrico);

        frutas.Where(f => f.Value == IdentificadorCitrico)
              .ToList()
              .ForEach(f => Console.WriteLine(f.Key));
    }
}