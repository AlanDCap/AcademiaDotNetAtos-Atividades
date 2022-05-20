
Console.WriteLine("Exercício 1");

// 1) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre dois números quaisquer.

Console.WriteLine("Escreva um programa em C# e no Visual\n" + "Studio para calcular a média aritmética\n" + "entre dois números quaisquer");

float numero1;
float numero2;
float media_aritmetica;

Console.Write("Digite um número qualquer: ");
numero1 = float.Parse(Console.ReadLine());

Console.Write("Digite um segundo número qualquer: ");
numero2 = float.Parse(Console.ReadLine());

media_aritmetica = (numero2 + numero1) / 2;

Console.WriteLine("A média aritmética dos valores é: " + media_aritmetica);