/*12) Um motorista de taxi deseja calcular o rendimento de seu carro na praça. Sabendo-se que o preço do combustível é de R$6,90, escreva um algoritmo para ler a 
marcação do odômetro (marcador de quilometragem) no início do dia, a marcação no final do dia, o número de litros de combustível gasto e o valor total (R$) recebido 
dos passageiros. Calcule e escreva a média do consumo em Km/l e o lucro líquido do dia.

Fórmulas: Total quilometragem =  marcação odômetro final do dia - marcação odômetro inicio do dia 

Média do consumo = Total quilometragem/ quantidade de combustível gasto

Lucro do dia = Valor total recebido - (quantidade de combustível gasto * 6,90)*/

double kminicial, kmfinal, kmrodados, consCombustivel, precolitro, faturamento, lucro;

Console.WriteLine("Verifique quanto obteve de lucro ao final do seu dia como motorista particular");
Console.WriteLine("Informe a quilometragem do seu carro no início de seu expediente: ");
kminicial = double.Parse(Console.ReadLine());

Console.WriteLine("Informe a quilometragem do seu carro ao final do seu expediente: ");
kmfinal = double.Parse(Console.ReadLine()); //seria necessário inserir um filtro para evitar que o valor final de km seja inferior ao valor inicial, mas por enquanto não conheço uma boa forma

Console.WriteLine("Informe quantos litros de combustível gastou ao longo do dia: ");
consCombustivel = double.Parse(Console.ReadLine());

Console.WriteLine("Informe o preço do litro de combustível: ");
precolitro = double.Parse(Console.ReadLine());

Console.WriteLine("Informe quanto ganhou com as corridas do dia: ");
faturamento = double.Parse(Console.ReadLine());

kmrodados = kmfinal - kminicial;
lucro = (faturamento - (consCombustivel * precolitro));

Console.WriteLine("Seu carro está fazendo a média de " + Math.Round((kmrodados / consCombustivel), 2) + " km/l," + " e o seu lucro hoje foi de R$ " + Math.Round(lucro, 2));
