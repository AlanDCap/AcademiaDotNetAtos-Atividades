/*9. Faça um programa em VS para Ler a quantidade de filhos de cada uma das 30 pessoas que visitaram 
o zoológico num determinado dia, imprimindo:
Quantas pessoas tem entre 1 e 3 filhos.
Quantas pessoas tem entre 4 e 7 filhos.
Quantas pessoas tem mais de 8 filhos.
Quantas pessoas não tem filhos.*/

int qtdFilhos;
List<int> filhos1a3 = new List<int>();
List<int> filhos4a7 = new List<int>();
List<int> filhos8 = new List<int>();
List<int> filhos0 = new List<int>();



for (int i = 30; i != 0; i--)
{
    Console.Clear();
    Console.WriteLine("Informe a quantidade de filhos que tem:");
    qtdFilhos = int.Parse(Console.ReadLine());
    if (qtdFilhos > 0 && qtdFilhos < 4)
        filhos1a3.Add(qtdFilhos);
    else if (qtdFilhos > 3 && qtdFilhos < 8)
        filhos4a7.Add(qtdFilhos);
    else if (qtdFilhos > 7)
        filhos8.Add(qtdFilhos);
    else if (qtdFilhos == 0)
        filhos0.Add(qtdFilhos);
    else
    {
        Console.WriteLine("Valor inválido, digite um valor inteiro positivo.");
        qtdFilhos = int.Parse(Console.ReadLine());
    }
}
Console.WriteLine($"A quantidade de pessoas sem filhos é {filhos0.Count}, a quantidade de pessoas com 1 a 3 filhos é {filhos1a3.Count}, com 4 a 7 filhos é {filhos4a7.Count}, e com mais de 8 filhos é {filhos8.Count}");