using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Classroom;

internal class Secao
{
    public Secao(string titulo, string resumo)
    {
        Titulo = titulo;
        Resumo = resumo;
    }
    
    public string Titulo { get; private set; }
    public string Resumo { get; private set; }

    public override string ToString()
    {
        return $"Título: {Titulo}\n" +
        $"Ano: {Resumo}";

    }
}
