using Microsoft.AspNetCore.Mvc;
using iocPrimerEjemplo.Models;
using iocPrimerEjemplo.DomainModel;

namespace iocPrimerEjemplo.Controllers
{
    public class PoolTareasController : Controller
    {
        private IPoolDeTareasService _service;

        public PoolTareasController(IPoolDeTareasService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            return View(new PoolTareasViewModel()
            {
                autoAReparar = _service.GetAllTareasMecanica(),
                casaAPintar = _service.GetAllTareasPintura()
            });
        }
    }
}