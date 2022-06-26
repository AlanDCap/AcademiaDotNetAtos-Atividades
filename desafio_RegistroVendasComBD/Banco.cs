using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace desafio_RegistroVendasComBD
{
    internal class Banco
    {
        private string stringConexao = "Data Source=ALITA; Initial Catalog=vendas_db; TrustServerCertificate=True; Integrated Security = True";
        private SqlConnection cn;
        private void conexao()
        {
            cn = new SqlConnection(stringConexao);
        }

        public SqlConnection abrirConexao()
        {
            try
            {
                conexao();
                cn.Open();
                return cn;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemas de conexão com o Banco de Dados " + ex.ToString(), "Alerta");
                return null;
            }
        }

        public void fecharConexao()
        {
            try
            {
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemas de conexão com o Banco de Dados " + ex.ToString(), "Alerta");
                return;
            }
        }
    }
}
