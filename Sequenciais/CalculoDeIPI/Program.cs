/* Escreva um programa em C# e no Visual Studio que leia os dados para o parafuso A e para o parafuso B, 
isto é, o código, a quantidade de peças e o valor unitário de cada parafuso e a porcentagem 
de IPI (única) a ser acrescentada.*/

Console.WriteLine("Cálculo do valor de IPI para compra de parafusos");

//usei apenas descrição de item porque um sistema de código de produto poderia ficar abstrato demais para execução da atividade.
string parafusoA, parafusoB;
int qtd_parafusosA, qtd_parafusosB;
float preco_unitarioA, preco_freteA, preco_seguroA, preco_unitarioB, preco_freteB, preco_seguroB, valorBaseA, valoripiA, valorBaseB, valoripiB;
double ipi = 0.1875;

Console.WriteLine("Informe o parafuso que deseja comprar: ");
parafusoA = Console.ReadLine();

Console.WriteLine("Digite a quantidade de parafusos adquiridos: ");
qtd_parafusosA = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o preço de cada parafuso: "); 
preco_unitarioA = float.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor do frete, se houver: ");
preco_freteA = float.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor do seguro, se houver: ");
preco_seguroA = float.Parse(Console.ReadLine());

valorBaseA = qtd_parafusosA * preco_unitarioA + preco_freteA + preco_seguroA;
valoripiA = (float) (valorBaseA * ipi);

Console.WriteLine("Para o parafuso " + parafusoA + " o preço do IPI será " + valoripiA);


Console.WriteLine("Informe outro parafuso que deseja comprar: ");
parafusoB = Console.ReadLine();

Console.WriteLine("Digite a quantidade de parafusos adquiridos: ");
qtd_parafusosB = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o preço de cada parafuso: ");
preco_unitarioB = float.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor do frete, se houver: ");
preco_freteB = float.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor do seguro, se houver: ");
preco_seguroB = float.Parse(Console.ReadLine());

valorBaseB = qtd_parafusosB * preco_unitarioB + preco_freteB + preco_seguroB;
valoripiB = (float)(valorBaseB * ipi);

Console.WriteLine("Para o parafuso " + parafusoB + " o preço do IPI será " + valoripiB);