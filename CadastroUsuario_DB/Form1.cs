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
        /// <summary>
        /// Adiciona um novo usuário no banco de dados com os parâmetros ID, 
        /// Nome, Endereço e Telefone. Um email será gerado e registrado automaticamente pelo sistema.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_adicionar_Click(object sender, EventArgs e)
        {
            string id = tb_idUsuario.Text;
            string nomeCompleto = tb_nomeUsuario.Text;
            string[] nomeSplit = nomeCompleto.Split(' ');
            string nome = nomeSplit[0];
            string sobrenome = nomeSplit[nomeSplit.Length - 1];
            string email = $"{sobrenome}.{nome}@ufn.edu.br";
            string telefone = tb_telefone.Text;
            string endereco = tb_endereco.Text;

            Usuario u = new Usuario(id, nomeCompleto, email, telefone, endereco);
            
            ///Método para gravar um usuário.
            u.gravarPessoa();
            MessageBox.Show("Operação realizada com sucesso!");
            ///Ao final, realiza a limpeza do form para receber uma nova entrada.
            tb_idUsuario.Clear();
            tb_nomeUsuario.Clear();
            tb_endereco.Clear();
            tb_telefone.Clear();
        }

        /// <summary>
        /// Remove do banco de dados o usuário cujo ID está selecionado na tabela do listview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_remover_Click(object sender, EventArgs e)
        {
            string idUsuario = lv_tabelaCadastrados.SelectedItems[0].Text;
            Usuario u = new Usuario();

            ///método que remove usuário do banco de dados.
            u.apagarRegistro(idUsuario);
            MessageBox.Show("Operação realizada com sucesso!");
        }
        /// <summary>
        /// Conecta com o banco de dados e popula a tabela do listview com as informações vindas de lá.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_sincronizar_Click(object sender, EventArgs e)
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            string sqlTexto = "select idUsuario, nomeCompleto, email, telefone, endereco from usuario;";
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
                    lv_tabelaCadastrados.Items[i].SubItems.Add(leitor["telefone"].ToString());
                    lv_tabelaCadastrados.Items[i].SubItems.Add(leitor["endereco"].ToString());
                    i++;
                }
                cn.Close();
                
                MessageBox.Show("Operação realizada com sucesso!", "Atenção");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemas de conexão com o Banco de Dados " + ex.ToString(), "Alerta");
            }
        }
    }
}
