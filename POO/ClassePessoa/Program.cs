Pessoa p = new Pessoa();

p.inserirPessoa("Alan Diogo Capelari", 33, 1.66, 50);

if (p.alimentado == true)
{
    Console.WriteLine($"{p.nome} está alimentada");
}
else
{
    Console.WriteLine($"{p.nome} ainda não comeu");
    p.comer();
}

p.andar();
public class Pessoa
{
    public Pessoa()
    { }

    public string nome;
    public int idade;
    public double altura;
    public float peso;
    public bool alimentado = false;

    public void inserirPessoa(string no, int id, double al, float pe)
    {
        nome = no;
        idade = id;
        altura = al;
        peso = pe;
    }

    public void andar()
    {
        Console.Write("Indique a distância, em metros, para andar:");
        float distancia = float.Parse(Console.ReadLine());
        Console.WriteLine($"{nome} andou por {Math.Round(distancia / 1.11 / 60)} minutos");
    }
    public void correr()
    {
        Console.Write("Indique a distância, em metros, para correr:");
        float distancia = float.Parse(Console.ReadLine());
        Console.WriteLine($"{nome} andou por {Math.Round(distancia / 2.22 / 60)} minutos");
    }
    public void comer()
    {
        Console.WriteLine($"{nome} está comendo");
        alimentado = true;
    }
}