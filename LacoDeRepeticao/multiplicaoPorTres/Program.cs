/*16. Ler um número N qualquer menor ou igual a 50 e apresentar o valor obtido da 
multiplicação sucessiva de N por 3 enquanto o produto for menor que 250 
(N*3; N*3*3; N*3*3*3; etc).*/

int n, produto, i = 1;

Console.WriteLine("Informe um número inteiro menor ou igual a 5: ");
n = int.Parse(Console.ReadLine());

do 
{
    produto = (int)(n * Math.Pow(3, i));
    i++;
    Console.WriteLine(produto);

} while (produto < 250);