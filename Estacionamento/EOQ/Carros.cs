using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.EOQ
{
    class Carros
    {
        public string[,] ListaCarros;
        public void mostrarCarros(string registros)
        {
            for (int i = 0; i < ListaCarros.GetLength(0); i++)
            {
                Console.WriteLine($"Modelo: {ListaCarros[i, 0]}" +
                    $"Placa: {ListaCarros[i, 1]}" +
                    $"Hora de entrada: {ListaCarros[i, 2]}" +
                    $"Hora de saída: {ListaCarros[i, 3]}");
            }
            Console.ReadKey();
        }
        public string horarioEnt()
        {
            DateTime hora = DateTime.Now;
            Console.WriteLine(hora.ToString("dd/MM/yyyy"));
            return horarioSai();
        }
        public string horarioSai()
        {
            DateTime hora = DateTime.Now;
            Console.WriteLine(hora.ToString("dd/MM/yyyy"));
            return horarioEnt();
        }

        public void registros()
        {
            ListaCarros = new string[5, 4]
            {
            {"GOL","200210","SIM",""},
            {"ONIX","20131230","NÃO",""},
            {"JOPINDER","203242310","NÃO",""},
            {"ROLEXSZ","202342310","NÃO",""},
            {"XIPANDOOCOCO","202342310","NÃO",""}
            };
        }
    }
}
