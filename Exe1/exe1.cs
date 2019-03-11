using System;

namespace Projetos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dei os valores das variáveis, A = 999, B = 555, C ficou nulo, sem valor
            int A = 999, B = 555, C;

            //Aqui irá informar o valor das variáveis na tela
            Console.WriteLine("O valor de A =" +A+ " E valor de B =" +B);

            C = A; // O valor C que era nula passara a ser 999, ficando assim: (A=999, B=555, C=999)
            A = B; // Esse comando irá deixar valor A igual B, ficará assim:   (A=555, B=555, C=999). Pode observar que apenas o valor C ficou com 999
            B = C; //O valor da variável C passa a ficar armazenado na variável B: (A=555, B=999, C=999)

            Console.WriteLine("Os valores atualizados: A =" +A+ " B =" +B);
            

            
        }
    }
}
