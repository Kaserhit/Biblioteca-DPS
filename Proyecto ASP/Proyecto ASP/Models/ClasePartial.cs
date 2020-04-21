using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyecto_ASP.Models
{
    public class ClasePartial
    {

    }

    [MetadataType(typeof(ClasePartial))]

    public partial class CAT_LIBROS
    {
        public int cantidad { get; set; }
        public string cedula { get; set; }
        public string name { get; set; }
        public string apellido1 { get; set; }
        public string apellido2 { get; set; }
        public int telefono { get; set; }
        public DateTime fecha_solic { get; set; }
        public DateTime fecha_ent { get; set; }
        public string descripcion { get; set; }
        public int costo_reparacion { get; set; }
    }
}