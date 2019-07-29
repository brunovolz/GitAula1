using BancoCsharp.Classe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta accountUser = new Conta();

            Console.WriteLine("Informe o valor para saque:");

            //Usa a conversão do valor informado
            double.TryParse(Console.ReadLine(), out double valorSacar);

            //Verifica se o valor é maior que 0 e se realizou o saque
            if (valorSacar > 0 && (accountUser.Sacar(valorSacar)))
                Console.WriteLine("Saque realizado com sucesso!");
            else
                Console.WriteLine("Operação não realizada");

            //Mostrar saldo
            Console.WriteLine($"Saldo atual disponviel:{accountUser.MostrarSaldo()}");

            Console.ReadKey();
        }
    }
}
