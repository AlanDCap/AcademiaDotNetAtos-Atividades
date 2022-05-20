/*3 - Escrever um algoritmo para ler quatro valores inteiros, calcular a sua média, e escrevê-los na tela em ordem crescente.*/

double[] valores = new double [4];

Console.WriteLine("Organize valores em ordem crescente.\nInforme quatro valores");
valores[0] = double.Parse(Console.ReadLine());
valores[1] = double.Parse(Console.ReadLine());
valores[2] = double.Parse(Console.ReadLine());
valores[3] = double.Parse(Console.ReadLine());

Array.Sort(valores);
for(int i = 0; i < valores.Length; i++)

Console.WriteLine(valores[i]);