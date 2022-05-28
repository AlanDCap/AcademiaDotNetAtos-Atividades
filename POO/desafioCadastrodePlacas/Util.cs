namespace desafioCadastrodePlacas
{
    internal class Util
    {
        public static void carregarListas(List<Carro> lista)
        {
            StreamReader leitor;
            string nomeArquivo = "garagem.dat";
            string[] vetorDados;
            try
            {
                leitor = new StreamReader(nomeArquivo);
                do
                {
                    vetorDados = leitor.ReadLine().Split(";");
                    lista.Add(new Carro(vetorDados[0], vetorDados[1]));
                } while (!leitor.EndOfStream);
                leitor.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Arquivo de usuários com problemas ou inexistente");
            }
        }
        public static void exibirLista(string frase, List<Carro> lista)
        {
            Console.WriteLine(frase);
            foreach (Carro i in lista)
            {
                Console.WriteLine(i.Placa + " - " + i.HorarioDeEntrada);
            }
        }

        private static void gravarArquivo(Carro objeto)
        {
            try
            {
                StreamWriter escritor = new StreamWriter("garagem.dat", true);

                escritor.WriteLine(objeto.Placa + ";" + objeto.HorarioDeEntrada);
                escritor.Flush();
                escritor.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Arquivo de usuários com problemas");
            }
        }

        public static void registrarEntrada(string frase, List<Carro> lista)
        {
                string placa;
            do
            {
                Console.WriteLine(frase);
                Console.Write("Digite a placa do carro: ");
                placa = Console.ReadLine().ToUpper();
            } while (placa.Length < 7);

            Carro objeto = new Carro(placa);

            lista.Add(objeto);
            //gravar no arquivo
            Util.gravarArquivo(objeto);
        }
    }
}
