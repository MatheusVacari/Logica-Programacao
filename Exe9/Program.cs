using System;

namespace ListaDeExercicios2
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, reajuste, final;

            Console.WriteLine("Informe o seu sálario");
            salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o reajuste sálarial");
            reajuste = Convert.ToDouble(Console.ReadLine());

            final = (reajuste / 100) * salario;

            Console.WriteLine("O sálario reajustado será de: " + final);

        }
    }
}
