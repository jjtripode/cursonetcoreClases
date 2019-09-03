using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Banco.WebApi.Data;
using Banco.WebApi.Models;
using Banco.WebApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Banco.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private IClienteService _clienteService;

        //Task<ActionResult<IList<Cliente>>>


        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        // GET: api/Cliente
        [HttpGet]
        public async Task<IList<Cliente>> Get()
        {
            return await _clienteService.GetAllClientesAsync();
        }

        // GET: api/Cliente/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<Cliente>  Get(int id)
        {
            return await _clienteService.GetClienteByIDAsync(id);
        }

        // POST: api/Cliente
        [HttpPost]
        public async Task<Cliente> Post([FromBody] Cliente model)
        {
           await _clienteService.AddAsync(model);

          return  await _clienteService.GetClienteByIDAsync(model.Id) ;
        }

        // PUT: api/Cliente/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
