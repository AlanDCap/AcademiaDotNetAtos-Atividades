using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDeGaragem
{
    internal class Veiculo
    {
        private string motorista;
        private string tipoVeiculo;
        private string placa;
        private DateTime dataEntrada;
        private DateTime horaSaida;
        private TimeSpan permanencia;
        private double valorpago;

        public string Motorista { get => motorista; set => motorista = value; }
        public string TipoVeiculo { get => tipoVeiculo; set => tipoVeiculo = value; }
        public string Placa { get => placa; set => placa = value; }
        public DateTime DataEntrada { get => dataEntrada; set => dataEntrada = value; }
        public DateTime HoraSaida { get => horaSaida; set => horaSaida = value; }
        public TimeSpan Permanencia { get => permanencia; set => permanencia = value; }
        public double Valorpago { get => valorpago; set => valorpago = value; }

        /// <summary>
        /// Construtor para registro de Entradas. O funcionário deve digitar os dados referentes a motorista, tipo do veículo e placa, os atributos de data e hora são gerados pelo sistema. 
        /// </summary>
        /// <param name="motorista">Nome do responsável pelo veículo</param>
        /// <param name="tipoVeiculo">Tipo do veículo, existem vagas diferenciadas para cada um</param>
        /// <param name="placa">Identificação primária do veículo</param>
        public Veiculo(string motorista, string tipoVeiculo, string placa)
        {
            
            Motorista = motorista;
            TipoVeiculo = tipoVeiculo;
            Placa = placa;
            DataEntrada = DateTime.Now;
        }

        /// <summary>
        /// Construtor para registro de Saídas. Os dados referentes a motorista, tipo do veículo e placa, data e hora vem do datagrid, e os dados de saída e valor são criados pelo sistema. 
        /// </summary>
        /// <param name="motorista">Nome do responsável pelo veículo</param>
        /// <param name="tipoVeiculo">Tipo do veículo, existem vagas diferenciadas para cada um</param>
        /// <param name="placa">Identificação primária do veículo</param>
        public Veiculo(string motorista, string tipoVeiculo, string placa, DateTime dataEntrada, DateTime horaEntrada)
        {
            //DateTime dataLocal = DateTime.Now;
            //TimeSpan temp = dataLocal.Subtract(horaEntrada);
    
          //  Motorista = motorista;
            //TipoVeiculo = tipoVeiculo;
            //Placa = placa;
            //DataEntrada = dataEntrada;
            //HoraSaida = dataLocal;
            //Permanencia = temp;
        }
    }

}
