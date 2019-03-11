using System;

namespace Exe5
{
    class Program
    {
        static void Main(string[] args)
        {   //
            int meses = 0, dias = 0;
           
            //
            Console.WriteLine("Informe o número de meses que deseja calcular os dias");
                meses = Convert.ToInt32(Console.ReadLine());
           
            //
            dias = meses * 30;
            
            //
             Console.WriteLine("O número de meses: " + meses + ", total de dias: " + dias + " (1mes = 30 dias) ");


           
        }
    }
}
