using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerMecanico.Datos;
using TallerMecanico.Entidades;

namespace TallerMecanico.Negocio
{
    public class BLTUsuario
    {

        public TUsuario SeleccionarUsuario(string Usuario, string Contraseña)
        {
            DAOTUsuario daTUsuario = new DAOTUsuario();
            return daTUsuario.SeleccionarUsuario(Usuario, Contraseña);
        }
    }
}
