/* 
Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre quatro números quaisquer.*/

Console.WriteLine("Exercício 2: Escreva um programa em C# e no Visual Studio\n" + "para calcular a média aritmética entre\n" + "quatro números quaisquer.");

float numero1;
float numero2;
float numero3; 
float numero4;
float media_aritmetica;

Console.WriteLine("Informe o primeiro número");
numero1 = float.Parse(Console.ReadLine());

Console.WriteLine("Informe o segundo número");
numero2 = float.Parse(Console.ReadLine());

Console.WriteLine("Informe o terceiro número");
numero3 = float.Parse(Console.ReadLine());

Console.WriteLine("Informe o quarto número");
numero4 = float.Parse(Console.ReadLine());

media_aritmetica = (numero1 + numero2 + numero3 + numero4) /4;

Console.WriteLine("A média entre os quatro valores é: " + media_aritmetica);