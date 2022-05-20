/* 5 - Escrever um algoritmo para ler duas notas de um aluno e escrever na tela 
 * a palavra “Aprovado” se a média das duas notas for maior ou igual a 7,0. 
 * Caso a média seja inferior a 7,0, o programa deve ler a nota do exame e calcular a média final. 
 * Se esta média for maior ou igual a 5,0, o programa deve escrever “Aprovado”, 
 * caso contrário deve escrever “Reprovado”.*/

double nota1, nota2, notaExame, media1 = 7, media2 = 5;

Console.WriteLine("Verifique se aprovado ou reprovado neste período letivo!");
Console.WriteLine("Informe a nota de sua primeira prova:");
nota1 = double.Parse(Console.ReadLine());

Console.WriteLine("Informe a nota de sua segunda prova:");
nota2 = double.Parse(Console.ReadLine());

if (media1 < ((nota1 + nota2) / 2))
{
    Console.WriteLine("Você foi aprovado!");
}
else
{
    Console.WriteLine("Sua nota não foi suficiente para ser aprovado, informe a nota do seu exame: ");
    notaExame = double.Parse(Console.ReadLine());

    if (media2 < ((media1 + notaExame) / 2))
    {
        Console.WriteLine("Parabéns! Você foi aprovado através do exame");
    }
    else
    {
        Console.WriteLine("Infelizmente você não foi aprovado.");
    }
} 
    
    
    

    
