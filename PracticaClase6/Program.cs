using System;

namespace PracticaClase6
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona mec = new Mecanico("Mecanico");
            Persona pin = new Pintor("Pintor");

            mec.Trabajar(new RepararAuto());

            pin.Trabajar(new Pintar());

            Console.ReadKey();
        }
    }
}
