namespace Classroom;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hamburgueria - Cadastro de Funcionários");

        Console.WriteLine("Informe o nome do funcionário:");
        var nome = Console.ReadLine();
        
        Console.WriteLine("Informe o sobrenome do funcionário:");
        var sobrenome = Console.ReadLine();

        Console.WriteLine("Informe o salário do funcionário:");
        if (!double.TryParse(Console.ReadLine(), out double salario))
        {
            Console.WriteLine("Salário inválido. Programa encerrado.");
            return;
        }

        Console.WriteLine("Informe a data de nascimento do funcionário:");
        if (!DateOnly.TryParse(Console.ReadLine(), out DateOnly dataNascimento))
        {
            Console.WriteLine("Data de nascimento inválido. Programa encerrado.");
            return;
        }

        string classeRenda;
        switch (salario)
        {
            case <= 1_500:
                classeRenda = "E";
                break;
            case <= 5_000:
                classeRenda = "D";
                break;
            case <= 10_000:
                classeRenda = "C";
                break;
            case <= 20_000:
                classeRenda = "B";
                break;
            default:
                classeRenda = "A";
                break;
        }

        Console.WriteLine($"Nome completo do funcionário é: {nome.ToUpper()} {sobrenome.ToUpper()}");
        Console.WriteLine($"Salário do funcionário é: {salario:C}");
        const int qtdeHorasMes = 160;
        Console.WriteLine($"Valor hora do funcionário é: {(salario/qtdeHorasMes):C}");
        Console.WriteLine($"Data de nascimento do funcionário é: {dataNascimento:dd/MM/yyyy}");

        if (dataNascimento.AddYears(18) > DateOnly.FromDateTime(DateTime.Now))
        {
            Console.WriteLine("Funcionário é um menor aprendiz");
        }

        Console.WriteLine($"Classe de renda do funcionário é: {classeRenda}");
    }
}
