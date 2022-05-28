using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio5_cenario
{
    internal class Util
    {
        public static void criarCenario(List<Cenario> lista)
        {
            string descricao;
            float altura;
            Console.WriteLine("Descreva o item a ser adicionado ao cenário:");
            descricao = Console.ReadLine();
            Console.WriteLine("Informe a altura em metros");
            altura = float.Parse(Console.ReadLine());

            lista.Add(new Cenario(descricao, altura));
        }

        public static void listarCenarios(List<Cenario> lista)
        {
            foreach (Cenario i in lista)
            {
                Console.WriteLine($"{i.Descricao} com altura {i.Altura} criado em {i.DataDeCriacao}" );
            }
        }
        public static void compararDataCriacao(List <Cenario> list)
        {
            int escolha, contador = 0;
            Console.WriteLine("Informe qual item deseja verificar o tempo decorrido desde a criação:");
            foreach (Cenario i in list)
            {
                contador++;
                Console.WriteLine($"{contador} - {i.Descricao}");
            }
            
            escolha = int.Parse(Console.ReadLine());
            DateTime d1 = list[escolha -1].DataDeCriacao;
            DateTime d2 = DateTime.Now;
            TimeSpan tempoDecorrido = d2.Subtract(d1);
            Console.WriteLine($"O item '{list[escolha -1].Descricao}' foi criado há {Math.Round(tempoDecorrido.TotalSeconds)} segundos");
        }
    }
}
