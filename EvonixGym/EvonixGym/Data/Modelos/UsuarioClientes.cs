
using System.ComponentModel.DataAnnotations;

namespace EvonixGym.Data.Modelos
{
    public class UsuarioClientes
    {
        [Key]
        public int UsuarioClienteID { get; set; }
        public virtual string UserId { get; set; }
        public virtual int IdCliente { get; set; }
        public Usuario Usuario { get; set; }
        public Cliente Cliente { get; set; }
    }
}
