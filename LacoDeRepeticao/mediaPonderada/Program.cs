/*15. Ler 4 valores referentes a notas escolares de um aluno e imprimir uma mensagem dizendo se ele está aprovado 
ou reprovado, após ter calculado sua média ponderando, considerando pesos 2, 1, 2, e 4, respectivamente. 
Considerar nota 7,0 como mínima para aprovação.*/

List<float> listaDeNotas = new List<float>();
float notas = 0, media;

Console.WriteLine("Verifique sua aprovação.\nInforme suas quatro notas deste semestre");
do
{
    listaDeNotas.Add(float.Parse(Console.ReadLine()));
    notas++;

} while (notas < 4);

media = ((listaDeNotas[0]*2 + listaDeNotas[1] + listaDeNotas[2] * 2 + listaDeNotas[3] * 4)/9);
Console.WriteLine(media);

if (media >= 7)
    Console.WriteLine("Parabéns você foi aprovado");
else
    Console.WriteLine("Você não foi aprovado");