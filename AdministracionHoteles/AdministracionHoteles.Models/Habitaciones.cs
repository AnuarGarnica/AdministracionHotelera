using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionHoteles.Models
{
    public class Habitaciones
    {
        [Key]
		public int id { get; set; }
		public string Titulo { get; set; }
		public string PalabrasClave { get; set; }
		public string Descripcion { get; set; }
		public decimal Costo { get; set; }
		public int Adultos { get; set; }
		public int Infantes { get; set; }
		public int MaximoAdultos { get; set; }
		public int MaximoInfantes { get; set; }
		public int CostoAdicional_Adulto { get; set; }
		public int CostoAdicional_Infante { get; set; } 
		public int TotalHabitaciones { get; set; }
		public bool Activo { get; set; }
		public decimal Calificacion { get; set; }

		[ForeignKey("Hoteles")]
		public int Hotelid { get; set; }
		public virtual Hoteles Hoteles{ get; set; }

	}
}
