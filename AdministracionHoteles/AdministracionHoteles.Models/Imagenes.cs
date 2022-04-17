using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionHoteles.Models
{
    public class Imagenes
    {
        [Key]
		public int id { get; set; }
		public string Imagen { get; set; }
		public string Nombre { get; set; }
		[ForeignKey("Hoteles")]
		public int Hotelid { get; set; }
		[ForeignKey("Habitaciones")]
		public int Habitacionid { get; set; }
		[ForeignKey("ServiciosExtras")]
		public int Servicioid { get; set; }
		[ForeignKey("Blog")]
		public int Blogid { get; set; }
		public int Activo { get; set; }

		public virtual Hoteles Hoteles { get; set; }
		public virtual Habitaciones Habitaciones { get; set; }
		public virtual ServiciosExtras ServiciosExtras { get; set; }
		public virtual Blog Blog { get; set; }


	}
}
