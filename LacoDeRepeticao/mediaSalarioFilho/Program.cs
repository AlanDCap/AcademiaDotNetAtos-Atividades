/*19. A prefeitura de uma cidade fez uma pesquisa entre seus habitantes, 
coletando dados sobre o salário e número de filhos. A prefeitura deseja saber: 
 
a) média do salário da população;
b) média do número de filhos;
c) maior salário;
d) percentual de pessoas com salário até R$ 100,00.
O final da leitura de dados se dará com a entrada de um salário negativo.*/

float salario, percentual, menosQ100 = 0, maisQ100 = 0;
int qtdFilhos;
List<float> listaSalario = new List<float>();
List<int> listaQtdFilhos = new List<int>();


do
{
    Console.Clear();
    Console.WriteLine("Informe seu salário");
    salario = float.Parse(Console.ReadLine());
    if (salario > 0)
        listaSalario.Add(salario);
    else
    {
        listaSalario.Remove(salario);
        break;
    }

    Console.WriteLine("Informe quantos filhos tem");
    qtdFilhos = int.Parse(Console.ReadLine());
    listaQtdFilhos.Add(qtdFilhos);
} while (salario > 0);

Console.WriteLine($"A média de salário da população é {listaSalario.Average()}");
Console.WriteLine($"A média de quantidade de filhos da população é {listaQtdFilhos.Average()}");
Console.WriteLine($"O maior salário recebido é de {listaSalario.Max()}");

for (int i = 0; i < listaSalario.Count() - 1; i++)
{
    if (listaSalario[i] <= 100)
            menosQ100++;
    else 
        maisQ100++;
    
}
if ((menosQ100 / maisQ100) != float.NaN)
{
    percentual = (menosQ100 / maisQ100) * 100;
    
} else
{
    percentual = 0;
}

Console.WriteLine(percentual);
Console.WriteLine(menosQ100);
Console.WriteLine(menosQ100);
Console.WriteLine($"{Math.Round(percentual, 2)}% da população tem salário de até 100 reais.");