using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFCriptografia
{
    public partial class Form1 : Form
    {
        Assimetrica a;
        Simetrica s;
        public Form1()
        {
            InitializeComponent();
            a = new Assimetrica();
            s = new Simetrica();
        }

        private void bt_criptografar_Click(object sender, EventArgs e)
        {
            string frase;
            frase = tb_frase.Text;
            lbl_fraseCriptografada.Text = a.encrypt(frase);
        }

        private void bt_descriptografar_Click(object sender, EventArgs e)
        {
            string frase = lbl_fraseCriptografada.Text;
            lbl_fraseDescriptografada.Text = a.decrypt(frase);
        }

        private void bt_criptografarSimetrico_Click(object sender, EventArgs e)
        {
            string frase;
            frase = tb_frase.Text;
            lbl_fraseCriptografada.Text = s.EncryptData(frase, tb_chave.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string frase = lbl_fraseCriptografada.Text;
                lbl_fraseDescriptografada.Text = s.DecryptData(frase, tb_chave.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor verifique se a chave de descriptografia", "Alerta");
            }
        }
    }
}
