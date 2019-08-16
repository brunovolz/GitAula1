using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaCalculadora;

namespace Calculadorinha
{
    class Program
    {
        static void Main(string[] args)
        {
            var teste = new Biblioteca();

            teste.Divisao();
            teste.Subtracao();
            teste.Multiplicacao();
            teste.Adicao();

            Console.ReadKey();
        }
    }
}
