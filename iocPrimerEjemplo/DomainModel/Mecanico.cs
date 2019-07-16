using System;
using System.Threading.Tasks;

namespace iocPrimerEjemplo.DomainModel
{
    public class Mecanico : Persona<RepararAuto> 
    {
        public Mecanico()
        {
            _profesion = this.GetType().ToString();
        }
    }
}