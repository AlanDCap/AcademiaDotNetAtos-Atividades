/*18. Elaborar um programa que apresente o valor de uma potência de uma base qualquer 
elevada a um expoente qualquer, ou seja, NM.*/

int n, potencia; 

Console.WriteLine("Calculadora de potências.\nInforme um número base:");
n = int.Parse(Console.ReadLine());

Console.WriteLine("Agora informe a qual potência o número será elevado:");
potencia = int.Parse(Console.ReadLine());

Console.WriteLine($"{n} elevado a {potencia} é igual a {Math.Pow(n, potencia)}");