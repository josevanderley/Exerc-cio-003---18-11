using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio__003_18_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os três ângulos do triângulo:");

            Console.Write("Ângulo 1: ");
            int angulo1 = int.Parse(Console.ReadLine());

            Console.Write("Ângulo 2: ");
            int angulo2 = int.Parse(Console.ReadLine());

            Console.Write("Ângulo 3: ");
            int angulo3 = int.Parse(Console.ReadLine());

            if (angulo1 == 90 || angulo2 == 90 || angulo3 == 90)
            {
                Console.WriteLine("Triângulo Retângulo");
            }
            else if (angulo1 > 90 || angulo2 > 90 || angulo3 > 90)
            {
                Console.WriteLine("Triângulo Obtusângulo");
            }
            else
            {
                Console.WriteLine("Triângulo Acutângulo");
            }
        }
    }
}
    
