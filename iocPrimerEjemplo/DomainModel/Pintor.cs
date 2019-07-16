using System;

namespace iocPrimerEjemplo.DomainModel
{
    public class Pintor : Persona<Pintar> 
    {
        public Pintor()
        {
            _profesion = this.GetType().ToString();
        }
        public void Pintar()
        {
            Console.WriteLine("Pintando....");
        }
    }
}