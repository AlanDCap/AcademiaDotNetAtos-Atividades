/*12 - Elabore um programa em VS que leia as variáveis "codigo" e "numeroHoras", respectivamente código e 
número de horas trabalhadas de um operário. Na sequência, calcule o salário sabendo-se que ele ganha 
R$ 10,00 por hora. Quando o número de horas exceder a 50 calcule o excesso de pagamento 
armazenando-o na variável "extra", caso contrário zerar tal variável. A hora excedente de trabalho vale R$ 20,00. 
No final do processamento, exibir o salário total e o salário excedente do operário.*/

int codigo;
double numeroHoras, extra, salarioTt, salarioEx, valorHora = 10, valorExtra = 20;

Console.WriteLine("Verifique o valor de seu salário.\nPrimeiramente informe seu código:");
codigo = int.Parse(Console.ReadLine());

Console.WriteLine("Agora informe o núumero de horas trabalhadas neste mês:");
numeroHoras = double.Parse(Console.ReadLine());

while (numeroHoras < 0)
{
    Console.WriteLine("Número de horas inválido, favor inserir um número maior que zero:");
    numeroHoras = double.Parse(Console.ReadLine());
}

if (numeroHoras < 50)
{
    salarioTt = numeroHoras * valorHora;
    Console.WriteLine("Seu salário este mês é R$ " + Math.Round(salarioTt, 2));
}

else
{
    extra = (numeroHoras - 50);
    salarioTt = ((numeroHoras - extra) * valorHora);
    salarioEx = extra * valorExtra;
    Console.WriteLine("Seu salário este mês é R$ " + Math.Round(salarioTt, 2) + " acrescido do valor R$ " + Math.Round(salarioEx, 2) + " referente às horas extras.");
}