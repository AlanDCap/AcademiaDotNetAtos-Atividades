using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace desafio_RegistroVendasComBD
{
    internal class Venda
    {
        private int vendaId;
        private string codigoCliente;
        private double valorTotal;

        public int VendaId { get => vendaId; set => vendaId = value; }
        public string CodigoCliente { get => codigoCliente; set => codigoCliente = value; }
        public double ValorTotal { get => valorTotal; set => valorTotal = value; }

        public static int gravarVenda(string idCliente, double valorTotal)
        {
            int vendasID = 0;
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO vendas VALUES (@id_clientes, @dataVenda, @valor_total);" +
                "select cast (SCOPE_IDENTITY() as int);";
            command.Parameters.Add("@id_clientes", SqlDbType.VarChar);
            command.Parameters.Add("@dataVenda", SqlDbType.VarChar);
            command.Parameters.Add("@valor_total", SqlDbType.VarChar);
            command.Parameters[0].Value = idCliente;
            command.Parameters[1].Value = DateTime.Now;
            command.Parameters[2].Value = valorTotal;
            try
            {
                vendasID = (int)command.ExecuteScalar();
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                MessageBox.Show("Problemas de conexão com o Banco de Dados " + ex.ToString(), "Alerta");

            }
            finally
            {
                banco.fecharConexao();
            }
            return vendasID;
        }
    }
}
