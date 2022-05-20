/*9 - Faça um programa no VS que receba do usuário 3 valores de glicemia em jejum, representando a medição
diária de um paciente diabético. Para cada valor recebido analisar e informar ao paciente o seguinte:
Se o valor diário for menor que 65, avisá-lo que corre risco de hipoglicemia
Se o valor diário for maior que 250, avisá-lo que corre risco de hiperglicemia.

Além disso, o programa deve fazer a média dos 3 valores de glicemia coletados. E se a média for 
menor que 80, avisá-lo que é preciso diminuir 2 unidades de insulina. Se a média for maior que
150, avisá-lo que será necessário adicionar 2 unidades de insulina.*/

double medicaoDia1, medicaoDia2, medicaoDia3, media;

Console.WriteLine("Olá, verifique como estão os seus valores de glicemia");
Console.WriteLine("Informe os valores de glicemia registrados nos três últimos dias, quando estava em jejum:");
medicaoDia1 = double.Parse(Console.ReadLine());
medicaoDia2 = double.Parse(Console.ReadLine());
medicaoDia3 = double.Parse(Console.ReadLine());

if (medicaoDia1 < 65)
    Console.WriteLine("Sua primeira medição estava abaixo do esperado, existe risco de hipoglicemia");
else if (medicaoDia1 > 250)
    Console.WriteLine("Sua primeira medição estava acima do esperado, existe risco de hiperglicemia");
else
    Console.WriteLine("Sua primeira medição estava normal");

if (medicaoDia2 < 65)
    Console.WriteLine("Sua segunda medição estava abaixo do esperado, existe risco de hipoglicemia");
else if (medicaoDia2 > 250)
    Console.WriteLine("Sua segunda medição estava acima do esperado, existe risco de hiperglicemia");
else
    Console.WriteLine("Sua segunda medição estava normal");

if (medicaoDia3 < 65)
    Console.WriteLine("Sua terceira medição estava abaixo do esperado, existe risco de hipoglicemia");
else if (medicaoDia3 > 250)
    Console.WriteLine("Sua terceira medição estava acima do esperado, existe risco de hiperglicemia");
else
    Console.WriteLine("Sua terceira medição estava normal");

media = (medicaoDia1 + medicaoDia2 + medicaoDia3) / 3;
if (media < 80)
    Console.WriteLine("Sua média de glicemia está baixa, reduza sua dose de insulina em duas unidades");
else if (media > 150)
    Console.WriteLine("Sua média de glicemia está alta, aumente sua dose de insulina em duas unidades");