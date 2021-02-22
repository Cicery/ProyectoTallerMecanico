using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerMecanico.Entidades;

namespace TallerMecanico.Datos
{
    public class DAOTUsuario
    {

        public TUsuario SeleccionarUsuario(string Usuario, string Contraseña) 
        {

            TUsuario usuario = null;
            using (SqlConnection con = new SqlConnection(DAOConexion.CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("TraerCategoriaPorId", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Usuario", Usuario);
                cmd.Parameters.AddWithValue("@Contraseña", Contraseña);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.HasRows)
                {
                    dr.Read();
                    usuario = new TUsuario()
                    {
                        Usuario = (string)dr["Usuario"],
                        Contrasena = (string)dr["Contrasena"],
                        Id_Rol = (EId_Rol)dr["Id_Rol"],
                        Id_Persona = (int)dr["Id_Persona"],
                        FechaCreacion = (DateTime)dr["FechaCreacion"],
                        FechaModificacion = (DateTime)dr["FechaModificacion"],
                        Activo = (bool)dr["Activo"],
                    };
                }
            }
            return usuario;
        }


    }
}
