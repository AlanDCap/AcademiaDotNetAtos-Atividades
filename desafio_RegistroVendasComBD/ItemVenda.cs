using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace desafio_RegistroVendasComBD
{
    internal class ItemVenda
    {
        private string codigo;
        private double precoUn;
        private int qtd;
        private double valorTotal;
        private int idProduto;

        public string Codigo { get => codigo; set => codigo = value; }
        public double PrecoUn { get => precoUn; set => precoUn = value; }
        public int Qtd { get => qtd; set => qtd = value; }
        public double ValorTotal { get => valorTotal; set => valorTotal = value; }
        public int IdProduto { get => idProduto; set => idProduto = value; }

        /// <summary>
        /// Construtor usado para registro de vendas no BD.
        /// </summary>
        /// <param name="codigo">Código EAN do produto</param>
        /// <param name="precoUn">Valor unitário do item</param>
        /// <param name="qtd">Quantidade selecionada para vendas</param>
        public ItemVenda(string codigo, double precoUn, int qtd, int idProduto)
        {
            Codigo = codigo;
            PrecoUn = precoUn;
            Qtd = qtd;
            ValorTotal = precoUn * qtd;
            IdProduto = idProduto;
        }
        /// <summary>
        /// Método para registrar a venda no BD, recebe ID do cliente e o valor total da venda.
        /// </summary>
        /// <param name="idCliente"></param>
        /// <param name="valorTotal"></param>
        /// <returns></returns>
        public static bool gravarVenda(string idCliente, double valorTotal)
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO vendas VALUES (@id_clientes, @dataVenda, @valor_total);";
            command.Parameters.Add("@id_clientes", SqlDbType.VarChar);
            command.Parameters.Add("@dataVenda", SqlDbType.VarChar);
            command.Parameters.Add("@valor_total", SqlDbType.VarChar);
            command.Parameters[0].Value = idCliente;
            command.Parameters[1].Value = DateTime.Now;
            command.Parameters[2].Value = valorTotal;
            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
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
        /// <summary>
        /// Método que grava a lista de itens vendidos, armazenando um 
        /// histórico de saída. Recebe como argumento uma lista de 
        /// objetos gerados pelo construtor ItemVenda. Este método também atualiza o estoque.
        /// </summary>
        /// <param name="lista">Lista que armazena os itens do datagrid para então enviar ao DB.</param>
        /// <returns></returns>
        public static bool gravarItensVendidos(List<ItemVenda> itensVendidos)
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();

            foreach (ItemVenda item in itensVendidos)
            {
                SqlCommand command = new SqlCommand();
                command.Connection = cn;
                command.Transaction = tran;
                command.CommandType = CommandType.Text;
                command.CommandText = $"update produtos set estoque = estoque - {item.Qtd} where id_produto = '{item.IdProduto}'; INSERT INTO item_venda values (@id_produto, @valor_un, @qtd, @valor_total);";
                command.Parameters.AddWithValue("@id_produto", item.IdProduto);
                command.Parameters.AddWithValue("@valor_un", item.PrecoUn);
                command.Parameters.AddWithValue("@qtd", item.Qtd);
                command.Parameters.AddWithValue("@valor_total", item.ValorTotal);
                command.ExecuteNonQuery();
            }
            try
            {
                tran.Commit();
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
