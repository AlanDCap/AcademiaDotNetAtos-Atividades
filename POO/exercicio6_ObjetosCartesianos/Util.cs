using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio6_ObjetosCartesianos
{
    internal class Util
    {
        public static void registrarObj (int n, List<Objeto> list)
        {
            
            for (int i = 0; i < n; i++)
            {
                list.Add(new Objeto(n));
            }
            Console.Write("Gerando lista de Objetos");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.WriteLine(".");
        }

        public static void exibirLista (List<Objeto> list)
        {
            foreach (Objeto i in list)
            {
                Console.WriteLine($"Objeto localizado nas coordenadas x: {i.PosX}, y: {i.PosY}");
            }
        }
    }
}
