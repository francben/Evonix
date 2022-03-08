using Microsoft.AspNetCore.Identity;
namespace EvonixGym.Data.Modelos
{
    public class UsuarioRol: IdentityUserRole<string>
    {
        public Usuario Usuario { get; set; }
        public Rol Rol { get; set; }
    }
}
