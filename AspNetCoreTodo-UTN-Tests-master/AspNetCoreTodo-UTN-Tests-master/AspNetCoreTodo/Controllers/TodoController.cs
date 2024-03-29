using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreTodo.Models;
using AspNetCoreTodo.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace AspNetCoreTodo.Controllers
{
  public class TodoController : Controller
  {
    private readonly ITodoItemService _todoItemService;
    public TodoController(ITodoItemService todoItemService)
    {
        _todoItemService = todoItemService;
    }
    public async Task<IActionResult> Index()
    {
      // Get to-do items from database
      var items = await _todoItemService.GetIncompleteItemsAsync();
      
      // Put items into a model
      var model = new TodoViewModel()
      {
        Items = items
      };
      // Render view using the model
      return View(model);
    }

    [ValidateAntiForgeryToken]
    public async Task<IActionResult> AddItem(TodoItem newItem)
    {
      if (!ModelState.IsValid)
      {
        return BadRequest(ModelState);
      }
      await _todoItemService.AddItemAsync(newItem);
      
      return RedirectToAction("Index");
    }

    [ValidateAntiForgeryToken]
    public async Task<IActionResult> MarkDone(Guid id)
    {
      if (id == Guid.Empty)
      {
        return BadRequest(ModelState);
      }

      await _todoItemService.MarkDoneAsync(id);

      return RedirectToAction("Index");
    }
  }
}