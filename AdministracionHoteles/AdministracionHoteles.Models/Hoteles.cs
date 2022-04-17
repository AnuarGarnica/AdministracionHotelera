using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionHoteles.Models
{
    public class Hoteles
    {
        [Key]
		public int id { get; set; }
		public string Telefono { get; set; }
		public string Website { get; set; }
		public string Email { get; set; }
		public string PalabrasClave { get; set; }
		public string Nombre { get; set; }
		public string Descripcion { get; set; }
		public string Direccion { get; set; }
		public string Ciudad { get; set; }
		public string CodigoPostal { get; set; }
		public decimal Latitud { get; set; }
		public decimal Longitud { get; set; }
		public bool Facturacion { get; set; }

		[ForeignKey("Usuarios")]
		public int Usuarioid { get; set; }

		public decimal Calificacion { get; set; }
		public bool Estatus { get; set; }
		public string Facebook { get; set; }
		public string WhatsApp { get; set; }

		public virtual Usuarios Usuarios { get; set; }

	}
}
