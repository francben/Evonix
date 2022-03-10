using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EvonixGym.Modelos
{
    public partial class Perimetro
    {
        public Perimetro()
        {
            PerimetroDelClientes = new HashSet<PerimetroDelCliente>();
            PerimetrosCuestionario = new HashSet<PerimetrosCuestionario>();
        }
        [Key]
        public int IdPerimetro { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string UnidadDeMedida { get; set; }

        public virtual ICollection<PerimetroDelCliente> PerimetroDelClientes { get; set; }
        public virtual ICollection<PerimetrosCuestionario> PerimetrosCuestionario { get; set; }

    }
}
