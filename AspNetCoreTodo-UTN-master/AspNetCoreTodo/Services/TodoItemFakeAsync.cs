using System;
using System.Threading.Tasks;
using AspNetCoreTodo.Models;

namespace AspNetCoreTodo.Services
{
    public class TodoItemFakeAsync : ITodoItemService
    {
        public Task<TodoItem[]> GetItemsAsync()
        {

            var item1 = new TodoItem
            {
                Title = "Curso ASP.NET Core",
                DueAt = DateTimeOffset.Now.AddDays(1)
            };
            var item2 = new TodoItem
            {
                Title = "Curso React",
                DueAt = DateTimeOffset.Now.AddDays(2)
            };
            var items = new[] { item1, item2 };
            // Put items into a model
            

            return Task.FromResult(items);
        }
    }
}