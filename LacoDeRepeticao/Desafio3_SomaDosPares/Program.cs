/*3.	Dado um limite inferior e superior, calcule a soma de todos os números pares contidos
nesse intervalo. */

int nInferior, nSuperior, soma = 0;

Console.WriteLine("Descubra a soma dos números pares em um certo intervalo de números.\nInforme o número inferior:");
nInferior = int.Parse(Console.ReadLine());

Console.WriteLine("Agora informe o número superior");
nSuperior = int.Parse(Console.ReadLine());

for (int i = nInferior; i < nSuperior; i++)
{
    if (i % 2 == 0)
    {
        soma = soma + i;
    }
}
Console.WriteLine($"A soma dos números pares entre {nInferior} e {nSuperior} é {soma}");