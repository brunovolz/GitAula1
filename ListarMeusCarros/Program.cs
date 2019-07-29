using ListarMeusCarros.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListarMeusCarros
{
    class Program
    {
        static List<ListaCarros> minhalista;
        static void Main(string[] args)
        {
            minhalista = new List<ListaCarros>();

            var opcaoMenu = MostrarMenu();
            while (opcaoMenu != 3)
            {
                if (opcaoMenu == 1)
                    InserirCarro();

                if (opcaoMenu == 2)
                    ListaCarros();

                opcaoMenu = MostrarMenu();
            }
        }
        public static void InserirCarro()
        {
            for (int i = 0; i < 3; i++)
            {
                minhalista.Add(new ListaCarros()
                {
                    Modelo = RetornaValores("Modelo"),
                    Ano = int.Parse(RetornaValores("Ano")),
                    Placa = RetornaValores("Placa"),
                    Cavalos = int.Parse(RetornaValores("Cavalos"))
                });
            }
        }
        public static void ListaCarros()
        {
            Console.Clear();
            foreach (ListaCarros item in minhalista)
                Console.WriteLine($"Lanches disponiveis: {item.Modelo}, Quantidade: {item.Ano}, " +
                    $"Valor: {item.Placa}, Cavalos: {item.Cavalos}");

            Console.ReadKey();
        }
        public static string RetornaValores(string nome)
        {
            Console.WriteLine($"Informe o valor para o campo: {nome}");
            return Console.ReadLine();
        }
        public static int MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("  BEM VINDO A GARAGEM HBSIS  \r\n");
            Console.WriteLine("  INSIRA SEU CARRO NA LISTA  ");
            Console.WriteLine("             OU              ");
            Console.WriteLine("LISTE OS VEICULOS DISPONIVEIS\r\n");
            Console.WriteLine("(1) Para inserir um novo veiculo");
            Console.WriteLine("(2) Liste os veiculos disponiveis\r\n");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            return opcao;
        }
    }
}
