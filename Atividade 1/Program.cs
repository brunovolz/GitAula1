using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_1
{
    class Program
    {
        static void Main(string[] args)
        {
            MostrarMenu();

            Console.ReadKey();
        }
        public static void MostrarMenu()
        {
            Console.WriteLine("BORA COMPRAR UMA CERVA COM DESCONTO?");
            Console.WriteLine();
            Console.WriteLine("MAS PRIMEIRO PRECISAMOS VERIFICAR SUA IDADE!");
            Console.WriteLine();
            Console.WriteLine("DIGITE SUA IDADE NO CAMPO ABAIXO");
            Console.WriteLine();

            int.TryParse(Console.ReadLine(), out int idade);

            {
                if (idade >= 18)
                {
                    Console.WriteLine("PARABÉNS, VOCÊ ESTÁ APTO A ADQUIRIR NOSSOS PRODUTOS");
                }
                else
                {
                Console.WriteLine("PROIBIDO PARA MENORES DE 18 ANOS");
                }

            }
        }
    }
}