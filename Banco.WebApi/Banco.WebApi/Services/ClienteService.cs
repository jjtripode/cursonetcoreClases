using Banco.WebApi.Data;
using Banco.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banco.WebApi.Services
{
    public class ClienteServiceAsync : IClienteService
    {
        private readonly ApplicationDBContext _context;

        public ClienteServiceAsync(ApplicationDBContext context)
        {
            _context = context;

            if (!_context.Clientes.Any())
            {
                _context.AddRange(Enumerable.Range(1, 20).Select(
                    i => new Cliente()
                    {
                        Nobmre = "Nobmre" + i,
                        FechaAlta = DateTime.Now,
                        Apellido = "Apellido" + i,
                        FechaNacimiento = DateTime.Now.AddYears(-i)
                    }
                    )
                    );

                _context.SaveChanges();
                }
        }
        public async Task<bool> AddAsync(Cliente cliente)
        {
            cliente.FechaAlta = DateTime.Now;
            _context.Clientes.Add(cliente);
            return   await _context.SaveChangesAsync() == 1;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            _context.Clientes.Remove( _context.Clientes.Where(c=> c.Id ==id).FirstOrDefault());

            return await _context.SaveChangesAsync() == 1;
        }

        public async Task<IList<Cliente>> GetAllClientesAsync()
        {
            return await _context.Clientes.ToListAsync();
        }

        public async Task<Cliente> GetClienteByIDAsync(int id)
        {
            return await _context.Clientes.Where(c => c.Id == id).FirstOrDefaultAsync();
        }

        public async Task<bool> UpdateAsync(Cliente cliente)
        {
            var existingEntity = await GetClienteByIDAsync(cliente.Id);

            existingEntity.Apellido = cliente.Apellido;
            existingEntity.FechaNacimiento = cliente.FechaNacimiento;
            existingEntity.Nobmre = cliente.Nobmre;
            

            _context.Clientes.Update(existingEntity);

           return await _context.SaveChangesAsync() == 1;
        }
    }
}
