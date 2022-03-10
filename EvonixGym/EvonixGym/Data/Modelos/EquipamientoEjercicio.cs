using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EvonixGym.Data.Modelos
{
    public partial class EquipamientoEjercicio
    {
        [Key]
        public int IdEquipamientoEjercicio { get; set; }
        public int IdEquipamiento { get; set; }
        public int IdEjercicio { get; set; }

        public Ejercicio IdEjercicioNavigation { get; set; }
        public Equipamiento IdEquipamientoNavigation { get; set; }
    }
}
