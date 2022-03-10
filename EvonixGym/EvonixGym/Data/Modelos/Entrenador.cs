using EvonixGym.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EvonixGym.Data.Modelos
{
    public partial class Entrenador
    {
        public Entrenador()
        {
            Cuestionarios = new HashSet<Cuestionario>();
            Clientes = new HashSet<Cliente>();
            //HistorialEntrenamientos = new HashSet<HistorialEntrenamiento>();
            UsuarioEntrenadores = new HashSet<UsuarioEntrenadores>();
        }
        [Key]
        public int IdEntrenador { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public int? IdUsuario { get; set; }
        public bool? Baja { get; set; }
        public DateTime? FechaAlta { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public DateTime? FechaAltaContrato { get; set; }
        public int? FechaProxPago { get; set; }

       public virtual ICollection<UsuarioEntrenadores> UsuarioEntrenadores { get; set; }
       public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Cuestionario> Cuestionarios { get; set; }
        //public virtual ICollection<HistorialEntrenamiento> HistorialEntrenamientos { get; set; }
    }
}
