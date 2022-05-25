using ProblemaDasDisciplinas;


List<Aluno> listaDisciplina1 = new List<Aluno>();
List<Aluno> listaDisciplina2 = new List<Aluno>();

string opcao = "";

do
{
    Console.WriteLine("1 - Carregar listas de disciplinas");
    Console.WriteLine("2 - Exibir listas de disciplinas");
    Console.WriteLine("3 - Mostrar alunos comuns nas disciplinas");
    Console.WriteLine("4 - Sair");
    Console.WriteLine("Opção: ");
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Carregar listas de disciplinas");
            Util.carregarListas(listaDisciplina1, listaDisciplina2);
            break;

        case "2":
            Console.WriteLine("Exibir listas de disciplinas");
            break;

        default:
            break;
    }
    Console.WriteLine("Pressione algo para continuar!"); Console.ReadKey();
} while (opcao != "4");