using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioCadastroDeUsuário
{
    internal class Usuario
    {
        private string nome;
        private string telefone;
        private string cpf;
        private string login;
        private string senha;
        private bool status;
        private string tipo;
        
        public string Nome { get => nome; set => nome = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Login { get => login; set => login = value; }
        public string Senha { get => senha; set => senha = value; }
        public bool Status { get => status; set => status = value; }
        public string Tipo { get => tipo; set => tipo = value; }

        public Usuario (string nome, string telefone, string cpf, string login, string senha, bool status, string tipo)
        {
            Nome = nome;
            Telefone = telefone;
            Cpf = cpf;
            Login = login;
            Senha = senha;
            Status = status;
            Tipo = tipo;
        }
        
        public void MostrarUsuário()
        {
            MessageBox.Show($"Os dados inseridos foram:\nNome = {this.Nome}\nTelefone: {this.Telefone}\nCPF: {this.Cpf}\nLogin: {this.Cpf}\nStatus: {this.Status}\nTipo: {this.Tipo}");
        }
    }
}
