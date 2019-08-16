using CriandoListas.NewFolder1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriandoListas
{
    class Program
    {
        static void Main(string[] args)
        {
            var Lista = new Class1();

            Lista.CarregaLista();

            Lista.LimpaLista();

            Lista.CarregaLista();

            Console.ReadKey();
        }
    }
}
