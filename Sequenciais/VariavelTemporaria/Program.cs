/* Escreva a seqüência de atribuições, em forma de programa em C# e no Visual Studio, para trocar entre 
si os valores de duas variáveis A e B.*/

Console.WriteLine("Escreva a seqüência de atribuições, em forma de programa\n" + "em C# e no Visual Studio, para trocar entre\n" + " si os valores de duas variáveis A e B");

Console.WriteLine("Digite uma frase qualquer");
string variavel1 = Console.ReadLine();

Console.WriteLine("Digite outra frase qualquer");
string variavel2 = Console.ReadLine();

Console.WriteLine("O conteúdo da variável 1 é: " + variavel1);
Console.WriteLine("O conteúdo da variável 2 é: " + variavel2);

Console.WriteLine("Processo de troca de valores entre duas variáveis");

string tmp = variavel1;
variavel1 = variavel2;
variavel2 = tmp;

Console.WriteLine("O conteúdo da variável 1 é: " + variavel1);
Console.WriteLine("O conteúdo da variável 2 é: " + variavel2);