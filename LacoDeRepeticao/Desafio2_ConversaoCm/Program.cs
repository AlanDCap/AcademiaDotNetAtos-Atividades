/*2.	Imprima uma tabela de conversão de polegadas para centímetros, de 1 a 20. Considere que
Polegada = Centímetro * 2,54.*/

float polConv;

Console.WriteLine("Tabela de conversão de polegadas em centímetros:\nPressione qualquer tecla para exibir");
Console.ReadKey();

for (int i = 1; i <= 20; i++)
{
    polConv = (float)(2.54 * i);
    Console.WriteLine($"{i} pol = {polConv} cm");
}