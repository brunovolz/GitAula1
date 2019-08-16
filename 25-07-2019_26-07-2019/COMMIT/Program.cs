using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace COMMIT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 1 número!");
             int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite mais 1 número!");
             int num2 = Convert.ToInt32(Console.ReadLine());

            Console.ReadKey();
            if (num1 % num2 == 0 || num2 % num1 == 0)
            {
                Console.WriteLine("São múltiplos");
            }
            else
                Console.WriteLine("Não são múltiplos");

            Console.ReadKey();
        }
    }
}