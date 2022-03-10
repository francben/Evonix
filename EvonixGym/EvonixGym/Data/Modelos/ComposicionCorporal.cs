using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EvonixGym.Modelos
{
    public partial class ComposicionCorporal
    {
        public ComposicionCorporal()
        {
            ComposicionCorporalClients = new HashSet<ComposicionCorporalClient>();
        }
        [Key]
        public int IdComposicion { get; set; }
        public int? CueIdCuestionario { get; set; }
        public string Nombre { get; set; }
        public string IdCuestionario { get; set; }

        public virtual Cuestionario CueIdCuestionarioNavigation { get; set; }
        public virtual ICollection<ComposicionCorporalClient> ComposicionCorporalClients { get; set; }
    }
}
