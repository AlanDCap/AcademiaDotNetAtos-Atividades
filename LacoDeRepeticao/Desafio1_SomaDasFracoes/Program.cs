/*Faça um programa que leia um número inteiro n, inteiro e positivo e mostre a seguinte
soma: S = 1 + 1/2 + 1/3 + 1/4 + 1/5 .... 1/n */

float n;
float soma, total = 0;

Console.Write("Informe um número:");
n = float.Parse(Console.ReadLine());

for (float i = 1; i <= n; i++)
{
    soma = (1 / (i));
    Console.WriteLine(soma);
    total = total + soma;
}
Console.WriteLine(total);