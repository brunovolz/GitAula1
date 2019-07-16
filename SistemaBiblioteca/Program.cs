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
            CarregaBaseDeDados();

            var opçaoMenu = MenuPrincipal();

            while (opçaoMenu != 3) //while = repetir o processo / ! = diferente /
            {
                if (opçaoMenu == 1)
                    AlocarLivro();

                if (opçaoMenu == 2)
                    DesalocarUmLivro();
               
               if (opçaoMenu == 4)
                   AjudaInfo();

                opçaoMenu = MenuPrincipal();
            }
            Console.Clear();
            Console.ReadKey();

            if (MenuPrincipal() == 1)
            {
                AlocarLivro();
            }
            Console.ReadKey();
        }
        /// <summary>
        /// Mostrar seja bem vindo
        /// </summary>
        public static void MostrarSejaBemVindo()
        {
            #region
            Console.ForegroundColor = ConsoleColor.Yellow; //fonte amarelo
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("SEJA BEM VINDO A BIBLIOTECA DA NASA");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("DESENVOLVIDA PELAS INDUSTRIAS STARK");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine();
            Console.WriteLine();
            Console.ResetColor();
            #endregion
        }
        /// <summary>
        /// Metodo que mostra o conteudo do menu e as opções de escolha.
        /// </summary>
        /// <returns>Retorna o valor do menu escolhido em um tipo inteiro.</returns>
        public static int MenuPrincipal()
        {
            Console.Clear();

            MostrarSejaBemVindo();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Menu - Inicial");
            Console.WriteLine("O que você deseja realizar?");
            Console.WriteLine();
            Console.WriteLine("1 - Alocar um livro.");
            Console.WriteLine("2 - Devolver um livro.");
            Console.WriteLine("3 - Sair do sistema.");
            Console.WriteLine("4 - Informações de Ajuda.");
            Console.WriteLine();
            Console.WriteLine("Digite a opção desejada:");
            Console.ResetColor();

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
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"O livro:{nomedolivro}" +
                        $", pode ser alocado? {Basedelivros[i, 1]}");

                    return Basedelivros[i, 1] == "SIM";
                    Console.ResetColor();
                }
            }
            return false;
        }
        /// <summary>
        /// Metodo para alterar a informaçao de alocação do livro.
        /// </summary>
        /// <param name="nomedolivro">Nome do livro</param>
        /// <param name="alocar">Valor booleano que define se o livro esta disponivel ou nao.</param>
        public static void Alocarlivro(string nomedolivro, bool alocar)
        {
            for (int i = 0; i < Basedelivros.GetLength(0); i++)
            {
                if (nomedolivro == Basedelivros[i, 0])
                {
                    Basedelivros[i, 1] = alocar ? "Não" : "Sim";
                }
            }
            Console.Clear();
            MostrarSejaBemVindo();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("  Livro Atualizado com Sucesso!!!");
            Console.ResetColor();
        }
        /// <summary>
        /// Metodo que carrega o conteudo inicial da aplicação do menu 1
        /// </summary>
        public static void AlocarLivro()
        {
            MostrarMenuDeLivros("Alocar um livro");

            var nomedolivro = Console.ReadLine();
            if (Pesquisalivro(nomedolivro))
            {
                Console.Clear();
                MostrarSejaBemVindo();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Você deseja alocar o livro? ({nomedolivro})");
                Console.WriteLine();
                Console.WriteLine("Se sim digite (1) Se não digite (2)");
                Console.ResetColor();

                Alocarlivro(nomedolivro, Console.ReadKey().KeyChar.ToString() == "1");

                MostrarListadeLivros();

                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("_______________________________");
                Console.WriteLine("Listagem de livros disponiveis:");

                for (int i = 0; i < Basedelivros.GetLength(0); i++) //preenche automatico com tab+tab
                {
                    Console.WriteLine($"NOME: {Basedelivros[i, 0]} Disponivel:{Basedelivros[i, 1]}");
                }
                Console.ResetColor();

                Console.ReadKey();
            }
        }
        /// <summary>
        /// Metodo que mostra lista de livros atualizado.
        /// </summary>
        public static void MostrarListadeLivros()
        {
            Console.WriteLine("Listagem de Livros:");

            for (int i = 0; i < Basedelivros.GetLength(0); i++)
            {
                Console.WriteLine($"Nome: { Basedelivros[i, 0]} Disponivel: {Basedelivros[i, 1]}");
            }

        }
        public static void DesalocarUmLivro()
        {
            MostrarMenuDeLivros("Desalocar um livro:");

            var nomedolivro = Console.ReadLine();
            if (!Pesquisalivro(nomedolivro))
            {
                Console.Clear();
                MostrarSejaBemVindo();
                Console.WriteLine($"Você deseja desalocar o livro? ({nomedolivro})");
                Console.WriteLine();
                Console.WriteLine("Se sim digite (1) Se não digite (2)");

                Alocarlivro(nomedolivro, Console.ReadKey().KeyChar.ToString() == "0");

                MostrarListadeLivros();

                Console.ReadKey();
            }
        }
        public static void MostrarMenuDeLivros(string operação)
        {
            Console.Clear();

            MostrarSejaBemVindo();
            MostrarListadeLivros();
            Console.WriteLine();
            Console.WriteLine($"Menu - {operação}");
            Console.WriteLine();
            Console.WriteLine("Digite o nome do livro para realizar a operação:");
        }
        /// <summary>
        /// Menu 4 para Ajuda.
        /// </summary>
        public static void AjudaInfo()
        {
            Console.Clear();
            Console.WriteLine("Se você tem duvidas sobre o sistema, por favor acesse:");
            Console.WriteLine("==========================================================================");
            Console.WriteLine("https://www.hbsis.com/hbtech/projeto/bruno.volz/biblioteca.com.br");
            Console.WriteLine("==========================================================================");
            Console.WriteLine("Ou ligue : 0800 999 2929");
            Console.ReadKey();
        }

        public static bool CompararNomes(string primeiro, string segundo)
        {
            if (primeiro.ToLower().Replace(" ", "")
                == segundo.ToLower().Replace(" ", ""));
                return false;
        }
    }
}