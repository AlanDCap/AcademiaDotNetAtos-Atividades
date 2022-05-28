/*Construir um programa em VS que gerencie veículos em garagem. O programa deve ter um menu de operação. Os dados dos
veículos devem ser persistidos em arquivo e manipulados em uma lista dinâmica em memória.
Os dados dos veículos são : string placa; DateTime dataHoraEntrada.

MENU
1 - Cadastrar veículo entrando na garagem
2 - Exibir veículos cadastrados
3 - Sair
Opção: 

Observações: Criar a classe Veiculo (placa, dataHoraEntrada); usar as classes List, StreamReader, StreamWriter, DateTime
Use como base de dados o arquivo 'garagem.dat'.*/

using desafioCadastrodePlacas;
List<Carro> listaCarros = new List<Carro>();
string opcao, placa;

Util.carregarListas(listaCarros);

do
{
    Console.Clear();
    Console.WriteLine("MENU");
    Console.WriteLine("1 - Registrar uma entrada");
    Console.WriteLine("2 - Listar registros de entrada");
    Console.WriteLine("3 - Sair");

    Console.Write("Opção: ");
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Util.registrarEntrada("Registrando entrada", listaCarros);
            break;

        case "2":
            Util.exibirLista("Exibindo lista de entradas", listaCarros);

            break;
        case "3":
            break;

        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
    Console.WriteLine("Pressione algo para continuar");
    Console.ReadKey();

} while (opcao != "3");