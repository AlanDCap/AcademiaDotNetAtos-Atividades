using System;
using System.Data; //necessário para realizar conexão com o banco
using System.Data.SqlClient; //necessário para realizar conexão com o banco

namespace CadastroUsuario_DB
{
    internal class Banco
    {
        private string stringConexao = "Data Source=ALITA; Initial Catalog=usuarios_db; TrustServerCertificate=True;Integrated Security = True";
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
            catch
            {
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
                return;
            }
        }

        public DataTable executarConsultaGenerica(string sql)
        {
            try
            {
                abrirConexao();

                SqlCommand command = new SqlCommand(sql, cn);
                command.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dt = new DataTable();
                adapter.Fill(dt);//adaptar preenche o datatable com os dados do command

                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                fecharConexao();
            }
        }
    }
}
