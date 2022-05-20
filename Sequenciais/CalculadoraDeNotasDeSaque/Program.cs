/*10) Um programa para gerenciar os saques de um caixa eletrônico deve possuir algum mecanismo 
para decidir o número de notas de cada valor que deve ser disponibilizado para o cliente que 
realizou o saque. Um possível critério seria o da “distribuição ótima” no sentido de que as 
notas de menor valor fossem distribuídas em número mínimo possível. 
Por exemplo, se a quantia solicitada fosse R$ 87,00 o programa deveria indicar uma nota de R$ 50,00, 
três notas de R$ 10,00, uma nota de R$ 5,00 e duas notas de R$ 1,00. 
Escreva um programa que receba o valor da quantia solicitada e retorne a distribuição das notas 
de acordo com o critério da “distribuição ótima”.*/

int nota200, nota100, nota50, nota20, nota10, nota5, nota2, nota1, valorSaque, resto;


Console.WriteLine("Calculadora de notas no saque em caixas eletrônicos");
Console.WriteLine("Informe o valor a ser sacado, sem casas decimais");
valorSaque = int.Parse(Console.ReadLine());

nota200 = valorSaque / 200;
resto = valorSaque % 200;
Console.Write("Notas de 200: "+ nota200+"\n");

nota100 = resto / 100;
resto = resto % 100;
Console.Write("Notas de 100: " + nota100 + "\n");

nota50 = resto / 50;
resto = resto % 50;
Console.Write("Notas de 50: " + nota50 + "\n");

nota20 = resto / 20;
resto = resto % 20;
Console.Write("Notas de 20: " + nota20 + "\n");

nota10 = resto / 10;
resto = resto % 10;
Console.Write("Notas de 10: " + nota10 + "\n");

nota5 = resto / 5;
resto = resto % 5;
Console.Write("Notas de 5: " + nota5 + "\n");

nota2 = resto / 2;
resto = resto % 2;
Console.Write("Notas de 2: " + nota2 + "\n");

nota1 = resto;
Console.Write("Notas de 1: " + nota1 + "\n");