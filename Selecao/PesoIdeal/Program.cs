/*13 - Tendo como dado de entrada a altura (h) de uma pessoa, construa um programa no VS que calcule 
seu peso ideal, utilizando as seguintes fórmulas:
Para homens: (72.7 * h) - 58
Para mulheres: (62.1 * h) - 44.7*/

int sexo;
double altura, pesoIdeal;

Console.WriteLine("Verifique seu peso ideal.\n Primeiramente, informe seu sexo.\n1.Masculino\n2.Feminino");
sexo = int.Parse(Console.ReadLine());

while (sexo < 1 || sexo > 2)
{
    Console.WriteLine("Número inválido, digite novamente.\n1.Masculino\n2.Feminino");
    sexo = int.Parse(Console.ReadLine());
}

Console.WriteLine("Agora informe sua altura em metros");
altura = double.Parse(Console.ReadLine());

if (sexo == 1)
{
    pesoIdeal = (72.7 * altura) - 58;
    Console.WriteLine("Seu peso ideal é: " + Math.Round(pesoIdeal, 2) + " quilogramas");
}

else if (sexo == 2)
{
    pesoIdeal = (62.1 * altura) - 44.7;
    Console.WriteLine("Seu peso ideal é: " + Math.Round(pesoIdeal, 2) + " quilogramas");
}