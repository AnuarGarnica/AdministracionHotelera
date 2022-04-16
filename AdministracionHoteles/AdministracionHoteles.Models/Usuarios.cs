using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionHoteles.Models
{
    internal class Usuarios
    {
		[Key]
		public int id { get; set; }
		public string Nombre { get; set; }
		public string Telefono { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public bool Estatus { get; set; }
		public int UsuarioPadre { get; set; }
		public string Foto { get; set; }
		public string Puesto { get; set; }
	}
}
