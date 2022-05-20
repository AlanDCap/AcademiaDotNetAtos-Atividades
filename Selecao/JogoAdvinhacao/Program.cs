/*20 - Escreva um algoritmo para o jogo de adivinhação do número secreto. O jogador tem 3 chances e recebe dicas do tipo “é maior” ou “é menor”. 
plus: você pode gerar o número de forma randomica (função random c#).*/

int numSecreto, tentativa;

Console.WriteLine("Tente advinhar o número secreto entre 1 e 10");

Random random = new Random();
numSecreto = random.Next(1, 11);

Console.WriteLine(numSecreto);
Console.Write("Você tem três tentativas.\nPrimeira tentativa, digite um número entre 1 e 10: ");
tentativa = int.Parse(Console.ReadLine());
if (tentativa == numSecreto)
    Console.WriteLine("Parabéns! Você acertou, o número secreto era " + numSecreto);

else
{
   if (tentativa < numSecreto)
        Console.WriteLine("O número secreto é maior que " + tentativa + ".\nSegunda tentativa:");
    else
        Console.WriteLine("O número secreto é menor que " + tentativa + ".\nSegunda tentativa");

    tentativa = int.Parse(Console.ReadLine());
    if (tentativa == numSecreto)
        Console.WriteLine("Parabéns! Você acertou, o número secreto era " + numSecreto);
    else
    {
        if (tentativa < numSecreto)
            Console.WriteLine("O número secreto é maior que " + tentativa + ".\nTerceira tentativa:");
        else
            Console.WriteLine("O número secreto é menor que " + tentativa + ".\nTerceira tentativa");

        tentativa = int.Parse(Console.ReadLine());
        if (tentativa == numSecreto)
            Console.WriteLine("Parabéns! Você acertou, o número secreto era " + numSecreto);
        else
            Console.WriteLine("Suas tentativas acabaram, o número secreto era " + numSecreto);
    }
}