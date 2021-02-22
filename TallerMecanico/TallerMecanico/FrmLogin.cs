using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallerMecanico
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            //Aqui agregar validación de usuario y redireccionar a formularios segun rol
            if (true)
            {
                FrmCategorias frmCategorias = new FrmCategorias();
                this.Close();
                frmCategorias.Show();
            }

            
        }
    }
}
