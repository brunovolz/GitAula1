using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCalculadora
{
    public class Biblioteca
    {
        public void Divisao()
        {
            Console.WriteLine("Digite um número");
            float.TryParse(Console.ReadLine(), out float x);
            Console.WriteLine("Digite outro número para dividir");
            float.TryParse(Console.ReadLine(), out float i);

            Console.WriteLine($"{x /= i}");

            Console.ReadKey();
        }
        public void Subtracao()
        {
            Console.WriteLine("Digite um número");
            float.TryParse(Console.ReadLine(), out float x);
            Console.WriteLine("Digite outro número para subtrair");
            float.TryParse(Console.ReadLine(), out float i);

            Console.WriteLine($"{x -= i}");

            Console.ReadKey();
        }
        public void Adicao()
        {
            Console.WriteLine("Digite um número");
            float.TryParse(Console.ReadLine(), out float x);
            Console.WriteLine("Digite outro número para somar");
            float.TryParse(Console.ReadLine(), out float i);

            Console.WriteLine($"{x += i}");

            Console.ReadKey();
        }
        public void Multiplicacao()
        {
            Console.WriteLine("Digite um número");
            float.TryParse(Console.ReadLine(), out float x);
            Console.WriteLine("Digite outro número para multiplicar");
            float.TryParse(Console.ReadLine(), out float i);

            Console.WriteLine($"{x *= i}");

            Console.ReadKey();
        }
    }
}