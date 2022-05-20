/* 6.	Faça um programa que leia um número n e imprima se ele é primo ou não. 
(um número primo tem apenas 2 divisores: 1 e ele mesmo! O número 1 não é primo!!!)*/

int n;
bool prime = true;

Console.Clear();
Console.WriteLine("Verifique se um determinado número é primo.\nDigite um número");
n = int.Parse(Console.ReadLine());

for (int i = 2; i < n / 2; i++)
{
    if (n % i == 0)
    {
        prime = false;
        break;
    }
    else
    {
        prime = true;
    }
}
if (n != 0 && prime == false)
{
    Console.WriteLine($"{n} não é primo");
}
if (n != 0 && prime == true)
{
    Console.WriteLine($"{n} é primo");
}