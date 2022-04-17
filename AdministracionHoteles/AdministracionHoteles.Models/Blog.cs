using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionHoteles.Models
{
    public class Blog
    {
		[Key]
		public int id { get; set; }
		public string Titulo { get; set; }
		public string Descripcion { get; set; }
		public string Post { get; set; }
		public DateTime Fecha { get; set; }
		public DateTime FechaModificacion { get; set; }
		public string Tipo { get; set; }
		public string Categoria { get; set; }
		public string Video { get; set; }
		public string Imagen { get; set; }
		public int Consultas { get; set; }
		public string Tags { get; set; }
		public string MetaKeys { get; set; }

		[ForeignKey("Usuarios")]
		public int Usuarioid { get; set; }
		public bool Activo { get; set; }
		[ForeignKey("Hoteles")]
		public int Hotelid { get; set; }
		[ForeignKey("Servicios")]
		public int Servicioid { get; set; }
		[ForeignKey("Habitaciones")]
		public int Habitacionid { get; set; }

		public virtual Usuarios Usuarios { get; set; }
		public virtual Hoteles Hoteles { get; set; }
		public virtual ServiciosExtras ServiciosExtras { get; set; }
		public virtual Habitaciones Habitaciones { get; set; }
	}

}
