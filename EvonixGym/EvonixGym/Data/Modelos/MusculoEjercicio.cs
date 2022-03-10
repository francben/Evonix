using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EvonixGym.Data.Modelos
{
    public partial class MusculoEjercicio
    {
        [Key]
        public int IdMusculoEjercicios { get; set; }
        public int IdMusculo { get; set; }
        public int IdEjercicio { get; set; }

        public Ejercicio IdEjercicioNavigation { get; set; }
        public Musculo IdMusculoNavigation { get; set; }
    }
}
