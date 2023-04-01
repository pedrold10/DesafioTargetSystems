using System;

namespace Questao2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            Fibonacci fibonacci = new Fibonacci();
            bool pertence = fibonacci.ChecaSequencia(numero);

            if (pertence)
            {
                Console.WriteLine($"{numero} pertence à sequência de Fibonacci");
            }
            else
            {
                Console.WriteLine($"{numero} não pertence à sequência de Fibonacci");
            }
        }
    }
}
