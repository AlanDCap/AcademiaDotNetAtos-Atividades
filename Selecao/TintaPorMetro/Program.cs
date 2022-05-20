/*15 - Faça um programa para uma loja de tintas. O programa deverá pedir o tamanho em metros quadrados 
da área a ser pintada. Considere que a cobertura da tinta é de 1 litro para cada 3 metros quadrados 
e que a tinta é vendida em latas de 18 litros, que custam R$ 80,00. 
Informe ao usuário a quantidades de latas de tinta a serem compradas e o preço total.*/

double area, tintaLata = 18, tintaPreco = 80, qtdLatas, precoTotal;

Console.WriteLine("Verifique quantas latas de tinta precisa para pintar uma determinada área\nInforme a área a ser pintada:");
area = double.Parse(Console.ReadLine());

qtdLatas = Math.Ceiling((area / 3) / tintaLata);
precoTotal = qtdLatas * tintaPreco;
Console.WriteLine("Serão necessárias " + qtdLatas + " latas, e o preço total será de " + precoTotal);