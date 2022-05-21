/*Crie uma classe Carro com os atributos: modelo, marca, cor e placa. 
 * Crie um método para definir os atributos, 
 * outro método para ligar o carro 
 * e outro método para desligar o carro.*/

string a, b, x, d;

Carro c = new Carro();
Console.WriteLine("Informe a marca do carro: ");
a = Console.ReadLine();

Console.WriteLine("Informe modelo do carro: ");
b = Console.ReadLine();

Console.WriteLine("Informe a cor do carro: ");
x = Console.ReadLine();

Console.WriteLine("Informe a placa do carro: ");
d = Console.ReadLine();

c.inserirCarro(a, b, x, d);

Console.WriteLine($"A marca do carro é {c.marca}, o modelo do carro é {c.modelo}, a cor do carro é {c.cor}, a placa do carro é {c.placa}");
c.ligar();
if (c.ligado)
    Console.WriteLine("O carro está ligado");
else
    Console.WriteLine("O carro está desligado");

c.desligar();
if (c.ligado)
    Console.WriteLine("O carro está ligado");
else
    Console.WriteLine("O carro está desligado");


public class Carro
{
    public Carro()
    { }
        
    public string marca;
    public string modelo;
    public string cor;
    public string placa;

    public bool ligado;

    public void inserirCarro(string ma, string mo, string co, string pl)
    {
        marca = ma;
        modelo = mo;
        cor = co;
        placa = pl;
    }

    public void ligar()
    {
        Console.WriteLine("Ligando o carro");
        ligado = true;
    }
    public void desligar()
    {
        Console.WriteLine("Desligando o carro");
        ligado = false;
    }
}