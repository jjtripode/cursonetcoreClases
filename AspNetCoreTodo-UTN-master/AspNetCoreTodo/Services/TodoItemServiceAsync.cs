using System;
using System.Threading.Tasks;
using AspNetCoreTodo.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreTodo.Services
{
    public class TodoItemServiceAsync : ITodoItemService
    {
        private readonly ApplicationDbContext _context;

        public TodoItemServiceAsync(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<TodoItem[]> GetItemsAsync()
        {
            return await _context.Items.Where(i => !i.IsDone).ToArrayAsync();
        }
    }
}