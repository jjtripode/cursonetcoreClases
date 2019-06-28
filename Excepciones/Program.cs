using System;

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ingrese un numero");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine(" ingrese un numero");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine(" ingrese un operador");
            string op = Console.ReadLine();
            Console.WriteLine($"El resultado es: {Calculadora.Calcular(op,x,y)}");

            Console.ReadKey();
        }
    }
}
