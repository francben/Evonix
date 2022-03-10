using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EvonixGym.Data.Modelos
{
    public partial class Equipamiento
    {
        public Equipamiento()
        {
            EquipamientoEjercicios = new HashSet<EquipamientoEjercicio>();
        }
        [Key]
        public int IdEquipamiento { get; set; }
        public string Nombre { get; set; }
        public string Decripcion { get; set; }

        public virtual ICollection<EquipamientoEjercicio> EquipamientoEjercicios { get; set; }
    }
}
