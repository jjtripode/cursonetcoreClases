using System;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreTodo.Models
{
    public class Category
    {
        public Guid Id { get; set; }
        // [Required(ErrorMessage="El nombre es requerido")]
        [StringLength(20)]
        [DataType(DataType.Text)]
        public string Name { get; set; }
    }
}