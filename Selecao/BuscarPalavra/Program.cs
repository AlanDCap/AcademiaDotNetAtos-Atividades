/*7 - Faça um programa em C# e no VS para receber uma frase qualquer e uma palavra de pesquisa.
O programa deve avaliar se a palavra aparece na frase, informando o usuário via mensagem, como por 
exemplo, A palavra encontra-se na frase   ou A palavra não se encontra na frase.*/

string frase, palavra;
Console.WriteLine("Descubra se uma palavra se encontra em determinada frase.\nDigite uma frase e, em seguida, a palavra a ser buscada");
frase = Console.ReadLine();
palavra = Console.ReadLine();

if (frase.IndexOf(palavra) != -1)
{
    Console.WriteLine("A palavra " + palavra + " consta na frase," + " a partir do caractere " + (frase.IndexOf(palavra) + 1));
}
else
    Console.WriteLine("A palavra " + palavra + " não consta na frase");