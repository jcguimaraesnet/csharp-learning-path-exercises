namespace Practical_2;

internal class IMC
{
    public double Peso { get; set; }
    public double Altura { get; set; }
    public double CalcularIMC()
    {
        return Peso / (Altura * Altura);
    }
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
