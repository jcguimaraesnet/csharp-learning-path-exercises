namespace Practical_2;

internal class IMC
{
    public required double Peso { get; init; }
    public required double Altura { get; init; }
    
    public double CalcularIMC() => Peso / (Altura * Altura);
    
    public string Situacao()
    {
        switch (CalcularIMC())
        {
            case < 18.5:
                return "Abaixo do peso";
            case < 24.9:
                return "Peso normal";
            case < 29.9:
                return "Sobrepeso";
            default:
                return "Obesidade";
        }
    }
}
