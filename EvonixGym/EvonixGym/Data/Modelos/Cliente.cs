using EvonixGym.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EvonixGym.Data.Modelos
{
    public partial class Cliente
    {
        public Cliente()
        {
            //Estadisticas = new HashSet<Estadistica>();
            //HistorialEntrenamientos = new HashSet<HistorialEntrenamiento>();
            PerimetroDelClientes = new HashSet<PerimetroDelCliente>();
            UsuarioClientes = new HashSet<UsuarioClientes>();
            ComposicionCorporalClient = new HashSet<ComposicionCorporalClient>();
        }
        [Key]
        public int IdCliente { get; set; }
        public string? Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public string Telefono { get; set; }
        public DateTime? Fechanacimiento { get; set; }
        public int? IdUsuario { get; set; }
        public string Cp { get; set; }
        public string Municipio { get; set; }
        public string Provincia { get; set; }
        public string Imageperfil { get; set; }
        public string Sexo { get; set; }
        public DateTime? FechaAlta { get; set; }
        public int? IdEntrenamiento { get; set; }

        //public virtual Entrenamiento IdEntrenamientoNavigation { get; set; }
        public virtual ICollection<UsuarioClientes> UsuarioClientes { get; set; }
        //public virtual ICollection<Estadistica> Estadisticas { get; set; }
        //public virtual ICollection<HistorialEntrenamiento> HistorialEntrenamientos { get; set; }
        public virtual ICollection<PerimetroDelCliente> PerimetroDelClientes { get; set; }
        public virtual ICollection<ComposicionCorporalClient> ComposicionCorporalClient { get; set; }
    }
}
