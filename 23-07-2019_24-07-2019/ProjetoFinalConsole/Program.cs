using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] baseDeDados = new string[2, 5];

            int IndiceBaseDados = 0;

            MenuInicial();

            var escolhaInicial = MenuOpçoes();

            while (true)
            {
                switch (escolhaInicial)
                {
                    case "1": { InserirLivro(ref baseDeDados, ref IndiceBaseDados); } break;
                    case "2": { RemoverLivro(ref baseDeDados); } break;
                    case "3": { MostrarInformaçoes(baseDeDados); } break;
                    case "4": { MostrarInformaçoes(baseDeDados, "true"); } break;
                    case "5": {
                            return;
                        }
                }
                escolhaInicial = MenuOpçoes();
            }
        }
        public static void MenuInicial()
        {

            Console.WriteLine("=================================");
            Console.WriteLine("Seja Bem vindo a Biblioteca HBSIS");
            Console.WriteLine("=================================");
            Console.WriteLine("   Desenvolvida por Bruno Volz   ");
            Console.WriteLine("================================ ");
            Console.WriteLine("      Projeto Final Console      \n");
        }
        public static string MenuOpçoes()
        {
            Console.WriteLine("\n========== MENU ===========\n");
            Console.WriteLine("1 - Adicionar Livro");
            Console.WriteLine("2 - Remover Livro");
            Console.WriteLine("3 - Listar Livros disponiveis");
            Console.WriteLine("4 - Listar livros indisponiveis ");
            Console.WriteLine("5 - Sair do sistema \n");
            Console.WriteLine("Digite o número da opção desejada:\n");
            return Console.ReadLine();
        }
        public static void InserirLivro(ref string[,] baseDeDados, ref int IndiceBaseDados)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("========== Adicionar livros na Biblioteca ===========\n");
            Console.ResetColor();
            Console.WriteLine("Informe um nome:");
            var nome = Console.ReadLine();
            Console.WriteLine("Informe o Autor");
            var autor = Console.ReadLine();

            AumentarLista(ref baseDeDados);

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if (baseDeDados[i, 0] != null)
                    continue;

                baseDeDados[i, 0] = (IndiceBaseDados++).ToString();
                baseDeDados[i, 1] = nome;
                baseDeDados[i, 2] = autor;
                baseDeDados[i, 3] = "true";
                baseDeDados[i, 4] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                break;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nLivro cadastrado com sucesso!\n");
            Console.ResetColor();
            Console.WriteLine("Para voltar ao Menu Inicial, pressione qualquer tecla.");
            Console.ReadKey();
            Console.Clear();
        }
        public static void MostrarInformaçoes(string[,] baseDeDados, string livroNAtivo = "false")
        {
            if (livroNAtivo == "false")
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nLivros disponiveis na Biblioteca.\n");
            Console.ResetColor();

            if (livroNAtivo == "true")
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Livros indisponiveis na Biblioteca.\n");
            Console.ResetColor();

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if (baseDeDados[i, 3] != livroNAtivo)
                    Console.WriteLine($"ID {baseDeDados[i, 0]} " +
                        $" || Nome: {baseDeDados[i, 1]}" +
                        $" || Autor: {baseDeDados[i, 2]}" +
                        $" || Data de Alteração:{baseDeDados[i, 4]}");
            }
            Console.WriteLine("\nPara voltar ao Menu Inicial, pressione qualquer tecla.");
            Console.ReadKey();
            Console.Clear();
        }
        public static void RemoverLivro(ref string[,] baseDeDados)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("===== Menu de remoção de livros =====\n");
            Console.ResetColor();
            Console.WriteLine("Informe o ID do livro a ser removido:\n");
            var id = Console.ReadLine();

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if (baseDeDados[i, 3] != "false")
                    Console.WriteLine($"ID:{baseDeDados[i, 0]} " +
                        $" || Nome:{baseDeDados[i, 1]} " +
                        $" || Autor:{baseDeDados[i, 2]}");
            }
            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if (baseDeDados[i, 0] != null && baseDeDados[i, 0] == id)
                {
                    baseDeDados[i, 3] = "false";
                    baseDeDados[i, 4] = DateTime.Now.ToString("dd/MM:yyyy HH:mm:ss");
                }
            }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nLivro removido com sucesso!\n");
                Console.ResetColor();
                Console.WriteLine("Para voltar ao Menu Inicial, pressione qualquer tecla.");
                Console.ReadKey();
                Console.Clear();
        }
        public static void AumentarLista(ref string[,] baseDeDados)
        {
            var LimiteLista = true;

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if (baseDeDados[i, 0] == null)
                    LimiteLista = false;
            }
            if (LimiteLista)
            {
                var ListaCopia = baseDeDados;

                baseDeDados = new string[baseDeDados.GetLength(0) + 2, 5];

                for (int i = 0; i < ListaCopia.GetLength(0); i++)
                {
                    baseDeDados[i, 0] = ListaCopia[i, 0];
                    baseDeDados[i, 1] = ListaCopia[i, 1];
                    baseDeDados[i, 2] = ListaCopia[i, 2];
                    baseDeDados[i, 3] = ListaCopia[i, 3];
                    baseDeDados[i, 4] = ListaCopia[i, 4];
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nO tamanho da lista foi atualizado.");
                Console.ResetColor();
            }
        }

    }
}
