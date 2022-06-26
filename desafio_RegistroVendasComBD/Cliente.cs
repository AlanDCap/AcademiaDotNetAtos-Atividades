using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace desafio_RegistroVendasComBD
{
    internal class Cliente
    {
        private int id_Cliente;
        private string nome;
        private string cpf;
        private string email;
        private string telefone;
        private string endereco;

        public int Id_Cliente { get => id_Cliente; set => id_Cliente = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Email { get => email; set => email = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Endereco { get => endereco; set => endereco = value; }

        /// <summary>
        /// Construtor usado para cadastrar novos clientes. 
        /// </summary>
        /// <param name="nome">Nome completo do cliente</param>
        /// <param name="cpf">Número de CPF, usado para gerar notas fiscais</param>
        /// <param name="email">e-mail principal para contato e envio de notificações</param>
        /// <param name="telefone">Telefone pessoal do cliente</param>
        /// <param name="endereco">Endereço do cliente, usado para envio de compras feitas online</param>
        public Cliente(string nome, string cpf, string email, string telefone, string endereco)
        {
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Telefone = telefone;
            Endereco = endereco;
        }
        /// <summary>
        /// Método para registrar um novo cliente no DB
        /// </summary>
        /// <returns></returns>
        public bool gravarCliente()
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;

            command.CommandText = "insert into clientes values (@cpf, @nome, @email, @telefone, @endereco);";
            command.Parameters.Add("@cpf", SqlDbType.VarChar);
            command.Parameters.Add("@nome", SqlDbType.VarChar);
            command.Parameters.Add("@email", SqlDbType.VarChar);
            command.Parameters.Add("@telefone", SqlDbType.VarChar);
            command.Parameters.Add("@endereco", SqlDbType.VarChar);
            command.Parameters[0].Value = Cpf;
            command.Parameters[1].Value = Nome;
            command.Parameters[2].Value = Email;
            command.Parameters[3].Value = Telefone;
            command.Parameters[4].Value = Endereco;
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