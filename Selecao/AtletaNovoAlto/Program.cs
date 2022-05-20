/*10 - Faça um programa no VS que receba dados de dois atletas (nome, idade e altura).
O programa deve mostrar os dados do atleta mais novo e mais alto.*/

string nome1, nome2;
int idade1, idade2;
double altura1, altura2;

Console.WriteLine("Descubra qual atleta é mais novo e mais alto.");
Console.Write("Informe os dados do primeiro atleta, começando pelo seu nome: ");
nome1 = Console.ReadLine();

Console.Write("Informe agora a idade deste atleta: ");
idade1 = int.Parse(Console.ReadLine());

Console.Write("Informe a altura do primeiro atleta: ");
altura1 = double.Parse(Console.ReadLine());

Console.Write("Agora informe o nome do segundo atleta: ");
nome2 = Console.ReadLine();

Console.Write("Informe a idade do segundo atleta: ");
idade2 = int.Parse(Console.ReadLine());

Console.Write("Informe o nome do segundo atleta: ");
altura2 = double.Parse(Console.ReadLine());

if (altura1 > altura2 && idade1 < idade2)
    Console.WriteLine("O atleta " + nome1 + " é o mais alto e mais novo, tendo " + idade1 + " anos e " + altura1 + " metros de altura.");

else if (altura1 < altura2 && idade1 > idade2)
    Console.WriteLine("O atleta " + nome2 + " é o mais alto e mais novo, tendo " + idade2 + " anos e " + altura2 + " metros de altura.");

else if (altura1 == altura2 && idade1 == idade2)
    Console.WriteLine( nome1 + " e " + nome2 + " possuem a mesma idade e altura.");

else 
    Console.WriteLine("Um dos atletas é mais novo, enquanto o outro é mais alto");
