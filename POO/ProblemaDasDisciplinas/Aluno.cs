using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemaDasDisciplinas
{
    internal class Aluno
    {
        
        // armazena a matrícula de um aluno
        string matricula;

        // armazena o nome do aluno
        string nome;

        //armazena o email do aluno 
        string email;
        /// <summary>
        /// método cosntrutor que isntancia um objeto com todos os seus atributos
        /// </summary>
        /// <param name="matricula">recebe a matrícula de um aluno</param>
        /// <param name="nome">recebe o nome completo de um aluno</param>
        /// <param name="email">recebe o email de um aluno</param>
        public Aluno(string matricula, string nome, string email)
        {
            this.Matricula = matricula;
            this.Nome = nome;
            this.Email = email;
        }
        // propriedade ou atributo que acessa a variável matrícula
        public string Matricula { get => matricula; set => matricula = value; }
        // propriedade ou atributo que acessa a variável nome
        public string Nome { get => nome; set => nome = value; }
        // propriedade ou atributo que acessa a variável email
        public string Email { get => email; set => email = value; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string pegaNomeSobrenome()
        {
            string[] vetorNomes = this.Nome.Split(' ');
            if (vetorNomes.Length == 1)
            {
                return vetorNomes[0];
            }
            else 
                return vetorNomes[0] + " " + vetorNomes[vetorNomes.Length - 1] ;
        }
    }
}