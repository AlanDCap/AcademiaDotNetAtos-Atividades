/*Programa em VS que recebe e-mail de um usuário e os grava em arquivo.*/

string opcao = "", nomeArquivo = "emails.dat";
StreamWriter escritor = new StreamWriter(nomeArquivo, true);

do
{
    Console.Clear();
    Console.WriteLine("MENU");
    Console.WriteLine("1 - Cadastrar um email");
    Console.WriteLine("2 - Sair");

    Console.WriteLine("Opção: ");
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            //receber email e gravar no arquivo
            try
            {
                string nome, email; 

                Console.Write("Digite o seu nome: ");
                nome = Console.ReadLine().ToUpper();
                Console.Write("Digite o seu email: ");
                email = Console.ReadLine().ToLower();

                escritor.WriteLine(nome + ";" + email);
                escritor.Flush();
                           
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro ao gravar o arquivo" + e.Message);
            }
            break;

        case "2":
            Console.WriteLine("Obrigado por usar o programa");
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }
    Console.WriteLine("Pressione algo para continuar");
    Console.ReadKey();
} while (opcao != "2");