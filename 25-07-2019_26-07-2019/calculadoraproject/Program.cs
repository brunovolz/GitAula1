using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcLibrary;

namespace Testando
{
    class Program
    {
        static void Main(string[] args)
        {
            var calcular = new FuncoesCalc();
            Console.WriteLine($" O resultado da soma é: {(calcular.Adicao(2, 3))}\r\n");
            Console.WriteLine($" O resultado da subtração é: {calcular.Subtracao(10, 2)}\r\n");
            Console.WriteLine($" O resultado da multiplicação é: {calcular.Multiplicacao(20, 2)}\r\n");
            Console.WriteLine($" O resultado da divisão é: {calcular.Divisao(10, 2)}\r\n");
            Console.WriteLine($" O resultado da área do circulo é: {calcular.CalcRaioCirculo(69.9)}\r\n");
            Console.WriteLine($" O resultado da área do retangulo é: {calcular.CalcRetangulo(69, 2)}\r\n");
            Console.WriteLine($" O resultado da área do triangulo é: {calcular.CalcTrianguloEquilatero(69, 2)}");
            Console.ReadKey();
        }
    }
}
