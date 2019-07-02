using System;
using System.Threading.Tasks;

namespace PracticaClase6
{
    public class Mecanico : Persona<RepararAuto> 
    {
        public Mecanico()
        {
            _profesion = this.GetType().ToString();
        }

        
    }
}