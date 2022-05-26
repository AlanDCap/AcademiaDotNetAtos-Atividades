using ProjetoOO;

Lampada l = new Lampada(6, "Seagate");
l.ligar();
Console.WriteLine("O atributo ligado é = " + l.Ligado + " Potência = " + l.Potencia);

l.desligar();
Console.WriteLine("O atributo ligado é = " + l.Ligado);
double n;
n = l.retornaPotencia();
Console.WriteLine("A potência da lâmpada é " + n);
