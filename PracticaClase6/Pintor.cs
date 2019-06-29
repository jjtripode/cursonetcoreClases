using System;

namespace PracticaClase6
{
    public class Pintor : Persona 
    {
        private string _profesion;

        public Pintor(string profesion)
        {
            _profesion = profesion;
        }
        public void Pintar()
        {
            Console.WriteLine("Pintando....");
        }

        public override string Profesion()
        {
            return _profesion;
        }

        public override void Trabajar(ITarea tarea)
        {
            tarea.Realizar();
        }
    }
}