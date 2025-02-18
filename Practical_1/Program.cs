namespace Practical_1;

internal class Program
{
    static void Main(string[] args)
    {
        List<Funcionario> listaFuncionarios = new();

        var opcao = 0;
        do
        {
            Console.Clear();
            Console.WriteLine("1 - Cadastrar funcionário");
            Console.WriteLine("2 - Aumentar Salário de todos os funcionários");
            Console.WriteLine("3 - Sair");

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
                    AumentarSalario(listaFuncionarios);
                    break;
                case 3:
                    Console.WriteLine("Saindo do cadastro. Encerrando programa...");
                    break;
            }
        } while (opcao != 3);


        Console.WriteLine("Obrigado por utilizar nosso sistema de caixa!");
    }

    private static void CadastrarFuncionario(List<Funcionario> listaFuncionarios)
    {
        Console.Clear();
        Console.WriteLine("Informe o nome do funcionário:");
        var nome = Console.ReadLine();
        Console.WriteLine("Informe a opção de cargo do funcionário (0 - Caixa, 1 - Garcom, 2 - Gerente):");
        if (!int.TryParse(Console.ReadLine(), out var opcaoCargo) || opcaoCargo < 0 || opcaoCargo > 2)
        {
            Console.WriteLine("Opção de cargo inválida. Encerrando programa...");
            return;
        }
        Console.WriteLine("Informe o salário do funcionário:");
        if (!double.TryParse(Console.ReadLine(), out var salario))
        {
            Console.WriteLine("Salário inválido. Encerrando programa...");
            return;
        }
        listaFuncionarios.Add(new Funcionario(nome, (Cargo)opcaoCargo, salario));
        Console.WriteLine("Funcionário cadastrado com sucesso!");
        Console.WriteLine("Digite qualquer tecla para reiniciar...");
        Console.ReadKey();
    }

    private static void AumentarSalario(List<Funcionario> listaFuncionarios)
    {
        listaFuncionarios.ForEach(f => { 
            f.AumentarSalario();
            Console.WriteLine($"Nome: {f.Nome} - Salário: {f.Salario:C}");
        });

        Console.WriteLine();
        Console.WriteLine("Digite qualquer tecla para reiniciar...");
        Console.ReadKey();
    }
}
