using PrimeiraListaTipada1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiraListaTipada1
{
    class Program
    {
        static void Main(string[] args)
        {
            //O indicador <T> tipo da minha lista com isso temos uma lista de lanches
            List<Lanche> minhalista = new List<Lanche>();

            for (int i = 0; i < 3; i++)
            {
                minhalista.Add(new Lanche()
                {
                    Nome = RetornaValores("Nome"),
                    Quantidade = int.Parse(RetornaValores("Quantidade")),
                    Valor = double.Parse(RetornaValores("Valor"))
                });
            }
            //Aqui ando pela minha lista para poder apresentar em tela os valores
            //item in significa que ele ja é um indice da minha lista bonitinho
            foreach (Lanche item in minhalista)
                Console.WriteLine($"Lanches disponiveis: {item.Nome}, Quantidade: {item.Quantidade}, Valor: {item.Valor}");

                Console.ReadKey();

            //foreach (Lanche item in minhalista)
            //{
            //    if (item.Quantidade == 3)
            //        minhalista.Remove(item);
            //}
            //foreach (Lanche item in minhalista)
            //    Console.WriteLine($"Lanches disponiveis: {item.Nome}");
            //
            //Console.ReadKey();
        }
        /// <summary>
        /// Metodo que mostra uma interface para adicionar valores
        /// </summary>
        /// <param name="nome">Nome do campo que ira retornar o valor</param>
        /// <returns>Retorna uma string com o valor</returns>
        public static string RetornaValores(string nome)
        {
            //Informo e retorno o valor conforme a solicitação do campo
            Console.WriteLine($"Informe o valor para o campo: {nome}");
            return Console.ReadLine();
        }
    }
}
