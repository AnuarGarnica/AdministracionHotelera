using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionHoteles.Models
{
    internal class Reservas
    {
		[Key]
		public int id { get; set; }
		public string Folio { get; set; }
		public DateTime FechaCreacion { get; set; }
		public DateTime FechaReserva_Inicia { get; set; }
		public DateTime FechaReserva_Finaliza { get; set; }
		public decimal CostoTotal { get; set; }
		public string Estatus { get; set; }
		public string Email { get; set; }
		public string Nombres { get; set; }
		public string Apellidos { get; set; }
		public string Telefono { get; set; }
		public string Pais { get; set; }
		public string Estado { get; set; }
		public string Municipio { get; set; }
		public string Direccion { get; set; }
		public string CodigoPostal { get; set; }
		public string RequerimientosEspeciales { get; set; }
		public string ReferenciaPago { get; set; }
		public string Tipo { get; set; }

		[ForeignKey("Hoteles")]
		public int Hotelid { get; set; }
		public virtual Hoteles Hoteles { get; set; }
	}
}
