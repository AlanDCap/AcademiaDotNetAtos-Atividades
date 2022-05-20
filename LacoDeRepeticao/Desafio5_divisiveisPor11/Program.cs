/*5.	Escreva um programa em C# que gera números entre 1000 e 1999 e mostra aqueles que divididos
por 11 dão resto 5.*/

List<int> divisiveis= new List<int>();

Console.WriteLine("Veja quais números entre 1000 e 1999 são divisíveis por 11.\nDigite qualquer tecla para continuar.");
Console.ReadKey();

for (int i = 1000; i < 1999; i++)
{
    if (i % 11 == 5)
    {
        Console.WriteLine(i);
    }
}