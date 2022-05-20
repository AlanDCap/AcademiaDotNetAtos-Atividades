/*8) Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit. 
A fórmula da conversão é F=(9*C+160)/5.*/

float temperaturaCelsius, temperaturaFahrenheit;

Console.WriteLine("Conversor de temperatura em Celsius para Fahrenheit");
Console.Write("Insira o valor da temperatura em graus Celsius: ");
temperaturaCelsius = float.Parse(Console.ReadLine());

temperaturaFahrenheit = ((9 * temperaturaCelsius) + 160)/5;
Console.WriteLine(temperaturaCelsius + "º Celsius equivale a " + temperaturaFahrenheit + "º em Fahrenheit");