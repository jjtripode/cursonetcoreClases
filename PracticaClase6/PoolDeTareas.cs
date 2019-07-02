using System.Collections.Generic;
using System.Linq;

namespace PracticaClase6
{
    public class PoolDeTareas
    {
        private IList<RepararAuto> autoAReparar = new List<RepararAuto>();
        private IList<Pintar> casaAPintar = new List<Pintar>();
        public void TomarTarea(Mecanico m)
        {
            if(autoAReparar.Any())
            {
                m.RecibirTarea(new RepararAuto());
            }
        }

        public void TomarTarea(Pintor p)
        {
            if(casaAPintar.Any())
            {
                 p.RecibirTarea(new Pintar());
            }
        }
    }
}