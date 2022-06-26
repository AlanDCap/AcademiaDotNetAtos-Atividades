using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace desafio_RegistroVendasComBD
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void tb_registrarCliente_Click(object sender, EventArgs e)
        {
            RegistroCliente registro = new RegistroCliente();
            registro.ShowDialog();
        }

        private void bt_registrarProduto_Click(object sender, EventArgs e)
        {
            RegistroProduto registro = new RegistroProduto();
            registro.ShowDialog();
        }

        private void bt_registrarVenda_Click(object sender, EventArgs e)
        {
            RegistroVendas registro = new RegistroVendas();
            registro.ShowDialog();
        }

       
    }
}
