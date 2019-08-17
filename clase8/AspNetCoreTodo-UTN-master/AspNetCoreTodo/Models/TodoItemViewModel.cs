using System;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreTodo.Models
{
    public class TodoItemViewModel
    {
        
        public Guid Id { get; set; }
        public bool IsDone { get; set; }
        [Required]
        public string Title { get; set; }
        public DateTimeOffset? DueAt { get; set; }
        public string UserId { get; set; }

        // [Required]
        public Guid CategoryId { get; set; }
        public Category[] Categories { get; set; }
    }
}