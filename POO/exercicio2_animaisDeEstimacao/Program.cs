/* Crie um programa em C# no qual o usuário deverá informar o nome e o tipo de cinco animais de estimação. 
O programa deverá exibir na tela para o usuário quantos Cachorros, Gatos e Peixes foram informados.

Regras que deverão ser seguidas para a implementação do programa:

Os únicos tipos de animais válidos são Cachorro, Gato, Peixe.
Caso seja informado um tipo diferente o programa deverá repetir até o usuário digitar um tipo válido.
É obrigatório criar uma classe para representar o Animal.
A classe deverá possuir dois dados privados (propriedades) para representar as características do animal.
A classe deverá possuir métodos de acesso (propriedade getter e setter) para permitir que o usuário armazene/leia 
os dados dos dois dados privados (propriedades).*/

using exercicio2_animaisDeEstimacao;

List<Animal> animals = new List<Animal>();
int contagem = 1;
string nome, tipo;


//recebimento os dados do usuário referentes à classe Animal
    Console.WriteLine("Informe o nome e o tipo de 5 animais de estimação\nPressione qualquer tecla para iniciar");
    Console.ReadKey();
do
{
    Console.Clear();
    Console.WriteLine($"Informe o nome do {contagem}º animal");
    nome = Console.ReadLine().ToUpper();


    //validação dos valores inseridos.
    do
    {
        Console.WriteLine($"Informe o tipo do {contagem}º animal");
        tipo = Console.ReadLine().ToUpper();

    } while (tipo != "CACHORRO" && tipo != "GATO" && tipo != "PEIXE");
    
    animals.Add(new Animal(nome, tipo));
    contagem++;

} while (animals.Count < 5);

//Contagem e listagem dos tipos de animais
int qtdcachorro = 0, qtdgato = 0, qtdpeixe = 0;
foreach (Animal i in animals)
{

    if (i.Tipo == "CACHORRO")
    {
        qtdcachorro++;
    }

    if (i.Tipo == "GATO")
    {
        qtdgato++;
    }
    if (i.Tipo == "PEIXE")
    {
        qtdpeixe++;
    }
}
Console.WriteLine($"A quantide de cachorros é {qtdcachorro}, a de gatos é {qtdgato} e a de peixes é {qtdpeixe}");
