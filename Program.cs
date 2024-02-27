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
            double dist = double.Parse(Console.ReadLine());

            Console.WriteLine("Qauntos km o veículo faz com um litro de combustível: ");
            double rend = double.Parse(Console.ReadLine());  

            double consumo = (dist / rend) * valor;

            Console.WriteLine("O valor gasto na viagem será de: " + consumo);

            Console.ReadKey();

        }
    }
}
