/* 4 . Faça um algoritmo que leia uma lista de números inteiros positivos terminada pelo número 0 (zero). 
Ao final, o algoritmo deve mostrar a média aritmética de todos os números lidos (excluindo o zero).*/

List<int> inteiros = new List<int>();
List<int> terminadosEm10 = new List<int>();
int n;

do
{
    Console.Clear();
    Console.WriteLine("Digite números inteiros\nDigite zero para encerrar");
    n = int.Parse(Console.ReadLine());
    inteiros.Add(n);
    if (n % 10 == 0)
    {
        terminadosEm10.Add(n);
    }

} while (n != 0);

inteiros.Remove(0);
terminadosEm10.Remove(0);

//Console.WriteLine(inteiros.Count);
//Console.WriteLine(terminadosEm10.Count);

Console.WriteLine($"A média de todos os números inteiros é {inteiros.Average()}");
Console.WriteLine($"A média de todos os números inteiros terminado em 0 é {terminadosEm10.Average()}");