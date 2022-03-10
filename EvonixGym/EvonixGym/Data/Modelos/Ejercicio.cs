using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EvonixGym.Data.Modelos
{
    public partial class Ejercicio
    {
        public Ejercicio()
        {
            EquipamientoEjercicios = new HashSet<EquipamientoEjercicio>();
            MusculoEjercicios = new HashSet<MusculoEjercicio>();
            PasosEjercicios = new HashSet<PasosEjercicio>();
            //RutinaEjercicios = new HashSet<RutinaEjercicio>();
        }
        [Key]
        public int IdEjercicio { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string LinkVideo { get; set; }
        public int NivelId { get; set; }
        public string Geard { get; set; }
        public string Aparato { get; set; }
        public string TipoEjecucion { get; set; }

        public virtual Nivel Nivel { get; set; }
        public virtual ICollection<EquipamientoEjercicio> EquipamientoEjercicios { get; set; }
        public virtual ICollection<MusculoEjercicio> MusculoEjercicios { get; set; }
        public virtual ICollection<PasosEjercicio> PasosEjercicios { get; set; }
        //public virtual ICollection<RutinaEjercicio> RutinaEjercicios { get; set; }
    }
}
