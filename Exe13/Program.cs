using System;

namespace Exe13
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;

            Console.WriteLine("Informe um número");
            n1 = Convert.ToInt32(Console.ReadLine());

            if(n1 > 10)
            {
                Console.Write("Seu número é maior que 10");
            }
            else
            {
                Console.Write("Seu número é menor que 10");
            }
        }

    }
}
