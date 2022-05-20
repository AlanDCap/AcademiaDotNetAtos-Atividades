/*11) Escreva um algoritmo para ler o número de eleitores de um município, o número de votos brancos, nulos e válidos. Calcule e escreva o percentual que cada um 
representa em relação ao total de eleitores.*/

double qtdEleitores, vtbrancos, vtnulos, vtabstencoes, vtvalidos, percentualbrancos, percentualnulos, percentualvalidos, percentualabestencoes;

Console.WriteLine("Verifique o percentual de votos válidos, brancos, nulos e abstenções de voto de um determinado município");
Console.Write("Informe a quantidade de eleitores do município: ");
qtdEleitores = double.Parse(Console.ReadLine());

Console.Write("Informe a quantidade de votos em branco: ");
vtbrancos = double.Parse(Console.ReadLine());

Console.Write("Informe a quantidade de votos nulos: ");
vtnulos = double.Parse(Console.ReadLine());

Console.Write("Informe a quantidade de abstenções de voto: ");
vtabstencoes = double.Parse(Console.ReadLine());

percentualbrancos = ((vtbrancos / qtdEleitores) * 100);
Console.WriteLine("O percentual de votos em branco foi de " + Math.Round(percentualbrancos, 2) + "%");

percentualnulos = ((vtnulos / qtdEleitores) * 100);
Console.WriteLine("O percentual de votos nulos foi de " + Math.Round(percentualnulos, 2) + "%");

percentualabestencoes = ((vtabstencoes / qtdEleitores) * 100);
Console.WriteLine("O percentual de abstenções de votos foi de " + Math.Round(percentualabestencoes, 2) + "%");

vtvalidos = qtdEleitores - vtbrancos - vtnulos - vtabstencoes;
percentualvalidos = ((vtvalidos / qtdEleitores) * 100);
Console.WriteLine("O total de votos válidos foi de " + Math.Round(percentualvalidos, 2) + "%");