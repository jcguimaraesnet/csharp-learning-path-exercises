namespace Classroom;

public enum ClasseRenda
{
    E = 1_500,
    D = 5_000,
    C = 10_000,
    B = 20_000,
    A = 20_001
}

public static class ClasseRendaExtensions
{
    public static bool ElegivelBolsaFamilia(this ClasseRenda classeRenda)
        => classeRenda == ClasseRenda.D || classeRenda == ClasseRenda.E;
}