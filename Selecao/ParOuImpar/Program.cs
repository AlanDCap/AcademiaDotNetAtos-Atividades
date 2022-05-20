//2 - Faça um algoritmo para ler um número e verificar se ele é par ou ímpar.

int num;

Console.WriteLine("Descubra se um número é par ou ímpar\nDigite o número: ");
num = int.Parse(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine("O número " + num + " é par!");
}
else
    Console.WriteLine("O número " + num + " é ímpar");