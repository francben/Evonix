using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EvonixGym.Modelos
{
    public partial class PerimetrosCuestionario
    {
        [Key]
        public int IdPerimetrosCuest { get; set; }
        public int? IdPerimetro { get; set; }
        public int? IdCuestionario { get; set; }

        public virtual Cuestionario IdCuestionarioNavigation { get; set; }

        public virtual Perimetro Perimetro { get; set; }

    }
}
