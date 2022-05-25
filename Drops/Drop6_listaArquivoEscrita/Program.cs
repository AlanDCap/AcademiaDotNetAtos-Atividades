/*Programa em VS que recebe e-mail de um usuário e os grava em arquivo.*/

using Drop6_listaArquivoEscrita;

string opcao = "", nomeArquivo = "emails.dat";
StreamWriter escritor = new StreamWriter(nomeArquivo, true);
List<Pessoa> listaPessoas = new List<Pessoa>();
do
{
    Console.Clear();
    Console.WriteLine("MENU");
    Console.WriteLine("1 - Cadastrar uma pessoa");
    Console.WriteLine("2 - Exibir uma pessoa");
    Console.WriteLine("3 - Sair");

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

               //Criar um objeto Pessoa com os valores nome e email
                Pessoa p = new Pessoa(nome, email);
                //Verificar se essa dupla já está na lista, llogo no arquivo
                bool jaCadastrado = false;
                foreach (Pessoa i in listaPessoas)
                {
                    if (i.email.Equals(email))
                    {
                        Console.WriteLine("Esse email já está no sistema");
                        jaCadastrado = true;
                        break;
                    }
                }
                if (!jaCadastrado)
                {
                //adicionar o objeto na lista
                listaPessoas.Add(p);
                //adicionar o objeto no arquivo
                escritor.WriteLine(p.nome + ";" + p.email);
                escritor.Flush();
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro ao gravar o arquivo" + e.Message);
            }
            break;

        case "2":

            break;
        
        
        case "3":
            Console.WriteLine("Obrigado por usar o programa");
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }
    Console.WriteLine("Pressione algo para continuar");
    Console.ReadKey();
} while (opcao != "3");