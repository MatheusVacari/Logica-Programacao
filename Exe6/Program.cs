using System;

namespace Exe6
{
    class Program
    {
        static void Main(string[] args)
        {
            double t1, t2, t3, t4, t5, media; // Identifiquei as váriaveis


            Console.WriteLine("Informe cinco número para efetuar a média");
            t1 = Convert.ToDouble(Console.ReadLine());
            t2 = Convert.ToDouble(Console.ReadLine());
            t3 = Convert.ToDouble(Console.ReadLine());
            t4 = Convert.ToDouble(Console.ReadLine());
            t5 = Convert.ToDouble(Console.ReadLine());

            media = (t1 + t2 + t3 + t4 + t5) / 5;

            Console.Write("A média dos valores informados será de: "+ media);

            
        }
        
    }
}
