using System;

namespace Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            double expressao;
            Console.WriteLine("Digite o valor de a: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor de b: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digie o valor de c: ");
            c = Convert.ToInt32(Console.ReadLine());

            expressao = (a ^ 2 * 5 - c / (b - a / 4));

            Console.WriteLine("O reultado da expressão é : " + expressao);

            Console.ReadKey();
        }
    }
}
