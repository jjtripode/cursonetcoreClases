using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Banco.WebApi.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nobmre{ get; set; }

        [Required]
        public string Apellido { get; set; }

        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaAlta { get; internal set; }
    }
}
