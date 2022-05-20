/*8 - Faça um programa no VS que receba o código, nome, salário base e o total de vendas de um funcionário.
Caso o total de vendas seja acima de R$ 500,00, adicionar ao seu salário final 5% do total de vendas.
Caso o total de vendas seja mais que R$ 1000,00, adicionar ao seu salário final 7% do total de vendas.
E por fim, se o total de vendas seja maior que R$ 5000,00, adicionar ao seu salário final 10% do 
total de vendas. */

string nome;
int codigoVendedor;
double salarioBase, totalDeVendas, bonus500 = 1.05, bonus1000 = 1.07, bonus5000 = 1.10;

Console.WriteLine("Verifique o valor total do seu salário com base nas suas vendas.");
Console.Write("Informe seu nome:");
nome = Console.ReadLine();

Console.Write("Informe seu código de vendedor:");
codigoVendedor = int.Parse(Console.ReadLine());

Console.Write("Informe seu salário:");
salarioBase = double.Parse(Console.ReadLine());

Console.Write("Informe seu total de vendas:");
totalDeVendas = double.Parse(Console.ReadLine());

if (totalDeVendas > 500 && totalDeVendas <= 1000)
    Console.WriteLine(nome + ", seu salário total é " + (salarioBase * bonus500));

else if (totalDeVendas > 1000 && totalDeVendas <= 5000)
    Console.WriteLine(nome + ", seu salário total é " + (salarioBase * bonus1000));

else if (totalDeVendas > 5000)
    Console.WriteLine(nome + ", seu salário total é " + (salarioBase * bonus5000));

else
    Console.WriteLine("Você não respondeu bonificação esse mês, seu salário é " + salarioBase );