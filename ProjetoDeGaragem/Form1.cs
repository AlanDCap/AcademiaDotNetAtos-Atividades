using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoDeGaragem
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Lista de veículos estacionados atualmente no pátio
        /// </summary>
        List<Veiculo> estacionados = new List<Veiculo>();
        /// <summary>
        /// Lista de veículos que passaram pela garagem durante o expediente
        /// </summary>
        List<Veiculo> registrodiario = new List<Veiculo>();
        double precoHora = 5;

        /// Registro de carros no estacionamento. Não é possível registrar duas placas iguais. Limite de 50 carros.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_registrarEntrada_Click(object sender, EventArgs e)
        {
            bool jaEstacionado = false;
            if (estacionados.Count() >= 50)
            {
                MessageBox.Show("Garagem lotada, não há mais vagas");
            }
            else if (tb_placa.Text.Count() < 7)
            {
                MessageBox.Show("Placa inválida");
            }
            else
            {
                foreach (Veiculo v in estacionados)
                {
                    if (v.Placa == tb_placa.Text)
                    {
                        MessageBox.Show("Placa já registrada, o carro já está no pátio");
                        jaEstacionado = true;
                        break;
                    }
                }
                if (!jaEstacionado)
                {
                    //Adiciona um novo veículo na lista de vagas disponíveis
                    Veiculo v = new Veiculo(tb_Motorista.Text, cb_tipoVeiculo.Text, tb_placa.Text);
                    dg_veiculosEstacionados.Rows.Add(v.TipoVeiculo, v.Placa, v.Motorista, v.DataEntrada.ToString("d"), v.DataEntrada.ToString("t"));
                    estacionados.Add(v);
                    //verifica se a quantidade máxima de vagas foi atingida
                    MessageBox.Show($"{estacionados.Count()} veiculos estão na garagem, ainda restam {50 - estacionados.Count()} vagas");
                }
            }
        }
        /// <summary>
        /// Registra a saída de um veículo da garagem e informa o preço a ser pago
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_registrarSaida_Click(object sender, EventArgs e)
        {
            //pega a referência da placa para buscar o veículo na lista
            DataGridViewRow linhaSelecionada = dg_veiculosEstacionados.CurrentRow;
            int indice = linhaSelecionada.Index;
            string placa = (string)dg_veiculosEstacionados.Rows[indice].Cells[1].Value;
            int indexVeiculo;
            //adiciona o veículo na lista de registro diário
            foreach (Veiculo i in estacionados)
            {
                if (i.Placa.Equals(placa))
                {
                    indexVeiculo = estacionados.IndexOf(i);
                    registrodiario.Add(i);
                    i.HoraSaida = DateTime.Now;
                    i.Permanencia = i.HoraSaida.Subtract(i.DataEntrada);
                    i.Valorpago = Math.Ceiling((i.Permanencia.TotalMinutes / 60)) * precoHora;
                    MessageBox.Show($"O valor a ser cobrado é {i.Valorpago} reais, equivalente a {Math.Ceiling(i.Permanencia.TotalHours)} hora(s)");
                    break;
                }
            }
            //remove o veículo da lista de estacionados e do datagrid
            foreach (Veiculo i in estacionados)
            {
                if (i.Placa.Equals(placa))
                {
                    indexVeiculo = estacionados.IndexOf(i);
                    estacionados.Remove(estacionados[indexVeiculo]);
                    break;
                }
            }
            dg_veiculosEstacionados.Rows.RemoveAt(indice);
        }
        //lista todos os veículos que passaram pela garagem no dia de expediente.
        private void bt_mostrarSaida_Click(object sender, EventArgs e)
        {
            foreach (Veiculo v in registrodiario)
                MessageBox.Show($"{v.Placa}, {v.TipoVeiculo} {v.DataEntrada.ToString("t")}");
        }

        private void bt_finalizarExpediente_Click(object sender, EventArgs e)
        {
            try
            {

                string nomeArquivo = "registroDiario.dat";
                double ganhoDiario = 0;
                StreamWriter escritor = new StreamWriter(nomeArquivo, true);
                foreach (Veiculo v in registrodiario)
                {
                    escritor.WriteLine($"{v.DataEntrada.ToString("yyyyMMdd")};{v.Placa};{v.TipoVeiculo};{v.Motorista}{v.HoraSaida};{v.Valorpago}");
                    escritor.Flush();
                    ganhoDiario = ganhoDiario + v.Valorpago;
                }
                escritor.Close();
                MessageBox.Show($"O total recebido no hoje foi {Math.Round(ganhoDiario, 2)}");
            }
            catch (IOException)
            {
                MessageBox.Show("Erro ao gravar o arquivo");
            }
        }
    }
}
