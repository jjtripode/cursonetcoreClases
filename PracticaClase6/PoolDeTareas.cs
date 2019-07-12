using System.Collections.Generic;
using System.Linq;

namespace PracticaClase6
{
    public class PoolDeTareas
    {
        private IList<RepararAuto> autoAReparar = new List<RepararAuto>(){new RepararAuto(),new RepararAuto(),new RepararAuto(),new RepararAuto(),new RepararAuto()};
        private IList<Pintar> casaAPintar = new List<Pintar>(){new Pintar(),new Pintar(),new Pintar(),new Pintar(),new Pintar(),new Pintar(),new Pintar(),new Pintar()};
        public void TomarTarea(Mecanico m)
        {
            if(autoAReparar.Any())
            {
                m.RecibirTarea(autoAReparar.FirstOrDefault());
                autoAReparar.Remove(autoAReparar.FirstOrDefault());
            }
        }

        public void TomarTarea(Pintor p)
        {
            if(casaAPintar.Any())
            {
                 p.RecibirTarea(casaAPintar.FirstOrDefault());
                 casaAPintar.Remove(casaAPintar.FirstOrDefault());
            }
        }
    }
}