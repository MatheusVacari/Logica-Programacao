using System;

namespace Exe4
{
    class Program
    {
        static void Main(string[] args)
        {
            //informei as variáveis
            double valor1 = 0, valor2 = 0, valor3 = 0, final = 0;
            //Pedi para o usuário informar um valor com uma mensagem amigavel
            Console.Write("Informe o valor desejado: ");
            valor1 = Convert.ToDouble(Console.ReadLine());
           
            //Informar outro valor com mensagem amigavel
            Console.Write("Informe um valor: ");
            valor2 = Convert.ToDouble(Console.ReadLine());
           
            //Informar o teceiro valor
            Console.Write("informe um valor: ");
            valor3 = Convert.ToDouble(Console.ReadLine());
            
            //Equação para efetuar a media dos três valores informado pelo usuário ( soma dos três valores e dividir por 3
            final = (valor1 + valor2 + valor3) / 3;
            
            //Mensagem amigavel informando os valores do usuário
            Console.WriteLine("Você informou os seguintes valores " + valor1 + ", " + valor2 + ", " + valor3);
           
            //Resposta da equação. informando o resultado com uma mensagem amigavel
            Console.Write("A média dos valores será: " + final);
            
        }
    }
}
