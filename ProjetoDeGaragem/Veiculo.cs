using System;

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
        /// Construtor vazio para ser utilizado no registro de saída
        /// </summary>
        public Veiculo()
        {

        }

        /// <summary>
        /// Construtor para registro de Entradas. O funcionário deve inserir os dados referentes a motorista, 
        /// tipo do veículo e placa, os atributos de data e hora são gerados pelo sistema. 
        /// </summary>
        /// <param name="motorista">Nome do responsável pelo veículo</param>
        /// <param name="tipoVeiculo">Tipo do veículo</param>
        /// <param name="placa">Identificação primária do veículo</param>
        public Veiculo(string motorista, string tipoVeiculo, string placa)
        {
            Motorista = motorista;
            TipoVeiculo = tipoVeiculo;
            Placa = placa;
            DataEntrada = DateTime.Now;
        }
    }
}

