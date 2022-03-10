using EvonixGym.Data.Modelos;
using System.ComponentModel.DataAnnotations;

namespace EvonixGym.Modelos
{
    public class CuestionarioClientes
    {
        [Key]
        public int IdCuestionarioClientes { get; set; }
        public int? IdCuestionario { get; set; }
        public int? IdCliente { get; set; }

        public virtual Cuestionario IdCuestionarioNavigation { get; set; }
        public virtual Cliente IdClienteNav { get; set; }
        //  public virtual Equipamiento IdClienteNavigation { get; set; }



    }
}
