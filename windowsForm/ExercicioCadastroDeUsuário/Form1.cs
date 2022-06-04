using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioCadastroDeUsuário
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            bool status = false;
            if (cbStatus.Text == "Ativo")
                status = true;
            Usuario u = new Usuario(tbNome.Text, tbTelefone.Text, tbCpf.Text, tbLogin.Text, tbSenha.Text, status, cbTipo.Text);
            u.MostrarUsuário();
            
            MessageBox.Show("Cadastro realizado com sucesso");
            tbNome.Clear();
            tbTelefone.Clear();
            tbCpf.Clear();
            tbLogin.Clear();
            tbSenha.Clear();
            cbStatus.ResetText();
            cbTipo.ResetText();
        }
    }
}
