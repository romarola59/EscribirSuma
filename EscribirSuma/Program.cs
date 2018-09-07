using System;

namespace EscribirSuma
{
    class Program
    {
        public static void EscribirSuma(int a, int b)
        {
            Console.WriteLine(a+b);
        }
        public static void Main()
        {
            Console.Write("La suma de 4 y 7 es: ");
            EscribirSuma(4,7);

            Console.ReadKey();
        }

    }
}
