using System;
using System.Threading.Tasks;
using AspNetCoreTodo.Models;

namespace AspNetCoreTodo.Services
{
    public interface ICategoryService 
    {
        Task<Category[]> GetAllAsync();
        Task<Category> GetByIdAsync(Guid id);

    }
}