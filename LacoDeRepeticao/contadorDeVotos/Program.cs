/*4. Em uma cidadezinha do interior há dois candidatos para prefeito (JOAO e ZECA). 
Você foi contratado para fazer um programa em VS que conte os votos dos candidatos. 
Cada vez que o usuário digitar JOAO, você deve somar um ao seu número de votos. O mesmo para ZECA. 
Você também pode aceitar votos em branco (palavra BRANCO). O programa em VS termina quando o usuário 
escrever FIM. Ao final devem ser mostradas as quantidades de votos para cada um dos candidatos e o número 
de votos em branco. */

string voto;
int votosZeca = 0, votosJoao = 0, votosBrancos = 0, votosNulos = 0;

do
{
    Console.Clear();
    Console.Write("Digite o nome do seu candidato ou branco para votar em branco. Digite fim para encerrar:");
    voto = Console.ReadLine().ToUpper();

    switch (voto)
    {
        case "JOAO":
            votosJoao++;
            break;

        case "ZECA":
            votosZeca++;
            break;

        case "BRANCO":
            votosBrancos++;
            break;

        case "FIM":
            Console.Write("Programa encerrado");
            break;

        default:
            Console.WriteLine("Candidato inexistente");
            votosNulos++;
            break;
    }
    Console.WriteLine("Obrigado por votar nessas eleições");
    Console.ReadKey();

} while (voto != "FIM");
Console.WriteLine($"Total de votos para o João: {votosJoao}");
Console.WriteLine($"Total de votos para o Zeca: {votosZeca}");
Console.WriteLine($"Total de votos em Branco: {votosBrancos}");
Console.WriteLine($"Total de votos nulos: {votosNulos}");
Console.WriteLine($"\nO total de votos foi {votosBrancos + votosJoao + votosNulos + votosZeca}");

if (votosJoao > votosZeca)
    Console.WriteLine($"João é o candidato vencedor por uma diferença de {votosJoao - votosZeca} votos.");
else if (votosJoao < votosZeca)
    Console.WriteLine($"Zeca é o candidato vencedor por uma diferença de {votosZeca - votosJoao} votos.");