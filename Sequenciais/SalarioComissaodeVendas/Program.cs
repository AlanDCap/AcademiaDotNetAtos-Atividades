/*13) Uma loja vende bicicletas com um acréscimo de 50% sobre o preço de custo. Ela paga a cada vendedor 2 salários mínimos mensais, mais uma comissão de 15% sobre o 
preço de custo de cada bicicleta vendida. Desenvolva um algoritmo que leia o valor do salário mínimo, o preço de custo de cada bicicleta e o número de bicicletas 
vendidas pelo vendedor, calcule e mostre: o salário do empregado*/

/* preço de venda = custo * 1,5
 * salario vendedor = (salario mínimo * 2) + (vendas * (preço de venda *0,15))
 * ler salario
 * ler preço de custo 
 * ler quantidade de vendas
 * mostrar salário com acréscimo da comissão*/

double custobicicleta, salariominimo, salarioefetivo, qtdvendas;

Console.WriteLine("Calcule seu salário com os bônus de comissão");
Console.WriteLine("Informe o valor do salário mínimo:");
salariominimo = double.Parse(Console.ReadLine());

Console.WriteLine("Informe o custo de produção de uma bicicleta:");
custobicicleta = double.Parse(Console.ReadLine());

Console.WriteLine("Informe quantas vendas realizou este mês:");
qtdvendas = double.Parse(Console.ReadLine());

salarioefetivo = (salariominimo * 2) + (qtdvendas * ((custobicicleta * 1.5)* 0.15)); 
Console.WriteLine(salarioefetivo);

//por ser apenas uma atividade prática, optei por não seguir a risca o enunciado e calculei a comissão em cima do preço de venda da bicicleta, ao invés do preço de custo.