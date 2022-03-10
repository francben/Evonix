using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EvonixGym.Modelos
{
    public partial class Pregunta
    {
        public Pregunta()
        {
            Archivos = new HashSet<Archivo>();
            Respuesta = new HashSet<Respuestum>();
        }
        [Key]
        public int IdPreguntas { get; set; }
        public string Pregunta1 { get; set; }
        public int? IdCuestionario { get; set; }

        public List<Archivo>? imagenes { get; set; }

        public virtual Cuestionario IdCuestionarioNavigation { get; set; }
        public virtual ICollection<Archivo> Archivos { get; set; }
        public virtual ICollection<Respuestum> Respuesta { get; set; }
    }
}
