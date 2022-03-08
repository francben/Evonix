using Microsoft.AspNetCore.Identity;
namespace EvonixGym.Data.Modelos
{
    public class Usuario: IdentityUser
    {
        public ICollection<UsuarioRol> UsuarioRoles { get; set; }
        public ICollection<UsuarioClientes> UsuarioClientes { get; set; }
        public ICollection<UsuarioEntrenadores> UsuarioEntrenadores { get; set; }
    }
}
