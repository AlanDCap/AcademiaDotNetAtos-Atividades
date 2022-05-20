/*12. Apresentar o total da soma dos cem primeiros números inteiros.*/


int soma = 0;

Console.WriteLine("Descubra a soma dos números inteiros até 100.\nPressione qualquer tecla para exibir o resultado");
Console.ReadKey();

for (int i = 1; i < 101; i++)
{
    soma = soma + i;
}
Console.WriteLine(soma);

/*13. Elaborar um programa que apresente o somatório dos valores pares existentes 
entre 1 e 500.*/


int soma500 = 0;

Console.WriteLine("Descubra a soma dos números inteiros pares até 500.\nPressione qualquer tecla para exibir o resultado");
Console.ReadKey();

for (int i = 1; i < 501; i++)
{
    if (i % 2 == 0)
    soma500 = soma500 + i;
}
Console.WriteLine(soma500);