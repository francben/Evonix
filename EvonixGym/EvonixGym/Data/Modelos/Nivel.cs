using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EvonixGym.Data.Modelos
{
    public partial class Nivel
    {
        public Nivel()
        {
            Ejercicios = new HashSet<Ejercicio>();
        }
        [Key]
        public int NivelId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Ejercicio> Ejercicios { get; set; }
    }
}
