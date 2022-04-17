using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionHoteles.Models
{
    public class Suscripciones
    {
        [Key]
        public int id { get; set; }
        public string Email { get; set; }
        public bool Activo { get; set; }
    }
}
