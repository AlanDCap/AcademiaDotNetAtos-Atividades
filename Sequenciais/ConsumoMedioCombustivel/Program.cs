/* Escreva um programa em C# e no Visual Studio para calcular o consumo médio de um automóvel 
(medido em Km/l), sendo que são conhecidos a distância total percorrida e o volume de combustível 
consumido para percorrê-la (medido em l).*/

Console.WriteLine("Calcule a média de consumo de combustível do seu carro");

float distancia;
float gasto_combustivel;

Console.WriteLine("Digite a distância percorrida em quilômetros");
distancia = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a quantidade consumida de combustível em litros");
gasto_combustivel = float.Parse(Console.ReadLine());

Console.WriteLine("O consumo médio de combustível por quilômetro foi de: " + (distancia / gasto_combustivel) + " km/l");