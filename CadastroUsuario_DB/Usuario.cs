using System;
using System.Data; //necessário para realizar conexão com o banco

using System.Data.SqlClient; //necessário para realizar conexão com o banco


namespace CadastroUsuario_DB
{
    internal class Usuario
    {
        private string idUsuario;
        private string nomeUsuario;
        private string email;

        public string IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string NomeUsuario { get => nomeUsuario; set => nomeUsuario = value; }
        public string Email { get => email; set => email = value; }

        public Usuario(string idUsuario, string nomeUsuario, string email)
        {
            IdUsuario = idUsuario;
            NomeUsuario = nomeUsuario;
            Email = email;
        }

        public bool gravarPessoa()
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into usuario values (@idUsuario, @nomeCompleto, @email);";
            command.Parameters.Add("@idUsuario", SqlDbType.VarChar);
            command.Parameters.Add("@nomeCompleto", SqlDbType.VarChar);
            command.Parameters.Add("@email", SqlDbType.VarChar);
            command.Parameters[0].Value = IdUsuario;
            command.Parameters[1].Value = NomeUsuario;
            command.Parameters[2].Value = Email;
            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                banco.fecharConexao();
            }
        }
    }
}