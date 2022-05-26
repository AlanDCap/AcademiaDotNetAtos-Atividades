using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOO
{
    public class Lampada
    {
        private bool ligado;
        private int potencia;
        private string marca;

        public bool Ligado { get => ligado; set => ligado = value; }
        public int Potencia { get => potencia; set => potencia = value; }
        public string Marca { get => marca; set => marca = value; }

        public Lampada(int pot, string m)
        {
            Potencia = 9;
            Marca = "Philips";
        }

        public void ligar()
        {
            Console.WriteLine("A lâmpada está sendo ligada");
            Ligado = true;
        }
        public void desligar()
        {
            Console.WriteLine("A lâmpada está sendo desligada");
            Ligado = false;
        }
        public bool estaLigada()
        {
            return Ligado;
        }
        public double retornaPotencia()
        {
            return Potencia;
        }
    }
}