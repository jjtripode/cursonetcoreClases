using System;

namespace Eventos
{
    class Program
    {
        static void Main(string[] args)
        {
            Numeros num = new Numeros();

            Console.WriteLine($"Comprobando si el numero {2} es par.");

            num.Evento_Par += DeteccionNumeroPar;
           
            num.Evento_Par += ()=> Console.WriteLine($"Desde Lanmda");
            num.Evento_Par += delegate() {Console.WriteLine($"Desde Delegado");};

            // while (Console.ReadLine() != "F")
            // {
                num.Num = 2;
            // }

            Console.ReadKey();
        }

        private static void DeteccionNumeroPar()
        {
            Console.WriteLine("El numero es par");
        }
    }
}
