using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EvonixGym.Modelos
{
    public partial class Archivo
    {
        [Key]
        public int IdArchivo { get; set; }
        public int? IdPreguntas { get; set; }
        public int? IdPregunta { get; set; }
        public string Image { get; set; }
        public string LinkVideo { get; set; }

        public string descripcion { get; set; }

      //  public virtual Pregunta IdPreguntasNavigation { get; set; }
    }
}
