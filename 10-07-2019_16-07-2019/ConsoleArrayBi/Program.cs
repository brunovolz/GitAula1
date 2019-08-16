using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleArrayBi
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] listadelivros = new string[2, 2]
                {{"O pequeno","sim"},{"O grande","não"} };

            for (int i = 0; i < listadelivros.GetLength(0); i++)
            {
                var Nomelivro = listadelivros[i, 0];
                var disponivel = listadelivros[i, 1];

                Console.WriteLine($"Nomedo livro:{Nomelivro} disponivel:{disponivel}.");
            }

            Console.ReadKey();


            

        }
    }
}
