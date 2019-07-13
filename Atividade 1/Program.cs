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
            Console.WriteLine("BORA COMPRAR UMA CERVA COM DESCONTO?");//.WriteLine escreve informaçoes e quebra a linha.
            Console.WriteLine();
            Console.WriteLine("MAS PRIMEIRO PRECISAMOS VERIFICAR SUA IDADE!");
            Console.WriteLine();
            Console.WriteLine("DIGITE SUA IDADE NO CAMPO ABAIXO");
            Console.WriteLine();

            int.TryParse(Console.ReadLine(), out int idade);//.ReadLine le uma linha inteira com mais de 1 informação
            //.TryParse espera uma string e depois da virgula para separar os parametros temos a saida do valor inserido.
            //Colocando "out int" temos a criação da variavel
            //Colocando apenas "out" precisamos informar uma variavel existente.
            {
                if (idade >= 18)
                {
                    Console.WriteLine("BORA CHAPA O COCO!");
                }
                else
                {
                Console.WriteLine("VISHHHHH LASCOU-SE VOLTE QUANDO COMPLETAR 18 ANOS!");
                }

            }
        }
    }
}