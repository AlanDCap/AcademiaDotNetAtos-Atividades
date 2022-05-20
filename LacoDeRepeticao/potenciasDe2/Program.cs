/* 14.Mostrar as potências de 2 variando de 0 a 10.*/
int potencias2;

Console.WriteLine("Veja quais são as potências de 2 de 0 a 10\nPressione qualquer tecla para prosseguir");
Console.ReadKey();

for (int i = 0; i < 11; i++)
{
    Console.Write($"2 elevado a {i} é: {Math.Pow(2, i)}\n");
}