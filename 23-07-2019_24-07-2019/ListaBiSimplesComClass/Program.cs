using ListaBiSimplesComClass.Carrega;
using ListaBiSimplesComClass.Mostrar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiSimplesComClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Iniciando o objeto em memoria
            var carregaLista = new CarregaLista();
            //chamando o metodo para carregar a lista
            carregaLista.CarregarInformaçoes();
            //carregamos novamente mas agora a classe mostrar lista
            //aonde colocamos todos os metodos que serão direcionados para mostrar
            //a listagem de informações na tela do console
            var mostrarLista = new MostrarLista();
            //aqui chamamos o metodo novamente
            //mostrarLista.PesquisandoInformaçoes(listaDeNomes, "0");

            Console.ReadKey();
        }
    }
}
