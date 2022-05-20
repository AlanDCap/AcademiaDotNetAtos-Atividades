/*7.	Os dois primeiros números da sequência de Fibonacci são 0 e 1. Os próximos números dessa 
sequência podem ser calculados como sendo a soma dos dois números anteriores. Os primeiros
números de Fibonacci são: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, … Escreva um algoritmo 
que leia um número pelo teclado N, e então mostre os N primeiros números da sequência de Fibonacci.*/

int n, temp1 = 0, temp2 = 1;

Console.WriteLine("Verifique a sequência de fibonacci até determinado número.\nDigite um número");
n = int.Parse(Console.ReadLine());

Console.WriteLine(temp1);
Console.WriteLine(temp2);

for (int i = temp1 + temp2; i < n; i = temp1 + temp2)
{
    Console.WriteLine(i);
    temp1 = temp2;
    temp2 = i;
}