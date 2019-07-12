using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaIngredientes();
            ModoPreparo();
            Cobertura();
        }
        public static void Prosseguir()
        {
            Console.WriteLine("Pressione qualquer tecla para continuar");
            Console.ReadKey();
        }
        public static void BemVindo()
        {
            Console.WriteLine("=======================================");
            Console.WriteLine("Bem vindo a Ultra Mega e Extraordinaria");
            Console.WriteLine("   Super Receita de Bolo de Cenoura");
            Console.WriteLine("=======================================\n");
            Prosseguir();
        }
        public static void ListaIngredientes()
        {
            BemVindo();
            Console.Clear();
            Console.WriteLine("\nPrimeiro precisaremos de todos os ingredientes\n");
            Console.WriteLine("Já os deixe separados para facilitar!\n");
            Console.WriteLine("INGREDIENTES PARA A MASSA");
            Console.WriteLine("3 cenouras médias raspadas e picadas");
            Console.WriteLine("3 ovos");
            Console.WriteLine("1 xícara de óleo");
            Console.WriteLine("2 xícaras de açúcar");
            Console.WriteLine("2 xícaras de farinha de trigo");
            Console.WriteLine("1 colher (sopa) de fermento em pó");
            Console.WriteLine("1 pitada de sal\n");
            Prosseguir();
            Console.Clear();
            Console.WriteLine("\nINGREDIENTES PARA A FORMA");
            Console.WriteLine("Manteiga para untar");
            Console.WriteLine("Farinha para povilhar\n");
            Prosseguir();
            Console.Clear();
            Console.WriteLine("\nINGREDIENTES PARA A COBERTURA");
            Console.WriteLine("5 colheres (sopa) de açúcar");
            Console.WriteLine("3 colheres (sopa) de chocolate em pó");
            Console.WriteLine("2 colheres (sopa) de manteiga");
            Console.WriteLine("2 colheres (sopa) de leite\n");
            Console.WriteLine("Se já estiver com todos os ingredientes");
            Prosseguir();
        }
        public static void ModoPreparo()
        {
            Console.Clear();
            Console.WriteLine("O modo de preparo do bolo é muito fácil!");
            Console.WriteLine("Basta bater no liquidificador todos os ingredientes");
            Console.WriteLine("E acrescentar a farinha aos poucos.\n");
            Prosseguir();
            Console.Clear();
            Console.WriteLine("Depois unte e enfarinhe uma forma e despeje a massa nela");
            Console.WriteLine("Asse em forno médio por cerca de 40 minutos");
            Console.WriteLine("Tire do forno, espere amornar e desenforme\n");
            Prosseguir();
    }
        public static void Cobertura()
        {
            Console.Clear();
            Console.WriteLine("Enquanto o bolo assa, em uma panela, coloque todos os ingredientes da cobertura e mexa bem até levantar fervura");
            Console.WriteLine("Depois espalhe sobre o bolo ainda quente e quando esfriar vai formar uma casquinha\n");
            Prosseguir();
            Console.WriteLine("\nAGORA COME O ESSA DELIÇIA");
            Console.ReadKey();
        }

    }
}
