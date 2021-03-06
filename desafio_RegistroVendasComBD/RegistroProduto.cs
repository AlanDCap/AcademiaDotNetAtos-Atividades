using System;
using System.Windows.Forms;

namespace desafio_RegistroVendasComBD
{
    public partial class RegistroProduto : Form
    {
        public RegistroProduto()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Botão para confirmar o registro de um novo produto. Chama o método gravarProduto.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_confirmar_Click(object sender, EventArgs e)
        {
            //Tratamento para evitar inserção de campos vazios no BD
            if (tb_produto.Text.ToString() == "" || tb_codigo.Text.ToString() == "" || tb_preco.Text.ToString() == "" || tb_estoque.Text.ToString() == "")
            {
                MessageBox.Show("Todos os campos precisam ser preenchidos para registrar um produto");
                return;
            }

            Produto p = new Produto(tb_produto.Text.ToUpper(), tb_codigo.Text, double.Parse(tb_preco.Text), double.Parse(tb_estoque.Text));
            p.gravarProduto();

            tb_produto.Clear();
            tb_codigo.Clear();
            tb_preco.Clear();
            tb_estoque.Clear();
        }

        /// <summary>
        /// Botão para fechar o form atual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
