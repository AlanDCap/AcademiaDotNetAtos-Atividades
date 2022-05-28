using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafioCadastrodePlacas
{
    internal class Carro
    {
        private string placa;
        private string horarioDeEntrada;


        private void gerarDataHora()
        {
            DateTime dataLocal = DateTime.Now;
            this.HorarioDeEntrada = dataLocal.ToString();
        }

        public Carro(string placa, string horarioDeEntrada)
        {
            Placa = placa;
            HorarioDeEntrada = horarioDeEntrada;
        }

        public Carro(string placa)
        {
            this.Placa = placa;
            this.gerarDataHora();
        }
        public string Placa { get => placa; set => placa = value; }
        public string HorarioDeEntrada { get => horarioDeEntrada; set => horarioDeEntrada = value; }
    }

}