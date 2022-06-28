using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace desafio_RegistroVendasComBD
{
    public partial class RegistroVendas : Form
    {
        public RegistroVendas()
        {
            InitializeComponent();
            numeric_qtd.Value = 1;
            lbl_totalVenda.Text = "R$ 0,00";
        }

        /// <summary>
        /// Método para atualizar a label posicionada acima do datagrid que mostra o valor total da venda.
        /// </summary>
        public void atualizarLblVenda()
        {
            double valorTotal = 0;
            foreach (DataGridViewRow r in dg_listaVendas.Rows)
            {
                double valorVendaItem = (double)r.Cells["dg_valorTotal"].Value;
                valorTotal = valorTotal + valorVendaItem;
                lbl_totalVenda.Text = $"R$ {Math.Round(valorTotal, 2)}";
            }
            if (dg_listaVendas.Rows.Count == 0)
                lbl_totalVenda.Text = "R$ 0,00";
        }

        /// <summary>
        /// Método para verificar o estoque do produto, é chamado toda vez que são adicionados itens ao datagrid.
        /// </summary>
        /// <returns></returns>
        public bool verificaEstoque()
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            string sqlTexto = $"SELECT * FROM produtos WHERE (nome = '{tb_produto.Text}' OR cod_ean = '{tb_codigo.Text}');";
            SqlCommand command = new SqlCommand(sqlTexto, cn);
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            try
            {
                SqlDataReader leitor = command.ExecuteReader();
                leitor.Read();
                int estoque = int.Parse(leitor["estoque"].ToString());
                cn.Close();
            if (estoque < numeric_qtd.Value)
            {
                MessageBox.Show($"Produto sem estoque suficiente. Quantidade em estoque: {estoque}");
                return false;
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemas de conexão com o Banco de Dados " + ex.ToString(), "Alerta");
            }
            return true;
        }
        
        /// <summary>
        /// Botão para adicionar itens ao datagrid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_adicionar_Click(object sender, System.EventArgs e)
        {
            if (numeric_qtd.Value == 0)
            {
                MessageBox.Show("Insira a quantidade", "Alerta");
                return;
            }
            //Tratamento para evitar inserção de campos vazios no BD
            if (tb_produto.Text.ToString() == "" && tb_codigo.Text.ToString() == "")
            {
                MessageBox.Show("Insira o código do produto ou o nome para adicioná-lo a lista de vendas");
                return;
            }
            if (verificaEstoque() == false)
            return;

            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            string sqlTexto = $"SELECT * FROM produtos WHERE (nome = '{tb_produto.Text}' OR cod_ean = '{tb_codigo.Text}');";
            SqlCommand command = new SqlCommand(sqlTexto, cn);
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            try
            {
                SqlDataReader leitor = command.ExecuteReader();
                leitor.Read();

                double valorTotal = (int)numeric_qtd.Value * double.Parse(leitor["preco"].ToString());
                dg_listaVendas.Rows.Add(leitor["cod_ean"].ToString(), leitor["nome"].ToString(), (int)numeric_qtd.Value, double.Parse(leitor["preco"].ToString()), valorTotal, int.Parse(leitor["id_produto"].ToString()));
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemas de conexão com o Banco de Dados " + ex.ToString(), "Alerta");
            }
            tb_codigo.Clear();
            tb_produto.Clear();
            numeric_qtd.Value = 1;
            atualizarLblVenda();
        }
                        
        /// <summary>
        /// Botão para remover itens do datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_remover_Click(object sender, EventArgs e)
        {
            //Tratamento para evitar a quebra do programa em caso de o usuário
            //clicar no botão remover sem que nenhuma linha esteja selecionada.
            try
            {
                DataGridViewRow linhaSelecionada = dg_listaVendas.CurrentRow;
                int indice = linhaSelecionada.Index;
                dg_listaVendas.Rows.RemoveAt(indice);
                atualizarLblVenda();
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione o item a ser removido", "Alerta");
            }
        }

        /// <summary>
        /// Botão para registrar vendas. Os dados do datagrid serão enviados 
        /// ao BD para duas tabelas, uma de vendas que armazena o idCliente, 
        /// data e valor total da venda, e outra que armazena os itens vendidos 
        /// com suas respectivas quantidades e valores. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_registrarVenda_Click(object sender, EventArgs e)
        {
            //Tratamento para evitar inserção de campos vazios no BD
            if (tb_IDcliente.Text.ToString() == "")
            {
                MessageBox.Show("Insira o ID do cliente para registrar a venda");
                return;
            }
            //Armazena os itens do datagrid numa lista de objetos ItemVenda
            //A lista será passada como argumento para o método gravarItensVendidos
            List<ItemVenda> itensVendidos = new List<ItemVenda>();
            string idCliente = tb_IDcliente.Text;
            double valorTotal = 0;

            foreach (DataGridViewRow r in dg_listaVendas.Rows)
            {
                double valorVendaItem = (double)r.Cells["dg_valorTotal"].Value;
                valorTotal = valorTotal + valorVendaItem;
                ItemVenda iv = new ItemVenda(r.Cells["dg_codigo"].Value.ToString(),(double)r.Cells["dg_precoUn"].Value,(int)r.Cells["dg_qtd"].Value,(int)r.Cells["dg_idProduto"].Value);

                itensVendidos.Add(iv);
            }
            //método que grava a venda no BD, registrar o valor total
            //de todos os itens vendidos, junto com a data e o id do cliente
            int vendasID = Venda.gravarVenda(idCliente, valorTotal);

            //Registra os itens que foram vendidos no DB, recebe como
            //fk o id da venda gerado durante o registro de venda
            ItemVenda.gravarItensVendidos(itensVendidos, vendasID); 

            tb_codigo.Clear();
            tb_IDcliente.Clear();
            tb_produto.Clear();
            numeric_qtd.ResetText();
            MessageBox.Show("Venda registrada com sucesso");

            dg_listaVendas.Rows.Clear();
            lbl_totalVenda.Text = "R$ 0,00"; ;
        }
    }
}
