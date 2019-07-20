using System;
using AspNetCoreTodo.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreTodo
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {
            
        }

        public DbSet<TodoItem> Items {get;set;}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<TodoItem>().HasData(
                new TodoItem
                {
                    Id  = Guid.NewGuid(),
                    Title = "Curso ASP.NET Core UTN",
                    DueAt = DateTimeOffset.Now.AddDays(1)
                }
            );

            builder.Entity<TodoItem>().HasData(
                new TodoItem
                {
                    Id  = Guid.NewGuid(),
                    Title = "Curso React",
                    DueAt = DateTimeOffset.Now.AddDays(1)
                }
            );

            base.OnModelCreating(builder);
        }
    }
}