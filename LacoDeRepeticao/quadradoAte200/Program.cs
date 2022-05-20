/*17. Apresentar os quadrados dos números inteiros de 15 a 200.*/

int n;

Console.WriteLine("Lista dos quadrados dos números entre 15 e 200\nAperte qualquer tecla para mostrar os resultados");
Console.ReadKey();

for (int i = 15; i <= 250; i++)
    Console.WriteLine($"{i} ao quadrado é igual a {Math.Pow(i, 2)}");