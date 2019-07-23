using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuCarro4x4Class.MyFirstClass
{
    class Carro
    {
        public int rodas { get; set; } = 0;
        public int portas { get; set; } = 0;
        public int bancos { get; set; } = 0;
        public int janelas { get; set; } = 0; //se não especificar public fica privado
        
        public void MostrarCarro()
        {
            Console.WriteLine($"Nosso carro:\r\n" +
                $"Quant Rodas[{rodas}]\r\n" +
                $"Quant Portas[{portas}]\r\n" +
                $"Quant Bancos[{bancos}]\r\n" +
                $"Quant Janelas[{janelas}]");
        }
    }
}
