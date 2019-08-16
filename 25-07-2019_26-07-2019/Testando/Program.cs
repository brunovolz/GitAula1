using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculadoraClassBrunoV;

namespace Testando
{
    class Program
    {
        static void Main(string[] args)
        {
            var calcular = new Calculadorinha();
            Console.WriteLine(calcular.calculoSoma(2,3));
            Console.WriteLine(calcular.calculoDivisao(10,2));
            Console.WriteLine(calcular.calculoMultiplicacao(20,2));
            Console.WriteLine(calcular.calculoSubtracao(10,2));
            Console.WriteLine(calcular.calculoCirculo(69.9));
            Console.WriteLine(calcular.calculoTriangulo(69,2));
            Console.WriteLine(calcular.calculoRetangulo(69,2));
            Console.ReadKey();
        }
    }
}
