using System;
using System.Windows.Forms;

namespace desafio_RegistroVendasComBD
{
    public partial class RegistroCliente : Form
    {
        public RegistroCliente()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Botão para confirmar o cadastro de um novo cliente, chama o método gravarCliente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_confirmar_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente(tb_nome.Text.ToUpper(), tb_cpf.Text, tb_email.Text.ToLower(), tb_telefone.Text, tb_endereco.Text.ToUpper());
            c.gravarCliente();

            tb_nome.Clear();
            tb_cpf.Clear();
            tb_email.Clear();
            tb_telefone.Clear();
            tb_endereco.Clear();
        }
        /// <summary>
        /// Botão para fechar o form atual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
