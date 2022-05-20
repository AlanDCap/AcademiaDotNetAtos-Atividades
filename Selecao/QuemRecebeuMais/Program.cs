/*4 - Escrever um algoritmo para ler a quantidade de horas aula dadas por dois professores 
 * e o valor por hora recebido por cada um deles. 
 * Mostrar na tela qual dos professores tem o maior salário total.*/

double horaAula1, horaAula2, valorAula1, valorAula2, salario1, salario2;
string professor1, professor2;

Console.WriteLine("Descubra qual professor(a) recebeu mais este mês!");
Console.WriteLine("Digite o nome de um(a) professor(a):");
professor1 = Console.ReadLine();

Console.WriteLine("Informe a quantidade de horas aula ministradas por um(a) professor(a):");
horaAula1 = double.Parse(Console.ReadLine());

Console.WriteLine("Agora informe o valor da hora aula deste(a) professor(a):");
valorAula1 = double.Parse(Console.ReadLine());

salario1 = horaAula1 * valorAula1;

Console.WriteLine("Digite o nome de outro(a) professor(a):");
professor2 = Console.ReadLine();

Console.WriteLine("Indique a quantidade de horas aula ministradas por outro(a) professor(a):");
horaAula2 = double.Parse(Console.ReadLine());

Console.WriteLine("Agora informe o valor da hora aula deste(a) professor(a):");
valorAula2 = double.Parse(Console.ReadLine());

salario2 = horaAula2 * valorAula2;

if (salario1 > salario2)
{
    Console.WriteLine("O maior salário foi do(a) professor(a) " + professor1);
}
else
    Console.WriteLine("O maior salário foi do(a) professor(a) " + professor2);