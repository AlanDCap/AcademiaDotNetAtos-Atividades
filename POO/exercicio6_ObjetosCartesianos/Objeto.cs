namespace exercicio6_ObjetosCartesianos
{
    internal class Objeto
    {
        private int posX;
        private int posY;

        public int PosX { get => posX; set => posX = value; }
        public int PosY { get => posY; set => posY = value; }

        public Objeto(int n)
        {
            Random random = new Random();
            this.posX = random.Next(1, 255);
            this.posY = random.Next(1, 255);

        }

    }
}

