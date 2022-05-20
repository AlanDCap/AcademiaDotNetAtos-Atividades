//3 - Escrever um algoritmo para ler quatro valores inteiros, calcular a sua média, e escrever na tela os que são superiores à média.

double num1, num2, num3, num4, media;

Console.WriteLine("Descubra os valores que são mais altos que a média deles\nInforme quatro números inteiros:");
num1 = double.Parse(Console.ReadLine());
num2 = double.Parse(Console.ReadLine());
num3 = double.Parse(Console.ReadLine());
num4 = double.Parse(Console.ReadLine());

media = (num1 + num2 + num3 + num4) / 4;

if (num1 > media)
{
    Console.WriteLine("O número " + num1 + " é maior que a média");
}
if (num2 > media)
{
    Console.WriteLine("O número " + num2 + " é maior que a média");
}
if (num3 > media)
{
    Console.WriteLine("O número " + num3 + " é maior que a média");
}
if (num4 > media)
{
    Console.WriteLine("O número " + num4 + " é maior que a média");
}