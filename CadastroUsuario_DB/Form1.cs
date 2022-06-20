using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CadastroUsuario_DB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_adicionar_Click(object sender, EventArgs e)
        {
            string id = tb_idUsuario.Text;
            string nomeCompleto = tb_nomeUsuario.Text;
            string[] nomeSplit = nomeCompleto.Split(' ');
            string nome = nomeSplit[0];
            string sobrenome = nomeSplit[nomeSplit.Length - 1];
            string email = $"{sobrenome}.{nome}@ufn.edu.br";

            Usuario u = new Usuario(id, nomeCompleto, email);
            u.gravarPessoa();
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
             string sqlTexto = "select idUsuario, nomeCompleto, email from usuario;";
            SqlCommand command = new SqlCommand(sqlTexto, cn);
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            try
            {
                lv_tabelaCadastrados.Items.Clear();
                SqlDataReader leitor = command.ExecuteReader();
                int i = 0;
                while (leitor.Read())
                {
                    lv_tabelaCadastrados.Items.Add(leitor["idUsuario"].ToString());
                    lv_tabelaCadastrados.Items[i].SubItems.Add(leitor["nomeCompleto"].ToString());
                    lv_tabelaCadastrados.Items[i].SubItems.Add(leitor["email"].ToString());
                    i++;
                }
                cn.Close();
                //bt_conectar.Enabled = false;
                MessageBox.Show("Banco conectado com sucesso!", "Atenção");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemas de conexão com o Banco de Dados " + e.ToString(), "Alerta");
            }
        }
    }
}
