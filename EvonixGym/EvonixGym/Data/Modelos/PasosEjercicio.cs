using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EvonixGym.Data.Modelos
{
    public partial class PasosEjercicio
    {
        [Key]
        public int IdPasos { get; set; }
        public int? IdEjercicio { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public virtual Ejercicio IdEjercicioNavigation { get; set; }
    }
}
