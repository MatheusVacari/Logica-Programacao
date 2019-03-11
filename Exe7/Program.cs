using System;

namespace Exe7
{
    class Program
    {
        static void Main(string[] args)
        {
            double CustFabri, porcdistri, porcimposto, custofinal;

            Console.WriteLine("Informe o custo da fabrica");
            CustFabri = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a porcentual do distribuidor");
            porcdistri = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o porcentual dos impostos");
           porcimposto = Convert.ToDouble(Console.ReadLine());

            custofinal = CustFabri + (CustFabri * (porcdistri/100)) + (CustFabri * (porcimposto/100));

            Console.WriteLine("O custo do carro será o valor de: R$" + custofinal);


        }   
    }
}
