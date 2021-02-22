using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerMecanico.Entidades
{
    public class TUsuario
    {
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public int Id_Rol { get; set; }
        public int Id_Persona { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public bool Activo { get; set; }

    }
}


