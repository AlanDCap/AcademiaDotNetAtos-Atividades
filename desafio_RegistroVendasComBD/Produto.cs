using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace desafio_RegistroVendasComBD
{
    internal class Produto
    {
        private string idProduto;
        private string codigoEAN;
        private string nome;
        private double preco;
        private double estoque;

        public string CodigoEAN { get => codigoEAN; set => codigoEAN = value; }
        public string Nome { get => nome; set => nome = value; }
        public double Preco { get => preco; set => preco = value; }
        public double Estoque { get => estoque; set => estoque = value; }
        public string IdProduto { get => idProduto; set => idProduto = value; }

        /// <summary>
        /// Construtor para gravar um novo produto no BD. 
        /// O id do produto é gerado pelo próprio BD
        /// </summary>
        /// <param name="codigoEAN">Código de barras do produto</param>
        /// <param name="nome">Nome do produto</param>
        /// <param name="preco">Preço unitário do produto</param>
        /// <param name="estoque">Quantidade de estoque inicial. Caso não haja estoque, insira o valor 0</param>
        public Produto(string codigoEAN, string nome, double preco, double estoque)
        {
            CodigoEAN = codigoEAN;
            Nome = nome;
            Preco = preco;
            Estoque = estoque;
        }
        /// <summary>
        /// Método para gravar um novo produto no DB
        /// </summary>
        /// <returns></returns>
        public bool gravarProduto()
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();

            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into produtos values (@nome, @cod_ean, @preco, @estoque);";
            command.Parameters.Add("@nome", SqlDbType.VarChar);
            command.Parameters.Add("@cod_ean", SqlDbType.VarChar);
            command.Parameters.Add("@preco", SqlDbType.VarChar);
            command.Parameters.Add("@estoque", SqlDbType.VarChar);
            command.Parameters[0].Value = Nome;
            command.Parameters[1].Value = CodigoEAN;
            command.Parameters[2].Value = Preco;
            command.Parameters[3].Value = Estoque;

            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                MessageBox.Show("Registro realizado com sucesso", "Aviso");
                return true;

            }
            catch (Exception ex)
            {
                tran.Rollback();
                MessageBox.Show("Problemas de conexão com o Banco de Dados " + ex.ToString(), "Alerta");
                return false;
            }
            finally
            {
                banco.fecharConexao();
            }
        }
    }
}