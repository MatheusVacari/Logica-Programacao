using System;

namespace Exe12
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1;

            Console.WriteLine("Informe um número");
            n1 = Convert.ToDouble(Console.ReadLine());

            if(n1 >= 0)
            {
                Console.Write("Número é positivo");
            }
            else
            {
                Console.Write("Número é negativo");
            }
        }
    }
}
