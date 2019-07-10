using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca
{
    class Program
    {
        static string[,] Basedelivros;

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow; //fonte amarelo
            CarregaBaseDeDados();
            MostrarSejaBemVindo();

            if (MenuInicial() == 1)
            {
                Console.Clear(); //limpa o console
                MostrarSejaBemVindo();
                Console.WriteLine("Menu - Alocar livro");
                Console.WriteLine();
                Console.WriteLine("Digite o nome do livro a ser alocado:");

                var nomedolivro = Console.ReadLine();
                if (Pesquisalivro(nomedolivro))
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green; //fonte verde
                    Console.WriteLine($"Você deseja alocar o livro? ({nomedolivro})");
                    Console.WriteLine();
                    Console.WriteLine($"Se sim digite (1) Se não digite (2)");

                    if (Console.ReadKey().KeyChar.ToString() == "1")
                    {
                        Alocarlivro(nomedolivro);
                        Console.Clear();
                        Console.WriteLine("  Livro Alocado com Sucesso!!!");
                    }
                    else
                        Console.Clear();

                    Console.ForegroundColor = ConsoleColor.Cyan; //fonte azul claro
                    Console.WriteLine("_______________________________");
                    Console.WriteLine("Listagem de livros disponiveis:");

                    for (int i = 0; i < Basedelivros.GetLength(0); i++) //preenche automatico com tab+tab
                    {
                        Console.WriteLine($"NOME: {Basedelivros[i,0]} Disponivel:{Basedelivros[i,1]}");
                    }
                }
            }
            Console.ReadKey(); 
        }
        /// <summary>
        /// Mostrar seja bem vindo
        /// </summary>
        public static void MostrarSejaBemVindo()
        {
            #region
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("SEJA BEM VINDO A BIBLIOTECA DA NASA");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("DESENVOLVIDA PELAS INDUSTRIAS STARK");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine();
            Console.WriteLine();
            #endregion
        }
        /// <summary>
        /// Metodo que mostra o conteudo do menu e as opções de escolha.
        /// </summary>
        /// <returns>Retorna o valor do menu escolhido em um tipo inteiro.</returns>
        public static int MenuInicial()
        {
            Console.WriteLine("\r\nMenu - Inicial");
            Console.WriteLine("O que você deseja realizar?");
            Console.WriteLine();
            Console.WriteLine("1 - Alocar um livro.");
            Console.WriteLine("2 - Sair do sistema.");
            Console.WriteLine();
            Console.WriteLine("Digite a opção desejada:");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            return opcao;
        }
        /// <summary>
        /// Metodo que carrega a base de dados dentro do sistema.
        /// </summary>
        public static void CarregaBaseDeDados()
        {
            Basedelivros = new string[2, 2]
            {
                {"O pequeno","SIM"},
                {"O grande","NÃO"}
            };

        }
        /// <summary>
        /// Metodo que retorna se um livro pode ser locado ou não.
        /// </summary>
        /// <param name="nomedolivro">Nome do livro a ser pesquisado.</param>
        /// <returns>Retorna verdadeiro em casa do livro estar livre para locação.</returns>
        public static bool Pesquisalivro(string nomedolivro)
        {
            for (int i = 0; i < Basedelivros.GetLength(0); i++)
            {
                if (nomedolivro == Basedelivros[i, 0])
                {
                    Console.WriteLine($"O livro:{nomedolivro}" +
                        $", pode ser alocado? {Basedelivros[i, 1]}");

                    return Basedelivros[i, 1] == "SIM";
                }
            }
            return false;
        }
        /// <summary>
        /// Metodo que aloca o livro de acordo com o paramentro passado.
        /// </summary>
        /// <param name="nomedolivro">Nome do livro a ser alocado.</param>
        public static void Alocarlivro(string nomedolivro)
        {
            for (int i = 0; i < Basedelivros.GetLength(0); i++)
            {
                if(nomedolivro == Basedelivros[i, 0])
                    Basedelivros[i, 1] = "Não";
            }
        }
    }
}
