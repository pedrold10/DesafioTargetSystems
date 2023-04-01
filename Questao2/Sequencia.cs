using System;

namespace Questao2
{
    class Fibonacci
    {
        public bool ChecaSequencia(int numero)
        {
            if (numero < 0)
            {
                return false;
            }

            int a = 0;
            int b = 1;

            while (b < numero)
            {
                int temp = b;
                b = a + b;
                a = temp;
            }

            return b == numero;
        }
    }
}
