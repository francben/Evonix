using System.ComponentModel.DataAnnotations;

namespace EvonixGym.Data.Modelos
{
    public class UsuarioEntrenadores
    {
        [Key]
        public int UsuarioEntrenadorID { get; set; }
        public virtual string UserId { get; set; }
        public virtual int IdEntrenador { get; set; }
        public Usuario Usuario { get; set; }
        public Entrenador Entrenador { get; set; }
    }
}
