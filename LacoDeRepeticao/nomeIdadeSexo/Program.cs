/*10. Ler nome, sexo e idade de 50 pessoas e após imprimir:
Número de pessoas do sexo masculino.
Número de pessoas do sexo feminino.
Número de pessoas com idade inferior a 30 anos.
Número de pessoas com idade superior a 60 anos.
Média de idade das mulheres.*/

List<string> listaNome= new List<string>();
List<int> listaIdadeMasc = new List<int>();
List<int> listaIdadeFem = new List<int>();
List<int> listaIdade30 = new List<int>();
List<int> listaIdade60= new List<int>();

for (int i = 0; i < 5; i++)
{
    Console.Clear();
    Console.WriteLine("Informe seu nome:");
    listaNome.Add(Console.ReadLine().ToUpper());

    Console.WriteLine("Informe seu sexo (M/F): ");
    
    switch (Console.ReadLine().ToUpper())
    {
        case "M":
            Console.WriteLine("Informe sua idade");
            listaIdadeMasc.Add(int.Parse(Console.ReadLine()));
            break;
        
        case "F":
            Console.WriteLine("Informe sua idade");
            listaIdadeFem.Add(int.Parse(Console.ReadLine()));
            break;
    }
}

for (int i = 0; i < listaIdadeMasc.Count; i++)
{
    if (listaIdadeMasc[i] < 30)
    {
        listaIdade30.Add(listaIdadeMasc[i]);
    }
}
for (int i = 0; i < listaIdadeFem.Count; i++)
{
    if (listaIdadeFem[i] < 30)
    {
        listaIdade30.Add(listaIdadeFem[i]);
    }
}
for (int i = 0; i < listaIdadeMasc.Count; i++)
{
    if (listaIdadeMasc[i] > 60)
    {
        listaIdade60.Add(listaIdadeMasc[i]);
    }
}
for (int i = 0; i < listaIdadeFem.Count; i++)
{
    if (listaIdadeFem[i] > 60)
    {
        listaIdade60.Add(listaIdadeFem[i]);
    }
}


Console.WriteLine($"O número de pessoas do sexo masculino é {listaIdadeMasc.Count}, o número de pessoas do sexo feminino é {listaIdadeFem.Count}");
Console.WriteLine($"A quantidade de pessoas com idade abaixo de 30 anos é {listaIdade30.Count()}, e a quantidade de pessoas com idade acima de 60 é {listaIdade60.Count()}");
Console.WriteLine($"A média de idade entre as pessoas do sexo feminino é {listaIdadeFem.Average()}");