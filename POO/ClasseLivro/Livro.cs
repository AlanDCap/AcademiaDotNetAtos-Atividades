namespace ClasseLivro
{
    internal class Livro
    {
        //atributos
        private string titulo;
        private string autor;
        private int paginas;
        private int ano;
        private int edicao;

        public Livro(string titulo, string autor, int paginas, int ano, int edicao)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.paginas = paginas;
            this.ano = ano;
            this.edicao = edicao;
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public int Paginas { get => paginas; set => paginas = value; }
        public int Ano { get => ano; set => ano = value; }
        public int Edicao { get => edicao; set => edicao = value; }

        public void apresentaInfo()
        {
            Console.WriteLine($"O livro {titulo} é do autor {autor}, tem {paginas} páginas, foi publicado no ano {ano}, e sua edição é {edicao}");
        }
    }
}
