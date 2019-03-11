using System;

namespace Exe3
{
    class Exe3
    {
        static void Main(string[] args)
        {
            //Informei as variáveis
            int numero = 0, sucessor = 0, antecessor = 0;
            //Uma mensagem amigavel para o usuário(a). Pedindo para informar um número
            Console.Write("Informe um numero: ");
            //O número que o usuário informar será gravado na variável (numero) e irá informar para o usuário
            numero = Convert.ToInt32(Console.ReadLine());
            //Será somado 1 para o número informado pelo usuário, sendo o sucessor do número.
            sucessor = numero + 1;
            //Aqui será subtraido 1 do número informado.
            antecessor = numero - 1;
            //Mensagem amigavel mostrando o número que o usuário informou seu antecessor e sucessor
            Console.WriteLine("Seu número: " +numero+ ", o antecessor será: " +antecessor+ " e o sucessor: " +sucessor);


        }
    }
}
