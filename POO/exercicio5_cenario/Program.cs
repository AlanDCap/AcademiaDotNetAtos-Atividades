/*#5
Crie uma classe para representar um item de cenário, com os atributos privados de:
    * descrição (string), 
    * data de criação (date - https://docs.microsoft.com/en-us/dotnet/api/system.datetime.date?view=net-6.0) e
    * altura (float). 

a) Crie os métodos públicos necessários para sets e gets
b) o construtor básico
c) crie um método para imprimir todos dados de um item de cenário
d) crie um método para calcular há quanto tempo o item foi criado 
e) crie um programa em C# para testar a classe criada.*/

using exercicio5_cenario;
string opcao;
List<Cenario> listaCenarios = new List<Cenario>();

do
{
    Console.Clear();
    Console.WriteLine("MENU");
    Console.WriteLine("1 - Inserir um item de cenário");
    Console.WriteLine("2 - Listar itens do cenário");
    Console.WriteLine("3 - Verificar há quanto tempo o item foi criado");
    Console.WriteLine("4 - Sair");

    Console.Write("Opção: ");
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Util.criarCenario(listaCenarios);
            break;
        case "2":
            Util.listarCenarios(listaCenarios);
            Console.WriteLine(listaCenarios.Count);
            break;
        case "3":
            Util.compararDataCriacao(listaCenarios);
            break;

        case "4":
            Console.WriteLine("Obrigado por usar o sistema");
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
    Console.WriteLine("Pressione qualquer tecla para continuar");
    Console.ReadKey();
} while (opcao != "4");