using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppViagem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o valor do combustível: ");
            double valor = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual será a distância percorrida em km: ");
            int dist = int.Parse(Console.ReadLine());

            Console.WriteLine("Qauntos km o veículo faz com um litro de combustível: ");
            int rend = int.Parse(Console.ReadLine());  

            int consumo = dist / rend;

            double resultado = consumo * valor;

            Console.WriteLine("O valor gasto na viagem será de: " + resultado);

            Console.ReadKey();

        }
    }
}
