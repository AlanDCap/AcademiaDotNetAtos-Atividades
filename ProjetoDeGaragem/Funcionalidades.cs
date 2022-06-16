using System;
using System.IO;
using System.Windows.Forms;


namespace ProjetoDeGaragem
{
    internal class Funcionalidades
    {
        public static void gravarEntrada(Veiculo v)
        {
            //faz o registro da entrada de veículos em arquivo,
            //caso seja necessário consultar quais ou quantos
            //veículos entraram na garagem até o momento da consulta
            //Nota: Inclui os carros que ainda não registraram saída
            //Nota 2, este arquivo é excluído ao final do expediente 
            try
            {
                string nomeArquivo = "registroEntradas.dat";
                StreamWriter escritor = new StreamWriter(nomeArquivo, true);
                escritor.WriteLine($"{v.Placa};{v.TipoVeiculo};{v.Motorista};{v.DataEntrada.ToString("t")}");
                escritor.Flush();
                escritor.Close();
            }
            catch (IOException e)
            {
                MessageBox.Show("Erro ao gravar o arquivo" + e.Message);
            }
        }
        public static void gravarSaida(Veiculo v)
        {
            //adiciona os últimos atributos do objeto veículo,
            //a saber hora de saída, tempo de permanência
            //e valor pago pego cliente. Para futuras atualizações,
            //planejo desenvolver um método que possibilite ajustar
            //o valor da hora de estadia.
            double precoHora = 5;
            v.HoraSaida = DateTime.Now;
            v.Permanencia = v.HoraSaida.Subtract(v.DataEntrada);
            v.Valorpago = Math.Ceiling((v.Permanencia.TotalMinutes / 60)) * precoHora;

            //registro do objeto na lista "registroDiário",
            //o arquivo está realizando função de permanência
            //de dados, mas será substituído por BD numa futura atualização
            try
            {
                string nomeArquivo = "registroDiario.dat";
                StreamWriter escritor = new StreamWriter(nomeArquivo, true);
                escritor.WriteLine($"{v.DataEntrada.ToString("yyyyMMdd")};{v.Placa};{v.TipoVeiculo};{v.Motorista};{v.HoraSaida};{v.Valorpago}");
                escritor.Flush();
                escritor.Close();
            }
            catch (IOException e)
            {
                MessageBox.Show("Erro ao gravar o arquivo: " + e.Message);
            }
        }
        public static void mostrarMovimentação()
        {
            //inicializa o form com a visualização dos veículos
            //que tiveram entrada registrada durante o dia de expediente
            ListaEntradas movimentacao = new ListaEntradas();
            movimentacao.ShowDialog();
        }
        public static void finalizarExpediente()
        {
            //apaga o registro de Entradas ao encerrar o expediente.
            //Os dados estão de movimentação de veículos estão salvos
            //no arquivo de registro diário, caso seja necessário consultar.
            //O registro é completo com todos os atributos do objeto
            //veículo. A funcionalidade de acessar essa lista para
            //utilizar os dados salvos lá ainda não foi implementada,
            //mas está planejada para quando a lista for substituída pelo BD
            File.Delete("registroEntradas.dat");
            Application.Exit();
        }
    }
}
