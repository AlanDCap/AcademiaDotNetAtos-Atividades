/*3. Fazer um laço (repetição) que fique solicitando números ao usuário. 
Se o usuário digitar 0 o programa em VS deve parar. 
Caso contrário, o programa em VS deve informar se o número é par ou ímpar e se ele é um número primo.*/

int num;
bool prime = true;
string parOuImpar;

do
{
    Console.Clear();
    Console.Write("Descubra se um número é par ou ímpar, e se ele é primo.\nDigite um número:");
    num = int.Parse(Console.ReadLine());

    //verificar se é par ou ímpar
    if (num % 2 == 0)
        parOuImpar = "par";
    else
        parOuImpar = "ímpar";

    //verificar se é primo
    for (int i = 2; i < num / 2; i++)
    {
        if (num % i == 0)
        {
            prime = false;
            break;
        }
        else
        {
            prime = true;
        }
    }
    if (num != 0 && prime == false)
        Console.Write($"{num} é {parOuImpar}");

    if (num != 0 && prime == true)
        Console.Write($"{num} é {parOuImpar} e primo.");

    Console.ReadKey();
} while (num != 0);