using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Locação_de_Carros_Oficial
{
    class Program
    {
        static string[,] BaseDeCarros;
        static void Main(string[] args)
        {
            CarregaBaseDeDados();

            var opcaoMenu = MenuPrincipal();

            while (opcaoMenu != 4)
            {
                if (opcaoMenu == 1)
                    AlocarUmCarro();

                if (opcaoMenu == 2)
                    DesalocarUmCarro();

                if (opcaoMenu == 3)
                    ReservarUmCarro();

                opcaoMenu = MenuPrincipal();
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Mostra as informações iniciais do sistema.
        /// </summary>
        public static void MostrarSejaBemVindo()
        {
            Console.WriteLine("________________________________________________");
            Console.WriteLine("      BEM VINDO AO SISTEMA DE LOCAÇÃO DE CARROS.");
            Console.WriteLine("________________________________________________");
            Console.WriteLine("    Desenvolvido pelas industrias STARKINSSONS  ");
            Console.WriteLine("________________________________________________");
        }
        /// <summary>
        /// Metodo que mostra o menu inicial com as opções para escolha.
        /// </summary>
        /// <returns>Retorna o número do menu escolhido.</returns>
        public static int MenuPrincipal()
        {
            Console.Clear();

            MostrarSejaBemVindo();

            Console.WriteLine("Menu - Inicial");
            Console.WriteLine("O que você deseja realizar?");
            Console.WriteLine("1 - Alocar um carro.");
            Console.WriteLine("2 - Devolver um carro.");
            Console.WriteLine("3 - Reservar um carro.");
            Console.WriteLine("4 - Sair do sistema.");
            Console.WriteLine("Digite o número desejado:");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            return opcao;
        }
        /// <summary>
        /// Metodo que carrega a base de dados dentro do sistema.
        /// </summary>
        public static void CarregaBaseDeDados()
        {
            BaseDeCarros = new string[2, 3]
            {
            {"GOL","2000","SIM"},
            {"ONIX","2010","NÃO"}
            };
        }
        /// <summary>
        /// Metodo que retorna se um livro pode ser alocado.
        /// </summary>
        /// <param name="nomeCarro">Nome do livro a ser pesquisado</param>
        /// <returns>Retorna verdadeiro em caso o livro estiver livre para alocação.</returns>
        public static bool? PesquisaCarroParaLocaçao(string nomeCarro)
        {
            for (int i = 0; i < BaseDeCarros.GetLength(0); i++)
            {
                if (CompararNomes(nomeCarro, BaseDeCarros[i, 0]))
                {
                    Console.WriteLine($"O CARRO: {nomeCarro}" +
                    $" ANO: {BaseDeCarros[i, 1]}" +
                    $" ESTA DISPONIVEL? {BaseDeCarros[i, 2]}");

                    return BaseDeCarros[i, 1] == "SIM";
                }
            }

            return false;
        }
        /// <summary> 
        /// Metodo para alterar a informação de alocação do livro.
        /// </summary>
        /// <param name="NomeCarro">Nome do livro</param>
        /// <param name="locar">Valor booleano que define se o livro esta ou não disponivel.</param>
        public static void LocarCarro(string NomeCarro, bool locar)
        {
            for (int i = 0; i < BaseDeCarros.GetLength(0); i++)
            {
                if (CompararNomes(NomeCarro, BaseDeCarros[i, 0]))
                {
                    BaseDeCarros[i, 1] = locar ? "NÃO" : "SIM";
                }
            }

            Console.Clear();
            MostrarSejaBemVindo();
            Console.WriteLine("Carro atualizado com sucesso!");
        }
        /// <summary>
        /// Metodo que carrega o conteudo inicial da aplicação do menu 1
        /// </summary>
        public static void AlocarUmCarro()
        {
            MostrarMenuInicialCarros("Alocar um carro:");

            var NomeDoCarro = Console.ReadLine();
            var ResultadoPesquisa = PesquisaCarroParaLocaçao(nomeCarro);

            if (ResultadoPesquisa != null && ResultadoPesquisa == true)
            {
                Console.Clear();
                MostrarSejaBemVindo();
                Console.WriteLine("Você deseja alocar o carro? para sim(1) para não(0)");

                LocarCarro(NomeDoCarro, Console.ReadKey().KeyChar.ToString() == "1");

                MostarListaDeCarros();

                Console.ReadKey();
            }

            if(ResultadoPesquisa == null)
            {
                Console.WriteLine("Nenhum carro encontrado em nossa base de dados");
            }
        }
        /// <summary>
        /// Metodo que mostra a lista de livros atualizado
        /// </summary>
        public static void MostarListaDeCarros()
        {
            Console.WriteLine("Listagem de carros:");

            for (int i = 0; i < BaseDeCarros.GetLength(0); i++)
            {
                Console.WriteLine($"Nome: {BaseDeCarros[i, 0]} Disponivel:{BaseDeCarros[i, 2]}");
            }
        }
        public static void DesalocarUmCarro()
        {
            MostrarMenuInicialCarros("Desalocar um carro:");

            MostarListaDeCarros();

            var nomeCarro = Console.ReadLine();
            var resultadoPesquisa = PesquisaCarroParaLocaçao(nomeCarro);

            if (resultadoPesquisa != null && resultadoPesquisa == false)
            {
                Console.Clear();
                MostrarSejaBemVindo();
                Console.WriteLine("Você deseja desalocar o carro? para sim(1) para não(0)");

                LocarCarro(nomeCarro, Console.ReadKey().KeyChar.ToString() == "0");

                MostarListaDeCarros();

                Console.ReadKey();
            }

            if (resultadoPesquisa == null)
            {
                Console.WriteLine("Nenhum carro encontrado em nosso banco de dados.");
            }
        }
        public static void MostrarMenuInicialCarros(string operacao)
        {
            Console.Clear();

            MostrarSejaBemVindo();

            Console.WriteLine($"Menu - {operacao}");
            Console.WriteLine("Digite o nome do carro para realizar a operação:");
        }

        public static void ReservarUmCarro()
        {
            Console.WriteLine("Escolha um carro da lista para prosseguir");

            MostarListaDeCarros();
        }

        public static bool CompararNomes(string informaçaoParaComparar, string informaçaoAserComparada)
        {
            if (informaçaoParaComparar.ToLower().Replace(" ", "")
                == informaçaoAserComparada.ToLower().Replace(" ", ""))
                return true;
        }
    }
}
