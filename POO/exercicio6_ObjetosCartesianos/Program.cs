/*#6
Crie uma classe para representar um objeto em um Plano Cartesiano. Todo objeto no plano cartesiano
tem como atributos 'x' e 'y'. Dessa forma, 
a) crie os getters e setter de 'x' e 'y', 
b) o construtor básico e
c) um método para exibir um objeto (x,y).
d) crie um programa em C# que cadastre 'n' objetos em uma lista (List), 
e) um método que exiba os objetos da lista.*/

using exercicio6_ObjetosCartesianos;

List<Objeto> listaObjetos = new List<Objeto>();
string opcao;
int n = 0;

do
{
    Console.Clear();
    Console.WriteLine("MENU");
    Console.WriteLine("1 - Gere uma lista com n objetos");
    Console.WriteLine("2 - Exiba a lista criada");
    Console.WriteLine("3 - Sair");

    Console.Write("Opção: ");
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Gerando a lista\nDigite quantos objetos quer gerar");
            n = int.Parse(Console.ReadLine());
            Util.registrarObj(n, listaObjetos);
            break;

        case "2":
            //listar usuarios;
            Util.exibirLista(listaObjetos);
            break;

        case "3":
            Console.WriteLine("Obrigado por usar o sistema");
            break;

        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
    Console.WriteLine("Pressione algo para continuar!");
    Console.ReadKey();
} while (opcao != "3");