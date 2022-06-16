using System;
using System.Data; //necessário para realizar conexão com o banco
using System.Data.SqlClient; //necessário para realizar conexão com o banco

namespace FormSimplesEBanco
{
    internal class Pessoa
    {
        private string nome;
        private int idade;
        private string cpf;
        private string endereco;
        private string bairro;
        private string cep;
        private string cidade;

        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Cidade { get => cidade; set => cidade = value; }

        public Pessoa(string nome, int idade, string cpf, string endereco, string bairro, string cep, string cidade)
        {
            Nome = nome;
            Idade = idade;
            Cpf = cpf;
            Endereco = endereco;
            Bairro = bairro;
            Cep = cep;
            Cidade = cidade;
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
            command.CommandText = "insert into pessoa values (@nome, @idade, @cpf, @endereco, @bairro, @cep, @cidade);";
            command.Parameters.Add("@nome", SqlDbType.VarChar);
            command.Parameters.Add("@idade", SqlDbType.Int);
            command.Parameters.Add("@cpf", SqlDbType.VarChar);
            command.Parameters.Add("@endereco", SqlDbType.VarChar);
            command.Parameters.Add("@bairro", SqlDbType.VarChar);
            command.Parameters.Add("@cep", SqlDbType.VarChar);
            command.Parameters.Add("@cidade", SqlDbType.VarChar);
            command.Parameters[0].Value = Nome;
            command.Parameters[1].Value = Idade;
            command.Parameters[2].Value = Cpf;
            command.Parameters[3].Value = Endereco;
            command.Parameters[4].Value = Bairro;
            command.Parameters[5].Value = Cep;
            command.Parameters[6].Value = Cidade;
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