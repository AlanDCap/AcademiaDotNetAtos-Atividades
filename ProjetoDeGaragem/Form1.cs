using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoDeGaragem
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
            //inicialização da label que mostra a quantidade
            //de vagas na garagem, a cada registro de entrada
            //ou saída ela é atualizada automaticamente
            lbl_vagas.Text = $"Bom dia!";
        }

        //lista com os objetos veículo estacionados na garagem,
        //esta lista recebe um objeto quando o funcionário
        //registra uma entrada, e o objeto é removido quando o
        //usuário registra uma saída.
        List<Veiculo> estacionados = new List<Veiculo>();

        //botão para registro de entrada, chama o método gravar
        //entrada que salva o registro em arquivo. 
        private void bt_registrarEntrada_Click(object sender, EventArgs e)
        {
            //realiza verificação de vagas disponíveis na garagem.
            bool jaEstacionado = false;
            if (estacionados.Count() >= 50)
            {
                MessageBox.Show("Garagem lotada, não há mais vagas");
            }
            //tratamento do atributo placa
            else if (!(tb_placa.Text.Count() == 7))
            {
                MessageBox.Show("Placa inválida");
            }
            else
            {
                //verifica se a placa está registrada
                //entre os veículos estacionados na garagem
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
                    Veiculo v = new Veiculo(tb_Motorista.Text, cb_tipoVeiculo.Text, tb_placa.Text.ToUpper());

                    //inscreve o veículo na interface do usuário
                    dg_veiculosEstacionados.Rows.Add(v.TipoVeiculo, v.Placa, v.Motorista, v.DataEntrada.ToString("d"), v.DataEntrada.ToString("t"));
                    //adiciona o veículo na lista "estacionados"
                    estacionados.Add(v);
                    //grava o registro em arquivo
                    Funcionalidades.gravarEntrada(v);

                    //Informa quantas vagas ainda restam no pátio
                    if (estacionados.Count() <= 0)
                    {
                        MessageBox.Show("Não há mais vagas");
                    }
                    MessageBox.Show($"{estacionados.Count()} veiculo(s) estão na garagem, ainda resta(m) {50 - estacionados.Count()} vaga(s)");
                    lbl_vagas.Text = $"Vagas ocupadas {estacionados.Count()}";
                    ///limpa os campos após efetuar o registro
                    cb_tipoVeiculo.ResetText();
                    tb_placa.Clear();
                    tb_Motorista.Clear();
                }
            }
        }
        //botão para registro de saída de veículo, chama
        //o método gravar saída e salva o registro
        //completo com hora de entrada e saída em arquivo
        private void bt_registrarSaida_Click(object sender, EventArgs e)
        {
            //pega a referência da placa para buscar o veículo na lista
            DataGridViewRow linhaSelecionada = dg_veiculosEstacionados.CurrentRow;
            int indice = linhaSelecionada.Index;
            string placa = (string)dg_veiculosEstacionados.Rows[indice].Cells[1].Value;
            int indexVeiculo;

            foreach (Veiculo v in estacionados)
            {
                //registra no objeto veículo os valores referentes à HoraSaida, Permanencia, e ValorPago. 
                if (v.Placa.Equals(placa))
                {
                    indexVeiculo = estacionados.IndexOf(v);
                    Funcionalidades.gravarSaida(v);
                    MessageBox.Show($"O valor a ser cobrado é {v.Valorpago} reais, equivalente a {Math.Ceiling(v.Permanencia.TotalHours)} hora(s)");

                    dg_veiculosEstacionados.Rows.RemoveAt(indice);
                    estacionados.Remove(estacionados[indexVeiculo]);
                    break;
                }
            }
            lbl_vagas.Text = $"Vagas ocupadas {estacionados.Count()}";
        }
        //botão para mostrar os carros que já registraram entrada na garagem
        private void bt_mostrarSaida_Click(object sender, EventArgs e)
        {
            //este método abre uma nova janela com datagrid, onde são
            //mostrados todos os carros que registraram entrada na
            //garagem no dia de expediente.
            Funcionalidades.mostrarMovimentação();
        }
        //botão que encerra o expediente
        private void bt_finalizarExpediente_Click(object sender, EventArgs e)
        {
            //não é permitido encerrar o expediente enquanto houver carros na garagem
            if (estacionados.Count > 0)
            {
                MessageBox.Show("Para encerrar o expediente, não pode haver carros registrados na garagem.");
            }
            //este método encerra a aplicação
            else
                Funcionalidades.finalizarExpediente();
        }

        //mantém o datetimepicker com o horário atualizado 
        private void timer1_Tick(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
        }
    }
}