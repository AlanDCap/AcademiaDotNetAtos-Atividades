/* Faça um programa em C# e no Visual Studio que receba a data na forma DDMMAAAA e imprima na 
forma AAAAMMDD e AAMMDD. Note que o dia, o mês e o ano devem ser lidos em variáveis diferentes.*/


Console.WriteLine("Conversor de datas de dia/mês/ano para ano/mês/dia");

int dia;
int mes;
int ano;

Console.WriteLine("Digite o dia: ");
dia = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o mês: ");
mes = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o ano: ");
ano = int.Parse(Console.ReadLine());

Console.WriteLine("A data é :" + dia + "/" + mes + "/" + ano);

Console.Write("Data convertida: ");
Console.WriteLine(ano + "/" + mes + "/" + dia);

Console.Write("Data convertida e abreviada: ");
Console.Write((ano % 100) + "/" + mes + "/" + dia);