using System;

namespace Exe14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //
            int = a = 0, n, i;
            //
            Console.WriteLine("Informe um número");
            //
            n = Convert.ToInt32(Console.ReadLine());
            //
            for (i = 1; i < (n + 1); i++)
            {
                if (n % i == 0){
                    a++;
                }
            }
            if (a != 2)
            {
                Console.WriteLine("Não é primo");
            }
            else
            {
                Console.WriteeLine("É primo");
            }
            Console.ReadLine();
        }
    }
}
