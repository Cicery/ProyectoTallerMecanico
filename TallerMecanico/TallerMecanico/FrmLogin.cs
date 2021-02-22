using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TallerMecanico.Negocio;

namespace TallerMecanico
{
    public partial class FrmLogin : Form
    {

        BLTUsuario BLTUsuario = new BLTUsuario();


        public FrmLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            if (!string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(contraseña))
            {

                if (BLTUsuario.SeleccionarUsuario(usuario,contraseña) != null)
                {
                    FrmCategorias frmCategorias = new FrmCategorias();
                    this.Close();
                    frmCategorias.Show();
                }
            }
            else
            {
                // le decimos que es ingrese el usuario y contraseña para ingresar
            }
         

            
        }
    }
}
