using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio2_animaisDeEstimacao
{
    internal class Animal
    {
        private string nome;
        private string tipo;

        public Animal(string nome, string tipo)
        {
            this.nome = nome;
            this.tipo = tipo;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Tipo { get => tipo; set => tipo = value; }


    }
}
