using System;

namespace Exe10
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, resultado, resposta;
            
            

            Console.WriteLine("Informe um número!");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe outro valor");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Deseja executar qual operação, digite (1) para adição, (2) para subtrair, (3) para multiplicar, (4) para efetuar a divisão");
            resposta = Console.ReadLine();

            if (resposta == 1)
            {
                resultado = n1 + n2;
            }
            else if (resposta == 2){
                resultado = n1 - n2;
            }
            if (resposta == 3)
            {
                resultado = n1 * n2;
            }
            else if (resposta == 4)
            {
                resultado = n1 / n2;
            }
            Console.WriteLine("Resultado da operação será: " + resultado);




        }
    }
}
