using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EvonixGym.Data.Modelos
{
    public partial class Musculo
    {
        public Musculo()
        {
            MusculoEjercicios = new HashSet<MusculoEjercicio>();
        }
        [Key]
        public int IdMusculo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public virtual ICollection<MusculoEjercicio> MusculoEjercicios { get; set; }
    }
}