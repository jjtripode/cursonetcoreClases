using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreTodo.Models;
using AspNetCoreTodo.Services;
using Microsoft.AspNetCore.Mvc;
namespace AspNetCoreTodo.Controllers
{
  public class TodoController : Controller
  {

    private readonly ITodoItemService _service= null;

    public TodoController(ITodoItemService service)
    {
        _service = service;
    }

    public async Task<IActionResult> Index()
    {
        var items = await _service.GetItemsAsync();

        return View(new TodoViewModel(){ Items =items});
    } 
  }
}

/*





 */