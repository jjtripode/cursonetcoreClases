using System;
using System.Threading.Tasks;
using AspNetCoreTodo.Data;
using AspNetCoreTodo.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreTodo.Services
{

    public class CategoryService : ICategoryService
    {
        private ApplicationDbContext _context;

        public CategoryService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Category[]> GetAllAsync()
        {
            return await _context.Categories.ToArrayAsync();
        }

        public async Task<Category> GetByIdAsync(Guid id)
        {
            return await _context.Categories.FirstOrDefaultAsync();
        }
    }
}