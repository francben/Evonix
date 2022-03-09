using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EvonixGym.Modelos
{
    public partial class Respuestum
    {
        public Respuestum()
        {
            Archivoresps = new HashSet<Archivoresp>();
        }
        [Key]
        public int IdRespuesta { get; set; }
        public int? IdPreguntas { get; set; }
        public string Respuesta { get; set; }
        public int? IdPregunta { get; set; }

        public virtual Pregunta IdPreguntasNavigation { get; set; }
        public virtual ICollection<Archivoresp> Archivoresps { get; set; }
    }
}
