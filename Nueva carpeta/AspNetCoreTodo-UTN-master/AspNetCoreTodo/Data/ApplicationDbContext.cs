using System;
using System.Collections.Generic;
using System.Text;
using AspNetCoreTodo.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreTodo.Data
{
    public class ApplicationDbContext: IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<TodoItem> Items { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
            builder.Entity<TodoItem>().HasData(
                new TodoItem {
                    Id = Guid.NewGuid(),
                    Title = "Curso ASP.NET Core",
                    UserId = "Juan",
                    DueAt = DateTimeOffset.Now.AddDays(1)},
                new TodoItem {
                    Id = Guid.NewGuid(),
                    Title = "Curso React",
                    UserId = "Juan",
                    DueAt = DateTimeOffset.Now.AddDays(1)}
                    );
        }
    }
}
