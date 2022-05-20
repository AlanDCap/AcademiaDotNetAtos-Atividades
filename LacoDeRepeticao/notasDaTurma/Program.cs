/*11. Ler as notas de uma turma de alunos e ao final imprimir a nota mais alta, a nota mais baixa, 
a média aritmética da turma e a quantidade de alunos da turma. Usar como flag a nota 12.*/

List<int> notas = new List<int> ();
List<string> alunos= new List<string> ();
int qtdAlunos;
Console.WriteLine("Informe a quantidade de alunos na sala e, em seguida, o nome e a nota de cada aluno.");
qtdAlunos = int.Parse(Console.ReadLine());

do
{
    Console.Write("Nome:");
    alunos.Add(Console.ReadLine());

    Console.Write("Nota:");
    notas.Add(int.Parse(Console.ReadLine()));
} while (alunos.Count < qtdAlunos);

Console.WriteLine($"A nota mais alta da turma foi {notas.Max()}, a nota mais baixa foi {notas.Min()}, \nem média, a sala obteve nota {Math.Round(notas.Average(), 2)} e a quantidade de alunos é {qtdAlunos}");