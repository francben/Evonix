using Microsoft.AspNetCore.Identity;
namespace EvonixGym.Data.Modelos
{
    public class Rol: IdentityRole
    {
        public ICollection<UsuarioRol> UsuarioRoles { get; set; }
    }
}
