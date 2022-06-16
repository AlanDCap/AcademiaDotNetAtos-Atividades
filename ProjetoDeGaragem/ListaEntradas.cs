using System.IO;
using System.Windows.Forms;

namespace ProjetoDeGaragem
{
    public partial class ListaEntradas : Form
    {
        public ListaEntradas()
        {
            InitializeComponent();
            try
            {
                //Lê o arquivo de registro de entrada e retorna os valores registrados lá
                //referentes aos veículos que deram entrada na garagem no dia de expediente
                StreamReader leitor = new StreamReader("registroEntradas.dat");
                string linha;
                string[] dados;
                do
                {
                    linha = leitor.ReadLine();
                    dados = linha.Split(';');
                    Veiculo v = new Veiculo();
                    dg_listaEntradas.Rows.Add(dados[0], dados[1], dados[2], dados[3]);
                } while (!leitor.EndOfStream);
                leitor.Close();
            }
            catch (IOException e)
            {
                MessageBox.Show("Erro ao ler o arquivo: " + e.Message);
            }
        }
    }
}
