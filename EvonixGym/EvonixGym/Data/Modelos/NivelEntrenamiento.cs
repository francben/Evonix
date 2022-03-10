using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EvonixGym.Data.Modelos
{
    public partial class NivelEntrenamiento
    {
        public NivelEntrenamiento()
        {
           // Entrenamientos = new HashSet<Entrenamiento>();
        }

        [Key]
        public int IdNivelEntrenamiento { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        //public virtual ICollection<Entrenamiento> Entrenamientos { get; set; }
    }
}
