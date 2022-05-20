/*6. Faça um programa em VS que solicite ao o usuário que informe a idade e valide a entrada de dados, 
ou seja, repita a leitura até que ela esteja correta (maior do que zero). 
Ao final, mostre a idade digitada.*/

int idade;

Console.Write("Insira sua idade:");
idade = int.Parse(Console.ReadLine());

while (idade <= 0)
{
    Console.Clear();
    Console.Write("O número precisa ser maior que zero.\nInsira sua idade:");
    idade = int.Parse(Console.ReadLine());
}