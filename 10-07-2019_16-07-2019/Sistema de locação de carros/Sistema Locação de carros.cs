using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_locação_de_carros
{
    class Program
    {
        static string[,] Basedecarros;

        static void Main(string[] args)
        {
            CarregaBaseDeDados();
            MostrarSejaBemVindo();

            var opçaoMenu = MenuInicial();

            while (opçaoMenu != 3)
            {
                if (MenuInicial() == 1)
                    LocarCarro();

                if (opçaoMenu == 2)
                    DesalocarCarro();

                opçaoMenu = MenuInicial();
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para finalizar");

            Console.ReadKey();
        }
        

        /// <summary>
        /// Metodo para mostrar a tela de Seja bem vindo.
        /// </summary>
        public static void MostrarSejaBemVindo()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=============================================");
            Console.WriteLine("BEM VINDO AO SISTEMA DE LOCAÇÃO DE AUTOMOVEIS");
            Console.WriteLine("=============================================");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Pressione uma tecla para continuar!");
            Console.WriteLine();
            Console.WriteLine();

            Console.ReadKey();
        }
        /// <summary>
        /// Metodo para Abrir menu inicial de opções.
        /// </summary>
        /// <returns>Retorna o valor escolhido.</returns>
        public static int MenuInicial()
        {

            Console.WriteLine("Temos dois veiculos disponiveis para locação!");
            Console.WriteLine();
            Console.WriteLine("(1) Para locar um veiculo");
            Console.WriteLine("(2) Para a devolução de um veiculo");
            Console.WriteLine("(3) Para sair do sistema");
            Console.WriteLine();
            Console.WriteLine("Digite a opção desejada");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            return opcao;
        }
        /// <summary>
        /// Metodo de Banco de dados.
        /// </summary>
        public static void CarregaBaseDeDados()
        {
            Basedecarros = new string[2, 3]
            {
                {"Onix","2019","SIM"},
                {"Gol","2000","NÃO"},
            };
        }
        /// <summary>
        /// Mosta o menu de locação e pergunta qual o nome do carro.
        /// </summary>
        public static void MostarMenuLocação()
        {
            Console.Clear();
            MostrarSejaBemVindo();
            Console.WriteLine("MENU DE LOCAÇÃO");
            Console.WriteLine();
            Console.WriteLine("Digite o nome do carro a ser locado:");

            var nomedocarro = Console.ReadLine();
            if (Pesquisacarro(nomedocarro))
            {
                Console.Clear();
                Console.WriteLine($"Você deseja locar ({nomedocarro})");
                Console.WriteLine();
                Console.WriteLine("(1) Para confirmar");
                Console.WriteLine("(2) Para sair");

                if (Console.ReadKey().KeyChar.ToString() == "1")
                {
                    LocarCarro(nomedocarro);
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("Carro locado com sucesso!!!");
                    Console.WriteLine();
                }

                else
                    Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Lista de carros disponiveis para locação");

                for (int i = 0; i < Basedecarros.GetLength(0); i++)
                {
                    Console.WriteLine($"{Basedecarros[i, 0]} Disponivel: {Basedecarros[i, 2]}");
                }
            }

        }
        /// <summary>
        /// Metodo que retorna se um carro pode ser locado ou não.
        /// </summary>
        /// <param name="nomedocarro">Nome do carro a ser pesquisa</param>
        /// <returns>Retorna verdadeiro se disponivel ou falso se não disponivel.</returns>
        public static bool Pesquisacarro(string nomedocarro)
        {
            for (int i = 0; i < Basedecarros.GetLength(0); i++)
            {
                if (nomedocarro == Basedecarros[i, 0])
                {
                    Console.WriteLine($"O carro: {nomedocarro} " +
                        $"|| Ano: {Basedecarros[i, 1]}" +
                        $"|| Está disponivel? {Basedecarros[i, 2]}");

                    return Basedecarros[i, 2] == "SIM";
                }
            }
            return false;
        }
        /// <summary>
        /// Metodo de locação de carros de acordo com parametros.
        /// </summary>
        /// <param name="nomedocarro">Nome do carro a ser locado</param>
        public static void LocarCarro(string nomedocarro, bool alocar)
        {
            for (int i = 0; i < Basedecarros.GetLength(0); i++)
            {
                if (nomedocarro == Basedecarros[i, 0])
                {
                    Basedecarros[i, 2] = alocar ? "NÃO" : "SIM";
                }
            }
        }
    }
}

