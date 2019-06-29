using System;
using System.Threading.Tasks;

namespace PracticaClase6
{
    public interface ITarea
    {
        void Realizar();
    }


    public class Pintar : ITarea
    {
        public void Realizar()
        {
            Console.WriteLine("Pintando La casa ....");
            Task.Delay(3000);
            Console.WriteLine("Termine de Pintar La casa ....");
        }
    }

     public class RepararAuto : ITarea
    {
        public void Realizar()
        {
            Console.WriteLine("Reparando  el auto ....");
            Task.Delay(2000);
            Console.WriteLine("Termine de reparar el auto ....");
        }
    }

}