using System;
using System.Collections.Generic;
using System.Linq;

namespace iocPrimerEjemplo.DomainModel
{
    public class PoolDeTareasService : IPoolDeTareasService
    {
        private IList<RepararAuto> autoAReparar = new List<RepararAuto>(){new RepararAuto(),new RepararAuto(),new RepararAuto(),new RepararAuto(),new RepararAuto()};
        private IList<Pintar> casaAPintar = new List<Pintar>(){new Pintar(),new Pintar(),new Pintar(),new Pintar(),new Pintar(),new Pintar(),new Pintar(),new Pintar()};
        
        public void AgregarTarea(RepararAuto tarea)
        {
            this.autoAReparar.Add(tarea);
        }

        public IList<RepararAuto> GetAllTareasMecanica()
        {
            return this.autoAReparar;
        }

        public void AgregarTarea(Pintar tarea)
        {
            this.casaAPintar.Add(tarea);
        }

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

        public IList<Pintar> GetAllTareasPintura()
        {
           return casaAPintar;
        }
    }
}