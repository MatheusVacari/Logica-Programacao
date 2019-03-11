using System;

namespace Exe2
{
    class exe2
    {
        static void Main(string[] args)
        {

            double celsius, fahrenheit;
            Console.WriteLine("Digite o valor em celsius no qual gostaria de converter em Fahrenheit");
            celsius = Convert.ToDouble(Console.ReadLine());

            fahrenheit = (1.8 * celsius) + 32;
            Console.WriteLine("A temperatura " +celsius+ " em celsius convertida em fahrenheit ficará: " +fahrenheit);
        }
    }
}
