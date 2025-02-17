using System.Drawing;
using System.Globalization;

namespace Classroom;

internal class Program
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
        Colorful.Console.WriteAscii("HAMBURGUERIA", Color.FromArgb(244, 212, 255));
        const double salarioPesquisa = 5_000;

        Dictionary<string, Funcionario> listaFuncionarios = new();

        var opcao = 0;
        do
        {
            Console.Clear();
            Console.WriteLine("1 - Cadastrar funcionário");
            Console.WriteLine("2 - Calcular Folha");
            Console.WriteLine($"3 - Listar funcionários com salário maior que {salarioPesquisa:C}");
            Console.WriteLine("4 - Sair");
            
            Console.WriteLine("Digite a opção desejada:");
            if (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 1 || opcao > 4)
            {
                Console.WriteLine("Opção inválida. Encerrando programa...");
                return;
            }
            switch (opcao)
            {
                case 1:
                    try
                    {
                        CadastrarFuncionario(listaFuncionarios);
                        break;
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"Erro na execução do programa. Erro ocorrido: {ex.Message}");
                        Console.WriteLine("Encerrando o programa...");
                        return;
                    }
                case 2:
                    CalcularFolha(listaFuncionarios);
                    break;
                case 3:
                    PesquisaFuncionarios(listaFuncionarios, salarioPesquisa);
                    break;
                case 4:
                    Console.WriteLine("Saindo do cadastro. Encerrando programa...");
                    break;
            }
        } while (opcao != 4);
    }

    private static void CadastrarFuncionario(Dictionary<string, Funcionario> listaFuncionarios)
    {
        Console.Clear();
        Console.WriteLine("Informe o nome do funcionário:");
        var nome = Console.ReadLine();
        Console.WriteLine("Informe o sobrenome do funcionário:");
        var sobrenome = Console.ReadLine();
        Console.WriteLine("Informe o salário do funcionário:");
        if (!double.TryParse(Console.ReadLine(), out var salario))
        {
            Console.WriteLine("Salário inválido. Encerrando programa...");
            return;
        }
        Console.WriteLine("Digite a data de nascimento do funcionário (dd/mm/yyyy):");
        if (!DateOnly.TryParse(Console.ReadLine(), out var dataNascimento))
        {
            Console.WriteLine("Data de nascimento inválida. Encerrando programa...");
            return;
        }
        Console.WriteLine("Digite o CPF do funcionário:");
        var cpf = Console.ReadLine();
        var funcionario = new Funcionario()
        {
            PrimeiroNome = nome,
            Sobrenome = sobrenome,
            DataNascimento = dataNascimento,
            Salario = salario,
            Cpf = cpf
        };
        listaFuncionarios.Add(cpf, funcionario);
        Console.WriteLine("Funcionário cadastrado com sucesso!");
        Console.WriteLine("Digite qualquer tecla para reiniciar...");
        Console.ReadKey();
    }

    private static void PesquisaFuncionarios(Dictionary<string, Funcionario> listaFuncionarios, double salarioPesquisa)
    {
        Console.Clear();
        Console.WriteLine($"Funcionários com salário maior que {salarioPesquisa:C}");
        foreach (var funcionario in listaFuncionarios.Values.Where(f => f.Salario > salarioPesquisa))
        {
            Console.WriteLine($"Nome: {funcionario.NomeCompleto()} - Salário: {funcionario.Salario:C}");
        }
        Console.WriteLine("Digite qualquer tecla para reiniciar...");
        Console.ReadKey();
    }

    private static void CalcularFolha(Dictionary<string, Funcionario> listaFuncionarios)
    {
        Console.Clear();
        Console.WriteLine("Resumo salários funcionários");
        var totalSalarios = listaFuncionarios.Values.Sum(f => f.Salario);
        Console.WriteLine($"Total salários: {totalSalarios:C}");
        var mediaSalario = listaFuncionarios.Values.Average(f => f.Salario);
        Console.WriteLine($"Média salarial: {mediaSalario:C}");
        var menorSalario = listaFuncionarios.Values.Min(f => f.Salario);
        Console.WriteLine($"Menor salário: {menorSalario:C}");
        var maiorSalario = listaFuncionarios.Values.Max(f => f.Salario);
        Console.WriteLine($"Maior salário: {maiorSalario:C}");
        Console.WriteLine();
        Console.WriteLine("Digite qualquer tecla para reiniciar...");
        Console.ReadKey();
    }
}
