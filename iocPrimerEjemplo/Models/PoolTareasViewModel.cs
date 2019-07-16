using System.Collections.Generic;
using iocPrimerEjemplo.DomainModel;

namespace iocPrimerEjemplo.Models
{
    public class PoolTareasViewModel
    {
        public IList<RepararAuto> autoAReparar 
        {get;set;}
        public IList<Pintar> casaAPintar 
                {get;set;}

    }
}