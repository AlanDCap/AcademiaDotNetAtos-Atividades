namespace exercicio4_Asteroides
{
    internal class Asteroide
    {
        private int tamanho;
        private int velocidade;
        private int energia;
        private int posicaoX;
        private int posicaoY;

        /// <summary>
        /// Construtor da classe Asteroide vazio
        /// </summary>
        public Asteroide() { }


        /// <summary>
        /// Construtor da classe asteróide, com requisito de todos os parâmetros
        /// </summary>
        /// <param name="tamanho"></param>
        /// <param name="velocidade"></param>
        /// <param name="energia"></param>
        /// <param name="posicaoX"></param>
        /// <param name="posicaoY"></param>
        public Asteroide(int tamanho, int velocidade, int energia, int posicaoX, int posicaoY)
        {
            Tamanho = tamanho;
            Velocidade = velocidade;
            Energia = energia;
            PosicaoX = posicaoX;
            PosicaoY = posicaoY;
        }
        /// <summary>
        /// Construtor da classe asteróide apenas com os parâmetros de posição
        /// </summary>
        /// <param name="posicaoX"></param>
        /// <param name="posicaoY"></param>
        public Asteroide(int posicaoX, int posicaoY)
        {
            Random r = new Random();
            Tamanho = r.Next(1, 10);
            Velocidade = r.Next(1, 5);
            Energia = r.Next(1, 5);
            PosicaoX = posicaoX;
            PosicaoY = posicaoY;
        }

        public int PosicaoX { get => posicaoX; set => posicaoX = value; }
        public int PosicaoY { get => posicaoY; set => posicaoY = value; }
        public int Tamanho { get => tamanho; set => tamanho = value; }
        public int Velocidade { get => velocidade; set => velocidade = value; }
        public int Energia { get => energia; set => energia = value; }

    }
}
