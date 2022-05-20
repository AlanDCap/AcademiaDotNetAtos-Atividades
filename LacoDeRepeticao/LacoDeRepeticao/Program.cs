int i;
//listagem crescente de um em um
Console.WriteLine("Lista dos números até 10");
for (i = 0; i < 11; i++)
    //i=i+i;
    Console.WriteLine(i);

//listagem descrescente de um em um
Console.WriteLine("\nLista dos números de 20 a 5");
for (i = 20; i > 4; i--)
    //i=i+i;
    Console.WriteLine(i);

//listagem de números entre dois valores
int inicial, final;
Console.WriteLine("\nListe todos os valores entre dois números.\nInforme um valor inicial e final.");
inicial = int.Parse(Console.ReadLine());
final = int.Parse(Console.ReadLine());

Console.WriteLine("\nLista dos números de um valor inicial até um valor final.");
if (inicial < final)
{
    for (i = inicial; i <= final; i++)
        Console.WriteLine(i);
} else
{
    for (i = inicial; i >= final; i--)
        Console.WriteLine(i);
}
int x;

//listagem com incrementos determinados
Console.WriteLine("\nConte os números até 100, em incrementos específicos");
x = int.Parse(Console.ReadLine());

Console.WriteLine("\nLista de números em incrementos determinados");
for (i = x; i <= 100; i = i + x)
    Console.WriteLine(i);

//listagem dos múltiplos de um número
Console.WriteLine("\nDescubra os múltiplos de um determinado número até 100");

int multiplos;
multiplos = int.Parse(Console.ReadLine());

Console.WriteLine($"\nLista dos múltiplos de {multiplos} até 100");
for (i = multiplos; i <= 100; i = i + multiplos)
    Console.WriteLine(i);

//escrita de tabuada
int tabuada;

Console.WriteLine("\nVerifique a tabuada de um determinado número");
tabuada = int.Parse(Console.ReadLine());

Console.WriteLine($"\nTabuada do {tabuada}");
for (i = 1; i <= 10; i++)
    Console.WriteLine($"\n{tabuada} x {i} = " + i * tabuada);