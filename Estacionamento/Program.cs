using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estacionamento.EOQ;

namespace Estacionamento
{
    class Program
    {
        static void Main(string[] args)
        {
            var hotwells= new Carros();
            hotwells.mostrarCarros();
            Console.ReadKey();
        }
    }
}
