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
        private string telefone;
        private string endereco;

        public string IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string NomeUsuario { get => nomeUsuario; set => nomeUsuario = value; }
        public string Email { get => email; set => email = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Endereco { get => endereco; set => endereco = value; }

        public Usuario()
        {

        }

        /// <summary>
        /// Construtor usado para gravar usuários no banco de dados
        /// </summary>
        /// <param name="idUsuario">Chave identificadora do usuário, no banco de dados é a primary key</param>
        /// <param name="nomeUsuario">Nome completo do usuário</param>
        /// <param name="email">email gerado pelo programa para o usuário acessar o sistema</param>
        /// <param name="telefone">Telefone de contato do usuário</param>
        /// <param name="endereco">Endereço do usuário</param>
        public Usuario(string idUsuario, string nomeUsuario, string email, string telefone, string endereco)
        {
            IdUsuario = idUsuario;
            NomeUsuario = nomeUsuario;
            Email = email;
            Telefone = telefone;
            Endereco = endereco;
        }
        /// <summary>
        /// Conecta com o banco de dados e registra um usuário nele.
        /// </summary>
        /// <returns></returns>
        public bool gravarPessoa()
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;

            //Linha de comando do sql server management, se houver
            //alterações na tabela do banco de dados é necessário alterar
            //aqui para que o cadastro permaneça coerente
            command.CommandText = "insert into usuario values (@idUsuario, @nomeCompleto, @email, @telefone, @endereco);";
            command.Parameters.Add("@idUsuario", SqlDbType.VarChar);
            command.Parameters.Add("@nomeCompleto", SqlDbType.VarChar);
            command.Parameters.Add("@email", SqlDbType.VarChar);
            command.Parameters.Add("@telefone", SqlDbType.VarChar);
            command.Parameters.Add("@endereco", SqlDbType.VarChar);
            command.Parameters[0].Value = IdUsuario;
            command.Parameters[1].Value = NomeUsuario;
            command.Parameters[2].Value = Email;
            command.Parameters[3].Value = Telefone;
            command.Parameters[4].Value = Endereco;
            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                banco.fecharConexao();
            }

        }
        /// <summary>
        /// Conecta com o banco de dados e remove um registro a partir do ID registrado
        /// </summary>
        /// <param name="idUsuario">ID do banco de dados, ele é a primary key</param>
        /// <returns></returns>
        public bool apagarRegistro(string idUsuario)
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = $"delete usuario where idUsuario= '{idUsuario}';";
            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception)
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