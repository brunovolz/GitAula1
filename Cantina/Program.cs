using Cantina.Lanche;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina
{
    class Program
    {
        Lancheria ComprarLanchinho = new Lancheria();
        static void Main(string[] args)
        {
            EfetuarCompra();

        }
        public static void EfetuarCompra()
        {
            Lancheria ComprarLanchinho = new Lancheria();

            /*while (ComprarLanchinho.MostrarSaldo() > 0.00)
            {

                MostrarMenu();

                var valor = 0.00;

                switch (Console.ReadLine())
                {
                    case "1": { valor = 2.50; } break;
                    case "2": { valor = 3.50; } break;
                    case "3": { valor = ComprarLanchinho.MostrarSaldo(); } break;
                }

                if (ComprarLanchinho.ComprarLanche(pLanche:!))
                    Console.WriteLine("Lanchinho comprado com susssscesso!");
                else
                    Console.WriteLine("Você não tem dinheiro para comprar o lanchinho");*/

            Console.WriteLine("Informe o lanche a ser comprado\r\n" +
            "Coxinha = 2,00 reais ou Pastel = 3,00 reais");

            string lanche = Console.ReadLine().ToLower();

            if (lanche != "" && ComprarLanchinho.ComprarLanche(lanche))
                Console.WriteLine("Lanchinho comprado com susssscesso!");
            else
                Console.WriteLine("Você não tem dinheiro para comprar o lanchinho :(");

            Console.WriteLine($"Saldo atual disponiVel:{ComprarLanchinho.MostrarSaldo()}\r\n");
            Console.WriteLine("(1) Desejo comprar outro lanchinho\r\n" +
                "(2) Desejo sair da cantina");
            var opcao = Console.ReadLine();

            if (opcao == "1")
            {
                Console.Clear();
                EfetuarCompra();
            }
        }
    }
}
        /*public static void MostrarMenu()
        {
            Console.WriteLine("Informe o lanche a ser comprado:\r\n" +
            "(1) - Coxinha = 2,00 reais\r\n" +
            "(2) - Pastel = 3,00 reais\r\n");
        }*/
