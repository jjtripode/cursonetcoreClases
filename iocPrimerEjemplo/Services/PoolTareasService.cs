using System.Collections.Generic;
using iocPrimerEjemplo.DB;
using iocPrimerEjemplo.DomainModel;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace iocPrimerEjemplo.Services
{
    public class PoolTareasService : IPoolDeTareasService
    {
        private readonly ApplicationDbContext _dbContext;
        public PoolTareasService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IList<RepararAuto>> GetAllTareasMecanica()
        {
            return await _dbContext.TareasRepararAuto.ToListAsync();
        }

     
        public async Task<IList<Pintar>> GetAllTareasPintura()
        {
            return await _dbContext.TareasPintar.ToListAsync();
        }

        public async void TomarTarea(Mecanico m)
        {
            m.RecibirTarea( await _dbContext.TareasRepararAuto.FirstOrDefaultAsync()  );
        }

        public async void TomarTarea(Pintor p)
        {
            p.RecibirTarea( await _dbContext.TareasPintar.FirstOrDefaultAsync() );
        }
    }
}