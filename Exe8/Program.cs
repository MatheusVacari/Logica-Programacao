using System;

namespace Exe8
{
    class Program
    {
        static void Main(string[] args)
        {
            double juros, capital, taxaemprestimo, n;

            Console.WriteLine("Informe o capital");
            capital = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a taxa de empréstimo");
            taxaemprestimo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o períodos");
            n = Convert.ToDouble(Console.ReadLine());

            juros = capital * (taxaemprestimo/100) * n;

            Console.WriteLine("Emprestimo: " + capital + " Taxa: " + taxaemprestimo + " Período: " + n + " juros será de: " + juros);

            
        }
    }
}
