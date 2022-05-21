Lampada l = new Lampada();
l.ligar();
l.potencia = 9;
Console.WriteLine("O atributo ligado é = "+l.ligado+ " Potência = " + l.potencia);

l.desligar();
Console.WriteLine("O atributo ligado é = " + l.ligado);
double n;
n = l.retornaPotencia();
Console.WriteLine("A potência da lâmpada é " + n);

public class Lampada
{
    public bool ligado;
    public double potencia;

    //visibilidade (public || private || protected); void = tipo de retorno, retorna nada; int retorna inteiro; double retorna double.
    public void ligar() 
    {
        Console.WriteLine("A lâmpada está sendo ligada");
        ligado = true; 
    }
    public void desligar() 
    {
        Console.WriteLine("A lâmpada está sendo desligada");
        ligado = false;
    }
    public bool estaLigada ()
    { 
        return ligado; 
    }
    public double retornaPotencia()
    {
        return potencia;
    }
    public Lampada() { }
}