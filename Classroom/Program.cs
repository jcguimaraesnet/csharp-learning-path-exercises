namespace Classroom;

internal class Program
{
    public delegate int Operacao(int x, int y);
    public delegate void Operacao3(int x, int y);
    public delegate void Callback(int result);

    static void Main(string[] args)
    {
        //exemplo 1
        Operacao soma = Somar;
        Operacao multiplicacao = Multiplicar;

        var resultado1 = soma(5, 3);
        Console.WriteLine($"Resultado da soma: {resultado1}");
        var resultado2 = multiplicacao(5, 3);
        Console.WriteLine($"Resultado da multiplicação: {resultado2}");

        //exemplo 2
        ExecutarOperacao(5, 3, soma);
        ExecutarOperacao(5, 3, multiplicacao);

        //exemplo 3
        Operacao3 multiplasOperacoes = Somar3;
        multiplasOperacoes += Multiplicar3;
        multiplasOperacoes(5, 3);

        //exemplo 4
        Somar4(5, 3, Imprimir);
        Multiplicar2(5, 3, Imprimir);

        //exemplo 5
        Func<int,int,int> soma5 = Somar;
        Func<int, int, int> multiplicacao5 = Multiplicar;

        var resultado5 = soma5(5, 3);
        Console.WriteLine($"Resultado da soma5: {resultado5}");
        var resultado6 = multiplicacao5(5, 3);
        Console.WriteLine($"Resultado da multiplicação5: {resultado6}");

        //exemplo 6
        Action<int, int> multiplasOperacoes2 = Somar3;
        multiplasOperacoes2 += Multiplicar3;
        multiplasOperacoes2(5, 3);

        //exemplo final
        var jornal = new Jornal("Folha de São Paulo", 2021, "Folha de São Paulo", new DateOnly(2021, 1, 5), "São Paulo");
        var revista = new Revista("Superinteressante", 2021, "Abril", 1, "1234-5678");
        var livro = new Livro("O Senhor dos Anéis", 1954, "Martins Fontes", "J.R.R. Tolkien", "978-0-395-19395-7");

        var biblioteca = new Biblioteca("Biblioteca Alberto Einstein", "Centro / RJ");
        biblioteca.AdicionarPublicacao(jornal);
        biblioteca.AdicionarPublicacao(revista);
        biblioteca.AdicionarPublicacao(livro);

        biblioteca.ExibirPublicacoes(Console.WriteLine);
        biblioteca.ExibirPublicacoes(ImprimirPersonalizado);
    }

    static void ImprimirPersonalizado(string mensagem)
    {
        Console.BackgroundColor = ConsoleColor.Green;
        Console.WriteLine(mensagem);
        Console.BackgroundColor = ConsoleColor.Black;
    }

    static int Somar(int x, int y)
    {
        return x + y;
    }

    static int Multiplicar(int x, int y)
    {
        return x * y;
    }

    static void ExecutarOperacao(int x, int y, Operacao operacao)
    {
        var resultado = operacao(x, y);
        Console.WriteLine($"Resultado da operação: {resultado}");
    }

    static void Somar3(int x, int y)
    {
        var resultado = x + y;
        Console.WriteLine($"Resultado da operação3: {resultado}");
    }

    static void Multiplicar3(int x, int y)
    {
        var resultado = x * y;
        Console.WriteLine($"Resultado da operação3: {resultado}");
    }

    static void Imprimir(int resultado)
    {
        Console.WriteLine($"Resultado da operação4: {resultado}");
    }

    static void Somar4(int x, int y, Callback callback)
    {
        var resultado = x + y;
        callback(resultado);
    }

    static void Multiplicar2(int x, int y, Callback callback)
    {
        var resultado = x * y;
        callback(resultado);
    }
}
