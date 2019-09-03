using Banco.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banco.WebApi.Services
{
    public interface IClienteService
    {
        Task<Cliente> GetClienteByIDAsync(int id);
        Task<IList<Cliente>> GetAllClientesAsync();
        Task<bool> AddAsync(Cliente cliente);
        Task<bool> DeleteAsync(int id);
        Task<bool> UpdateAsync(Cliente cliente);

    }
}
