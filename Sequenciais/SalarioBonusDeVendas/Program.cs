/*7) Escreva um programa em C# e no Visual Studio que leia o número de um vendedor, o seu salário fixo, 
o total de vendas por ele efetuadas e o percentual que ganha sobre o total de vendas. 
Calcule o salário total do vendedor. Escreva o número do vendedor e o salário total do vendedor.*/

Console.WriteLine("Cálculo de salário total após bônus de vendas");

int codigo_vendedor;
double bonus1 = 1.1, bonus2 = 1.2, salario, qtd_vendas;

Console.Write("Bom dia, indique o seu número de vendedor: ");
codigo_vendedor = int.Parse(Console.ReadLine());

Console.WriteLine("Agora indique o valor base do seu salário: ");
salario = double.Parse(Console.ReadLine());

Console.WriteLine("Agora informe o total de vendas que realizou: ");
qtd_vendas = double.Parse(Console.ReadLine());

if (qtd_vendas > 20)
{
    Console.WriteLine("Para o vendedor " + codigo_vendedor + " o salário total é: " + "R$ " + (salario * bonus2));
}
else if (qtd_vendas > 10)
    {
    Console.WriteLine("Para o vendedor " + codigo_vendedor + " o salário total é: " + "R$ " + (salario * bonus1));
}
    else
    {
    Console.WriteLine("Para o vendedor " + codigo_vendedor + " o salário total não recebe bonificação, ficando em: " + "R$ " + (salario));
    //não consegui descobrir como fazer para exibir o resultado em duas casas decimais. Tentei .ToString, mas sem sucesso.
}