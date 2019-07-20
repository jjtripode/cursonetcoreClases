using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using iocPrimerEjemplo.DomainModel;

namespace iocPrimerEjemplo.Services
{
    public interface IPoolDeTareasService
    {
         void TomarTarea(Mecanico m);

         void TomarTarea(Pintor p);
        Task<IList<RepararAuto>> GetAllTareasMecanica();
        Task<IList<Pintar>> GetAllTareasPintura();
    }
}