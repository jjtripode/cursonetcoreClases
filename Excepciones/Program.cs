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

           var i = 15;

            try

            {
                Console.WriteLine($"El resultado es: {Calculadora.Calcular(op, x, y)}");
            }

            catch (CalculadoraFaltaOperadorException e) 
            {
                Console.WriteLine("Ocurrio un error CalculadoraFaltaOperadorException");
            }

            catch (Exception e) when (e.Message == "")   
            {
                Console.WriteLine("Ocurrio un error Exception Generica"); 
            }

            Console.ReadKey();

        }
    }
}
