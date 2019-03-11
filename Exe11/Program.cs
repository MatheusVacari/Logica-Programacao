using System;

namespace Exe11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            Console.WriteLine("Informe um número inteiro");
            n1 = Convert.ToInt32(Console.ReadLine());

            if (n1 % 2 == 0)
            {
                Console.Write("Número é par");
            }
            else
            {
                Console.Write("Número é impar");
            }
        }
    }
}
