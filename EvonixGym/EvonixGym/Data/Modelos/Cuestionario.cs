using EvonixGym.Data.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace EvonixGym.Modelos
{
    public partial class Cuestionario
    {
        public Cuestionario()
        {
            ComposicionCorporals = new HashSet<ComposicionCorporal>();
            PerimetrosCuestionarios = new HashSet<PerimetrosCuestionario>();
            Pregunta = new HashSet<Pregunta>();
            CuestionarioClientes = new HashSet<CuestionarioClientes>();

        }
        [Key]
        [JsonPropertyName("IdCuestionario")]
        public int IdCuestionario { get; set; }
        public int? IdEntrenador { get; set; }
        public string Tipo { get; set; }

        [JsonPropertyName("Nombre")]
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public virtual Entrenador IdEntrenadorNavigation { get; set; }
        public virtual ICollection<ComposicionCorporal> ComposicionCorporals { get; set; }
        public virtual ICollection<PerimetrosCuestionario> PerimetrosCuestionarios { get; set; }
        public virtual ICollection<Pregunta> Pregunta { get; set; }

        public virtual ICollection<CuestionarioClientes> CuestionarioClientes { get; set; }
    }
}
