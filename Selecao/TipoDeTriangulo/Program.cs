/*17 - Faça um algoritmo que leia o tamanho dos lados de um triangulo (lado a, b e c), e então diga se esses lados podem ou não formar um triangulo. 
 * Para que os lados formem um triângulo, todos os lados devem ser menores ou iguais a soma dos outros dois lados. 
 * Caso os lados formem um triangulo, diga se o mesmo é equilátero (todos os lados iguais), 
 * isoceles (somente 2 lados são iguais) 
 * ou escaleno (os 3 lados são diferentes)*/


double lado1, lado2, lado3;

Console.WriteLine("Descubra a classificação de um triângulo segundo o comprimento dos seus lados.\nDigite a seguir o comprimento de cada lado.");
lado1 = double.Parse(Console.ReadLine());
lado2 = double.Parse(Console.ReadLine());
lado3 = double.Parse(Console.ReadLine());

while ((lado1 + lado2) < lado3 || (lado1 + lado3) < lado2 || (lado3 + lado2) < lado1)
{
    Console.WriteLine("Os valores inseridos não são válidos para formar um triângulo. Digite novamente");
    lado1 = double.Parse(Console.ReadLine());
    lado2 = double.Parse(Console.ReadLine());
    lado3 = double.Parse(Console.ReadLine());
}

if ((lado1 == lado2) && lado2 == lado3)
    Console.WriteLine("Este triângulo é equilátero");

else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
    Console.WriteLine("Este triângulo é isóceles");
else
    Console.WriteLine("Este triângulo é escaleno");