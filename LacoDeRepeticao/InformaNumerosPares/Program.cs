/*1. Faça um programa em VS que solicite um número inteiro positivo ao usuário, validando a entrada de dados 
(informando se ele estiver errado e repetindo a solicitação até que esteja correto). 
Após o programa em VS deve informar todos os números pares existentes entre 1 e o número fornecido pelo usuário.*/

int numero;
string opcao;

do
{
    Console.WriteLine("Descubra os números pares até um determinado número inteiro.\nInforme um número inteiro e positivo.");
    numero = int.Parse(Console.ReadLine());

    while (numero < 0)
    {
        Console.Clear();
        Console.WriteLine("O número precisa ser maior que zero, digite novamente:");
        numero = int.Parse(Console.ReadLine());
    }

    Console.WriteLine("O número digitado foi: " + numero + "\nOs números inteiros pares até " + numero + " são:");

    for (int i = 1; i <= numero; i++)
    {
        if (i % 2 == 0)
            Console.WriteLine(i);
    }
    Console.Write("Deseja informar um novo número? (s/n): ");
    opcao = Console.ReadLine().ToUpper();

} while (opcao == "S");