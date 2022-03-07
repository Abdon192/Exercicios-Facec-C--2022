using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal distanciaPercorrida = 0.0m;
            decimal litrosGastos = 0.0m;
            Console.WriteLine("Informe a distância percorrida em KM: ");
            decimal.TryParse(Console.ReadLine(), out distanciaPercorrida);

            Console.WriteLine("Informe quantos litros de combustível foram gastos: ");
            decimal.TryParse(Console.ReadLine(), out litrosGastos);

            Console.WriteLine($"Sua média de quilômetros por litro foi de: {distanciaPercorrida / litrosGastos}");
            Console.ReadLine();

        }
    }
}