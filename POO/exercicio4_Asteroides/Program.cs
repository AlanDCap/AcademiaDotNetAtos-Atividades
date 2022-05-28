/*#4
Imagine um jogo com asteroides e uma nave de ataque, que deve destruir os asteróides que voam em todas as direções. 

Dessa forma, crie um programa em C# que represente uma lista de asteroides que deveriam ser 'inseridos' no jogo. 
Para isso, faça uma classe que contenha os atributos (privados) 
        posição x, posição y (do asteroide em um plano cartesiano), 
        tamanho do asteroide (1 a 10), 
        velocidade do asteroide (1 a 5) 
        e energia (1 a 5). 
Para esses atributos privados, gerar os métodos de acesso (propriedades getter e setter). 

Além disso, implementar 3 construtores (sobrecarga): 
        um vazio, 
        outro passando todos os parâmetros de um objeto tipo Asteroide, 
        e um terceiro que constrói um asteroide com posição x e posição y.

O programa principal (main) deve conter a lista de Asteroides, preenchida pelo usuário. 
Nesse programa principal, construir um método de classe que exiba todos os asteróides da lista.*/

using exercicio4_Asteroides;
string opcao;
int t, v, e, px, py;
List<Asteroide> asteroidelist = new List<Asteroide>();

Console.WriteLine("Jogo: Invasor do Espaço\n\nComece criando asteroides!\nPressione qualquer tecla para iniciar");
Console.ReadKey();

do
{
    Console.Clear();
    Console.WriteLine("1 - Inserir asteroide com todos os parâmetros");
    Console.WriteLine("2 - Inserir um asteroide apenas passando os parametros de posição (os demais serão aleatórios)");
    Console.WriteLine("3 - Exibir os asteroides");
    Console.WriteLine("4 - Sair");
    Console.Write("Opção: ");
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.Write("Informe o tamanho do asteroide (1 a 10):");
            t = int.Parse(Console.ReadLine());
            Console.Write("Informe a velocidade do asteroide (1 a 5):");
            v = int.Parse(Console.ReadLine());
            Console.Write("Informe a energia do asteroide (1 a 5):");
            e = int.Parse(Console.ReadLine());
            Console.Write("Informe a posição x do asteroide:");
            px = int.Parse(Console.ReadLine());
            Console.Write("Informe a posição y do asteroide:");
            py = int.Parse(Console.ReadLine());
            asteroidelist.Add(new Asteroide(t, v, e, px, py));
            break;

        case "2":
            
            Console.Write("Informe a posição x do asteroide:");
            px = int.Parse(Console.ReadLine());
            Console.Write("Informe a posição y do asteroide:");
            py = int.Parse(Console.ReadLine());
            asteroidelist.Add(new Asteroide(px, py));
            break;

        case "3":
            
            if (asteroidelist.Count == 0)
            {
                Console.WriteLine("Lista vazia!");
            } else
            {
            Console.WriteLine("Exibindo asteroides");
                foreach (Asteroide i in asteroidelist)
                {
                    Console.WriteLine($"Asteroide de tamanho {i.Tamanho}, velocidade {i.Velocidade}, energia {i.Energia}, posicionado em x = {i.PosicaoX}, y = {i.PosicaoY}");
                }
                Console.WriteLine("Pressione qualquer tecla para continuar");
                Console.ReadKey();
            }
            break;

        case "4":
            break;

        default:
            Console.WriteLine("Opção inválida");
            Console.WriteLine("Pressione qualquer tecla para continuar");
            Console.ReadKey();
            break;
    }
} while (opcao != "4");