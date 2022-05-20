/*6 - Faça um programa em C# e no Visual Studio para receber o nome (totalmente em maiúsculo), a altura (metros) e o peso (kg) de uma pessoa.
O programa deve calcular o Indice de Massa Corpórea (IMC), exibi - lo ao usuário e informar sua situação conforme a tabela.
O cálculo do imc = peso / (altura * altura)

IMC
menor que 18                -> baixo peso
maior que 18 e menor que 25 -> peso normal
maior que 25 e menor que 30 -> sobrepeso
maior que 30 e menor que 35 -> obesidade
maior que 35                -> obesidade grau sério*/

string nome;
double altura, peso, imc;

Console.Write("Calcule seu indíce de massa corpórea\nDigite seu nome: ");
nome = Console.ReadLine();

Console.WriteLine("Informe sua altura em metros:");
altura = double.Parse(Console.ReadLine());

Console.WriteLine("Informe seu peso em quilos:");
peso = double.Parse(Console.ReadLine());

imc = (peso / (altura * altura))*10000;
Console.WriteLine(Math.Round(imc, 2));

if (imc < 18)
    Console.WriteLine(nome.ToUpper() + ", você está abaixo do peso.");
else if (imc < 25 && imc > 18)
    Console.WriteLine(nome.ToUpper() + ", seu peso está normal.");
else if (imc < 30 && imc > 25)
    Console.WriteLine(nome.ToUpper() + ", você está com sobrepeso");
else if (imc < 35 && imc > 30)
    Console.WriteLine(nome.ToUpper() + ", você está em situação de obesidade");
else if (imc > 35)
    Console.WriteLine(nome.ToUpper() + ", você está em situação de obesidade grave");