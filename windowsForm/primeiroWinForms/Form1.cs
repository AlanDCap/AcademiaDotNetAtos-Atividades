using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primeiroWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BT1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Cliquei no botão OK");
            MessageBox.Show($"O nome digitado pelo usuário é: {txtNome.Text} e o e-mail digitado é: {txtEmail.Text}. " +
                $"O endereço é rua {txtEndereco.Text}, Nº {txtNumeroCasa.Text}, e Bairro {txtBairro.Text}, " +
                $"que fica na cidade {txtCidade.Text}. Sexo {txtSexo.Text} ");
            MessageBox.Show("Cadastro efetuado");
            txtNome.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            txtEndereco.Clear();
            txtNumeroCasa.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtSexo.Clear();
            lblMsg.Text = "Cadastro realizado com sucesso";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliquei no botão Cancelar.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bem vindo a esse lindo programa");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblCidade_Click(object sender, EventArgs e)
        {

        }

        private void lblSexo_Click(object sender, EventArgs e)
        {

        }
    }
}
