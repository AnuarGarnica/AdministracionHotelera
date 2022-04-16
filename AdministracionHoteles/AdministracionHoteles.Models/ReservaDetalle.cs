using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionHoteles.Models
{
    internal class ReservaDetalle
    {
        [Key]
		public int id { get; set; }
		public int TotalDias { get; set; }
		public int Adultos { get; set; }
		public int Infantes { get; set; }
		public decimal CostoHabitacion { get; set; }

		[ForeignKey("Reservas")]
		public int Reservaid { get; set; }
		[ForeignKey("Habitaciones")]
		public int Habitacionid { get; set; }

		public virtual Reservas Reservas { get; set; }
		public virtual Habitaciones Habitaciones { get; set; }
	}
}
