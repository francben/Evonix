using EvonixGym.Data.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EvonixGym.Modelos
{
    public partial class ComposicionCorporalClient
    {
        public ComposicionCorporalClient()
        {
        //    RevisionDetalles = new HashSet<RevisionDetalle>();
        }
        [Key]
        public int IdCcCliente { get; set; }
        public int? IdComposicion { get; set; }

        public virtual ComposicionCorporal IdComposicionNavigation { get; set; }
        public Cliente Cliente { get; set; }
        // public virtual ICollection<RevisionDetalle> RevisionDetalles { get; set; }
    }
}
