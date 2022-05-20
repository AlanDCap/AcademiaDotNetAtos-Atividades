/*16 - Escreva um algoritmo que leia o placar de um jogo da primeira fase da copa do Brasil. Caso o time de fora tenha ganho o jogo por mais de 2 gols de diferença, mostre
na tela uma mensagem indicando que o time de fora já se classificou para a próxima fase. Caso contrário, mostre uma mensagem indicando que os dois times irão se
enfrentar novamente em um novo jogo.
ex: time da casa 4 x 3 time de fora, mostra "Os dois times se enfrentarão em um novo jogo"
ex2: time da casa 1 x 3 time de fora, mostra "O time de fora já se classificou"
plus: caso ocorra um segundo jogo, leia o placar desse novo jogo e então diga quem passou de fase.*/

string timeDeCasa, timeDeFora;
int golEmCasa, golFora;

Console.WriteLine("Verifique a classificação para a próxima fase da Copa do Brasil.\nInforme qual é o time da casa e quantos gols ele fez.");
timeDeCasa = Console.ReadLine();
golEmCasa = int.Parse(Console.ReadLine());

Console.WriteLine("Informe agora o time de fora e quantos gols ele fez.");
timeDeFora = Console.ReadLine();
golFora= int.Parse(Console.ReadLine());

if (golFora - golEmCasa >= 2)
    Console.WriteLine(timeDeFora + " já se classificou pela diferença de gols.");

else if (golFora < golEmCasa)
{
    Console.WriteLine(timeDeFora + " e " + timeDeCasa + " se enfrentarão novamente.");
    Console.WriteLine("Caso já tenha ocorrio a segunda partida, informe quantos gols " + timeDeCasa + " fez");
        golEmCasa = int.Parse(Console.ReadLine());

    Console.WriteLine("Agora informe quantos gols " + timeDeFora + " fez");
        golFora = int.Parse(Console.ReadLine());

    if (golFora > golEmCasa)
        Console.WriteLine(timeDeFora + " se classificou para próxima fase.");

    else if (golEmCasa > golEmCasa)
        Console.WriteLine(timeDeCasa + " se classificou para próxima fase");
    else
    {
        Console.WriteLine("A decisão será feita por pênaltis\nInforme quantos pênaltis o " + timeDeCasa + " acertou.");
        golEmCasa = int.Parse(Console.ReadLine());

        Console.WriteLine("Agora informe quantos pênaltis " + timeDeFora + " acertou ");
        golFora = int.Parse(Console.ReadLine());

        if (golFora > golEmCasa)
            Console.WriteLine(timeDeFora + " se classificou para próxima fase.");

        else 
            Console.WriteLine(timeDeCasa + " se classificou para próxima fase");
    }
        
}