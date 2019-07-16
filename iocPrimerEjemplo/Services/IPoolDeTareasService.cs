using System.Collections.Generic;
using System.Linq;

namespace iocPrimerEjemplo.DomainModel
{
    public interface IPoolDeTareasService
    {
         void TomarTarea(Mecanico m);

         void TomarTarea(Pintor p);
        IList<RepararAuto> GetAllTareasMecanica();
        IList<Pintar> GetAllTareasPintura();
    }
}