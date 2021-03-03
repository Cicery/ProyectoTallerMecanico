using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TallerMecanico.Entidades;
using TallerMecanico.Negocio;
using WSVenta.Herramientas;

namespace TallerMecanico
{
    public partial class FrmLogin : Form
    {

        BLTUsuario BLTUsuario = new BLTUsuario();


        public FrmLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Location = new Point(0, 0); //sobra si tienes la posición en el diseño
            this.Size = new Size(this.Width, Screen.PrimaryScreen.WorkingArea.Size.Height);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = txtUsuario.Text;
                string Contrasena = txtContraseña.Text;

                if (!string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(Contrasena))
                {
                    var modelUser = BLTUsuario.SeleccionarUsuarioLogin(usuario, Encrypt.GetSHA256(Contrasena));
                    if (modelUser != null)
                    {
                        switch (modelUser.Id_Rol)
                        {
                            case EId_Rol.Administrador:
                                FrmInicioAdministrador frmInicioAdministrador = new FrmInicioAdministrador();
                                this.Hide();
                                frmInicioAdministrador.Show();
                                break;
                            case EId_Rol.Asistente:
                                FrmInicioAsistente frmInicioAsistente = new FrmInicioAsistente();
                                this.Close();
                                frmInicioAsistente.Show();
                                break;

                            case EId_Rol.Mecanico:
                                FrmInicioMecanico frmInicioMecanico = new FrmInicioMecanico();
                                this.Close();
                                frmInicioMecanico.Show();
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrecta");
                    }
                }
                else
                {
                    MessageBox.Show("Ingresa el usuario y la contraseña");
                    // le decimos que es ingrese el usuario y contraseña para ingresar
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro en el proceso: "+ex.Message);
            }
       


        }
    }
}
