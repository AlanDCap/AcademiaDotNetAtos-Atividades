// 1) Fazer um programa em VS que gere uma lista com n valores randômicos e inteiros para glicemia (entre 45 a 500). 
// O programa deve calcular média, valor mínimo, valor máximo e mediana.
// Sugere-se criar um menu como:

// MENU
// 1 - Gerar lista
// 2 - Exibir lista
// 3 - Mostrar medidas centrais (média, valores min e max e mediana)
// 4 - Sair
// Opção: ____

// Observação, toda vez que a opção 1 for acionada, o usuário deve definir quantos números serão gerados na lista

List<int> listaGlicemia = new List<int>();
string opcao = "";

do
{
    Console.Clear();
    Console.WriteLine("MENU");
    Console.WriteLine("1 - Gerar lista");
    Console.WriteLine("2 - Exibir lista");
    Console.WriteLine("3 - Mostrar medidas centrais (média, valores min e max e mediana)");
    Console.WriteLine("4 - Sair");
    Console.Write("Opção: ");
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            //gerar lista aleatória
            Console.WriteLine("Lista sendo gerada");
            int qtdNumeros = 0;
            Console.WriteLine("Qantos números gostaria que fossem gerados?");
            qtdNumeros = int.Parse(Console.ReadLine());
            
            Random gerador = new Random();
            for (int i = 0; i < qtdNumeros; i++)
            {
                listaGlicemia.Add(gerador.Next(45, 500));
            }
            break;

        case "2":
            //exibir a lista aleatória
            Console.WriteLine("Exibindo a lista de valores glicêmicos");
            if (listaGlicemia.Count == 0)
            {
                Console.WriteLine("A lista está vazia, utilize a opção 1, no menu inicial, para gerar uma lista");
            } else
            {
                for (int i = 0; i < listaGlicemia.Count; i++)
                {
                    Console.WriteLine(listaGlicemia[i]);
                }
            }
            break;

        case "3":
            //mostrar medidas centrais
            Console.WriteLine("Exibindo as medidas centrais da lista");
            if (listaGlicemia.Count == 0)
            {
                Console.WriteLine("A lista está vazia, utilize a opção 1, no menu inicial, para gerar uma lista");
            } else
            {
                float media;
                int min;
                int max;
                float mediana;

                List<int> listaTemp = new List<int>();
                listaTemp.AddRange(listaGlicemia);
                listaTemp.Sort();
                min = listaTemp[0];
                max = listaTemp[listaTemp.Count - 1];
                int soma = 0;

                foreach (int i in listaTemp)
                {
                    soma += 1;
                }
                media = soma / listaTemp.Count;

                //regra de negócio para cálculo de mediana
                int meio = (int)listaTemp.Count / 2;
               
                if (listaTemp.Count % 2 != 0)   // lista com tamanho ímpar
                {
                    mediana = listaTemp[meio];
                } else      //lista com tamanho par
                {
                    mediana = (listaTemp[meio] + listaTemp[meio - 1]) / 2;
                }
                Console.WriteLine("A mediana de valores da lista é: " + mediana);
                Console.WriteLine("A média de valores da lista é: " + media);
                Console.WriteLine("O valor min da lista é: " + min);
                Console.WriteLine("O valor max da lista é: " + max);
            }
            break;

        case "4":
            Console.WriteLine("Obrigado por usar o sistema");
            break;
        
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
    Console.WriteLine("Pressione algo para continuar!");
    Console.ReadKey();

} while (opcao != "4");