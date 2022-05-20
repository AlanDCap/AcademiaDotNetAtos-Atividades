/*18 - Escreva um algoritmo que leia 3 valores pelo teclado e então informe qual o maior deles.*/

double valor1, valor2, valor3;

Console.WriteLine("Descubra qual o maior valor.\nDigite três valores a seguir: ");
valor1 = double.Parse(Console.ReadLine());
valor2 = double.Parse(Console.ReadLine());
valor3 = double.Parse(Console.ReadLine());

if (valor1 == valor2 && valor2 == valor3)
    Console.WriteLine("Os valores são iguais!");
else if (valor1 > valor2 && valor1 > valor3)
    Console.WriteLine(valor1 + " é o maior valor");
else if (valor2 > valor1 && valor2 > valor3)
    Console.WriteLine(valor2 + " é o maior valor");
else if (valor3 > valor1 && valor3 > valor2)
    Console.WriteLine(valor3 + " é o maior valor");