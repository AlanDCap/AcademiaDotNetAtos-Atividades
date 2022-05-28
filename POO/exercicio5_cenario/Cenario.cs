using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio5_cenario
{
   internal class Cenario
    {
        private string descricao;
        private float altura;
        private DateTime dataDeCriacao = new DateTime();

        public string Descricao { get => descricao; set => descricao = value; }
        public float Altura { get => altura; set => altura = value; }
        public DateTime DataDeCriacao { get => dataDeCriacao; set => dataDeCriacao = value; }
 

        public Cenario(string descricao, float altura)
        {
            this.Descricao = descricao;
            this.Altura = altura;
            DataDeCriacao = DateTime.Now;
        }

        
    }
}
