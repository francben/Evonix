using EvonixGym.Data.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EvonixGym.Modelos
{
    public partial class PerimetroDelCliente
    {
        public PerimetroDelCliente()
        {
           // RevisionDetalles = new HashSet<RevisionDetalle>();
        }
        [Key]
        public int IdPerimetroCliente { get; set; }
        public int? IdCliente { get; set; }
        public int? IdPerimetro { get; set; }
        public double? MedidaDeseada { get; set; }
        public int? MedidaActual { get; set; }

      
        public virtual Perimetro IdPerimetroNavigation { get; set; }
        public virtual Cliente Cliente { get; set; }
        //   public virtual ICollection<RevisionDetalle> RevisionDetalles { get; set; }
    }
}
