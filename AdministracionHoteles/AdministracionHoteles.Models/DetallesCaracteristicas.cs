using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionHoteles.Models
{
    internal class DetallesCaracteristicas
    {
        [Key]
        public int id { get; set; }

        [ForeignKey("Hoteles")]
        public int Hotelid { get; set; }
        [ForeignKey("Habitaciones")]
        public int Habitacionid { get; set; }
        [ForeignKey("Caracteristicas")]
        public int Caracteristicasid { get; set; }

        public int Activo { get; set; }

        public virtual Hoteles Hoteles { get; set; }
        public virtual Habitaciones Habitaciones { get; set; }
        public virtual Caracteristicas Caracteristicas { get; set; }
    }
}
