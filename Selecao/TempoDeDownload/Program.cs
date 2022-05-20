/*14 - Faça um programa que peça o tamanho de um arquivo para download (em MB) e a velocidade de um 
link de Internet (em Mbps). Em seguida, calcule e informe o tempo aproximado de download 
do arquivo usando este link (em minutos).*/

double tamanhoArquivo, velocidade, tempo;

Console.WriteLine("Verifiqe o tempo de download de um arquivo da internet.\nInforme o tamanho do arquivo em MB");
tamanhoArquivo = double.Parse(Console.ReadLine());

Console.WriteLine("Agora informe a velocidade da conexão em Mbps");
velocidade = double.Parse(Console.ReadLine());

tempo = (tamanhoArquivo / (velocidade * 0.125) / 60);
Console.WriteLine("O tempo médio de download é de " + tempo + " minuto(s) aproximadamente");