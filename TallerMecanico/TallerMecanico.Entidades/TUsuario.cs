using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerMecanico.Entidades
{
    public class TUsuario
    {
        public int IdUsuario { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public EId_Rol Id_Rol { get; set; }
        public int Id_Persona { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }

        public int Id_Usuario_Creacion { get; set; }
        public int Id_Usuario_Modificacion { get; set; }
        public bool Activo { get; set; }

    }

    public enum EId_Rol
    {
        Administrador = 1,
        Asistente = 2,
        Mecanico = 3
    }
}


