using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var elementoX = new Teste(5,5);

            elementoX.MostrarInformaçoes();

            elementoX.AlteraInformaçoes(5, 5);

            elementoX.MostrarInformaçoes();

            elementoX.AlteraInformaçoes();

            elementoX.MostrarInformaçoes();

            Console.ReadKey();
        }
    }

    public class Teste
    {
        private int A { get; set; } = 0;
        private int B { get; set; } = 0;
        public Teste(int pA, int pB)
        {
            A = pA; 
            B = pB;
        }

        public void AlteraInformaçoes()
        {
            A = B * 100;
        }
        public void AlteraInformaçoes(int pA, int pB)
        {
            A = pA * 2;
            B = pB * 2;
        }
        public void MostrarInformaçoes()
        {
            Console.WriteLine(A + B);
        }
    }
}
