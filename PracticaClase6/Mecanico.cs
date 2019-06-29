using System;
using System.Threading.Tasks;

namespace PracticaClase6
{
    public class Mecanico : Persona 
    {
        private string _profesion;

        public Mecanico(string profesion)
        {
            _profesion = profesion;
        }
        public override string Profesion()
        {
            return _profesion;
        }

        public void ReparaAuto()
        {
           Task.Delay(3000); 
           Console.WriteLine("Reparando el auto");
        }

        public override void Trabajar(ITarea tarea)
        {
           tarea.Realizar();
        }
    }
}