/*7. Faça um programa em VS que solicite o nome, a idade e o salário de uma pessoa. 
A cada solicitação, teste se o usuário informou um valor válido. 
Por exemplo: se o nome for não for lido corretamente (ou seja, se estiver em branco ou se for um número), 
informe que ele está incorreto e saia do programa em VS. 
Se o nome for lido corretamente, solicite a idade. Se ela for incorreta (menor ou igual a zero), 
informe que está errada e saia. Se estiver correta, solicite o salário. 
Se ele estiver incorreto (menor ou igual a zero), informe que está incorreto e saia. 
Se estiver correto, mostre todos os valores lidos.*/

int idade;
string nome;
float salario;

do
{
    Console.Write("Informe seu nome: ");
    nome = Console.ReadLine();
    Console.WriteLine(nome);
}
while (!nome);

do
{
    Console.Write("Informe sua idade: ");
    idade = int.Parse(Console.ReadLine());
}
while (false);