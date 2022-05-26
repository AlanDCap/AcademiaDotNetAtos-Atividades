namespace exercicio1_PersonagemMaisPoderoso
{
    internal class Personagem
    {
        /// <summary>
        /// armazena o nome do personagem
        /// </summary>
        string nome;

        /// <summary>
        /// armazena o poder de luta do personagem
        /// </summary>
        int poder;

        public Personagem()
        {
        }

        public Personagem(string nome, int poder)
        {
            this.Nome = nome;
            this.Poder = poder;
        }
        /// <summary>
        /// propriedade de acesso ao nome
        /// </summary>
        public string Nome { get => nome; set => nome = value; }
        /// <summary>
        /// propriedade de acesso ao poder
        /// </summary>
        public int Poder { get => poder; set => poder = value; }

        public void exibirDados()
        {
            Console.WriteLine($"Nome do personagem: {nome}, Poder de luta: {poder}");
        }
        public static void mostrarMaisPoderoso(List<Personagem> lista)
        {
            Personagem maisPoderoso = lista[0];
            foreach (Personagem i in lista)
            {
                if (i.Poder > maisPoderoso.Poder)
                {
                    maisPoderoso = i;
                }
            }

            Console.WriteLine("O mais poderoso é: ");
            maisPoderoso.exibirDados();
        }
        public static string pegarMaisPoderoso(List<Personagem> listatmp)
        {
            Personagem maisPoderoso = listatmp[0];
            foreach (Personagem i in listatmp)
            {
                if (i.Poder > maisPoderoso.Poder)
                {
                    maisPoderoso = i;
                }
            }
            return $"O mais poderoso é {maisPoderoso.nome}, com poder de luta igual a {maisPoderoso.poder}";
            
        }
    }
}