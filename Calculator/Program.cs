using BibliotecaCalculadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var Calculadora = new Biblioteca();

            Calculadora.Divisao();
            Calculadora.Subtracao();
            Calculadora.Multiplicacao();
            Calculadora.Adicao();

            Console.ReadKey();
        }
    }
}
