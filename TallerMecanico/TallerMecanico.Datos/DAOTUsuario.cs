using Serilog;
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

        public TUsuario SeleccionarUsuarioLogin(string Usuario, string Contrasena) 
        {

            TUsuario usuario = null;
            try
            {
                using (SqlConnection con = new SqlConnection(DAOConexion.CadenaConexion))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_SeleccionarUsuario_X_UsuarioContrasena", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Usuario", Usuario);
                    cmd.Parameters.AddWithValue("@Contrasena", Contrasena);
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
            }
            catch (Exception ex)
            {
                Log.Information(ex, "Error por ty catch DAOTUsuario - SeleccionarUsuario");
                Log.CloseAndFlush();
                throw;
            }

        
            return usuario;
        }

        public TUsuario Merge_Usuario(TUsuario usuario)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(DAOConexion.CadenaConexion))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Merge_Usuario", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdUsuario", usuario.IdUsuario);
                    cmd.Parameters.AddWithValue("@Usuario", usuario.Usuario);
                    cmd.Parameters.AddWithValue("@Contrasena", usuario.Contrasena);
                    cmd.Parameters.AddWithValue("@Id_Rol", usuario.Id_Rol);
                    cmd.Parameters.AddWithValue("@Id_Persona", usuario.Id_Persona);
                    cmd.Parameters.AddWithValue("@Id_Usuario_Creacion", usuario.Id_Usuario_Creacion);
                    cmd.Parameters.AddWithValue("@Id_Usuario_Modificacion", usuario.Id_Usuario_Modificacion);
                    cmd.Parameters.AddWithValue("@Activo", usuario.Activo);
                    usuario.IdUsuario = (int)cmd.ExecuteScalar();
                }

            }
            catch (Exception ex)
            {
                Log.Information(ex, "Error por ty catch DAOTUsuario - Merge_Usuario");
                Log.CloseAndFlush();
                throw;
            }         
            return usuario;
        }





    }
}
