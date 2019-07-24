using ListaBiSuperCompact.BibliotecaListaBi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiSuperCompact
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaBi = new ListaBi();

            listaBi.PesquisaLista(Console.ReadLine());

            Console.ReadKey();


        }
    }
}
