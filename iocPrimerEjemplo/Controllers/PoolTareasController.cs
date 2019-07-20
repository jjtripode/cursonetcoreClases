using Microsoft.AspNetCore.Mvc;
using iocPrimerEjemplo.Models;
using iocPrimerEjemplo.DomainModel;
using iocPrimerEjemplo.Services;

namespace iocPrimerEjemplo.Controllers
{
    public class PoolTareasController : Controller
    {
        private IPoolDeTareasService _service;

        public PoolTareasController(IPoolDeTareasService service)
        {
            _service = service;
        }
        public ActionResult Index()
        {
            return  View(new PoolTareasViewModel()
            {
                autoAReparar = _service.GetAllTareasMecanica().Result,
                casaAPintar = _service.GetAllTareasPintura().Result
            });
        }
    }
}