using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionHoteles.Models
{
    public class ServiciosExtras
    {
		[Key]
		public int id { get; set; }
		public string Servicio { get; set; }
		public decimal Costo { get; set; }

		[ForeignKey("Hoteles")]
		public int Hotelid { get; set; }
		
		[ForeignKey("Habitaciones")]
		public int Habitacionid { get; set; }
		
		public string Descripcion { get; set; }

		[ForeignKey("Usuarios")]
		public int Usuarioid { get; set; }

		public bool Activo { get; set; }

		public virtual Hoteles Hoteles { get; set; }
		public virtual Habitaciones Habitaciones { get; set; }
		public virtual Usuarios Usuarios { get; set; }


	}

}
