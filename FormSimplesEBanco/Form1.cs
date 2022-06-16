using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormSimplesEBanco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            //public Pessoa(string nome, int idade, string cpf, string endereco, string bairro, string cep, string cidade)
            Pessoa p = new Pessoa(tb_nome.Text, int.Parse(tb_idade.Text), tb_cpf.Text, tb_endereco.Text, tb_bairro.Text, tb_cep.Text, tb_cidade.Text);
            MessageBox.Show("Nome da pessoa: " + p.Nome + ", CPF: " + p.Cpf);
            p.gravarPessoa();
            tb_nome.Text = "";
            tb_idade.Text = "";
            tb_cpf.Text = "";
            tb_endereco.Text = "";
            tb_bairro.Text = "";
            tb_cep.Text = "";
            tb_cidade.Text = "";
        }
    }
}
