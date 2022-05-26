using ClasseLivro;

string t, a;
int pag, ano, ed;
List<Livro> listaLivros = new List<Livro>();

Console.WriteLine("Digite o título do livro");
t = Console.ReadLine();

Console.WriteLine("Digite o autor do livro");
a = Console.ReadLine();

Console.WriteLine("Digite a quantidade de páginas");
pag = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o ano de publicação do livro");
ano = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a edição do livro");
ed = int.Parse(Console.ReadLine());

//parar armazenar em lista
listaLivros.Add(new Livro(t, a, pag, ano, ed));


Livro l1 = new Livro(t, a, pag, ano, ed);

l1.apresentaInfo();