//1 - Faça um algoritmo para calcular e mostrar a área de um triângulo a partir dos valores da base e da altura lidos pelo teclado: Área do triangulo = (base * altura) / 2;
//Teste se a base ou a altura digitada não foi igual a zero. 

double area, alturat, baset;

Console.WriteLine("Calcule a área de triângulo.\nDigite a altura");
alturat = double.Parse(Console.ReadLine());
while (alturat < 1)
{
    Console.WriteLine("O número precisa ser maior que zero");
    alturat = double.Parse(Console.ReadLine());
}

Console.WriteLine("Informe o comprimento da base do triângulo");
baset = double.Parse(Console.ReadLine());
while (baset < 1)
{
    Console.WriteLine("O número precisa ser maior que zero");
    baset = double.Parse(Console.ReadLine());
}

area = (baset * alturat) / 2;
Console.WriteLine("A área do triângulo é: " + area);