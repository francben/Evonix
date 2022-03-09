using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EvonixGym.Modelos
{
    public partial class Archivoresp
    {
        [Key]
        public int IdArchivoResp { get; set; }
        public int? IdRespuesta { get; set; }
        public int? IdPregunta { get; set; }
        public string Image { get; set; }
        public string LinkVideo { get; set; }

        public string descripcion { get; set; }

        public virtual Respuestum IdRespuestaNavigation { get; set; }
    }
}
