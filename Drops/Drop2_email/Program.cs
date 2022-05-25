// 2) Fazer um programa em VS que permita o usuário cadastrar emails de clientes (em uma lista). 
// Uma vez cadastrados os emails, o programa deve separar o nome de usuário (antes do @) do domínio do email 
// (depois do @). Ao final, o programa deve exibir os domínios utilizados no cadastro (não pode exibir os repetidos).
// Observação: os domínio são, por exemplo, gmail.com; yahoo.com.br; ufn.edu.br; hotmail.com; entre outros.

// Sugere-se usar um menu como:

// MENU 
// 1 - Cadastrar emails
// 2 - Mostrar lista de emails
// 3 - Mostrar dominíos de emails
// 4 - Sair
// Opção:____

List<string> listaEmails = new List<string>();
List<string> listadominios = new List<string>();
string opcao;

do
{

    Console.Clear();
    Console.WriteLine("MENU");
    Console.WriteLine("1 - Cadastrar email");
    Console.WriteLine("2 - Exibir lista de emails");
    Console.WriteLine("3 - Mostrar os domínios dos emails");
    Console.WriteLine("4 - Sair");
    Console.Write("Opção: ");
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            //cadastrar email
            Console.WriteLine("Cadastro de e-mail:");
            string email;
            Console.Write("Digite um e-mail: ");
            email = Console.ReadLine().ToUpper();
            if (listaEmails.Contains(email))
            {
                Console.WriteLine("E-mail já cadastrado");
            }
            else
            {
                listaEmails.Add(email);

                string[] emailSplit;
                string dominio;
                emailSplit = email.Split('@');
                dominio = emailSplit[1];

                if (!listadominios.Contains(dominio))
                {
                    listadominios.Add(dominio);
                }
                listadominios.Sort();
                Console.WriteLine("E-mail cadastrado com sucesso");
            }
            break;

        case "2":
            //exibir lista dos e-mails
            Console.WriteLine("Exibindo a lista de e-mails");
            if (listaEmails.Count == 0)
            {
                Console.WriteLine("A lista está vazia!");
            } else
            {
                foreach (string i in listadominios)
                {
                    Console.WriteLine(i);
                }
            }
            break;

        case "3":
            //exibir os domínios de e-mail
            Console.WriteLine("Exibindo os domínios de e-mail");
            if (listadominios.Count == 0)
            {
                Console.WriteLine("A lista está vazia!");
            } else
            {
                foreach (string i in listadominios)
                {
                    Console.WriteLine(i);
                }
            }
            break;

        case "4":
            Console.WriteLine("Obrigado por usar o sistema");
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;

    }
    Console.WriteLine("Pressione qualquer tecla para continuar");
    Console.ReadKey();

} while (opcao != "4");