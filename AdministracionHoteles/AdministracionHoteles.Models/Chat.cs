using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionHoteles.Models
{
	internal class Chat
	{
		[Key]
		public int id { get; set; }

		[ForeignKey("Usuarios")]
		public int Usuarioid { get; set; }
		public string Nombre { get; set; }
		public string Mensaje { get; set; }
		public DateTime Fecha { get; set; }
		public string De { get; set; }
		public string Para { get; set; }

		public virtual Usuarios Usuarios { get; set; }

	}
}
