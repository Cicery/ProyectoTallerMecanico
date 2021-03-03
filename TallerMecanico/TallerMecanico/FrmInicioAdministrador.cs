using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TallerMecanico.Administrador;

namespace TallerMecanico
{
    public partial class FrmInicioAdministrador : Form
    {
        public FrmInicioAdministrador()
        {
            InitializeComponent();
        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            {
                Application.Exit();
            }
        }


        private void gestionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = GetFormByName("FrmGestionarUsuarios");
            if (frm == null)
            {
                // Creamos una nueva instancia del formulario
                frm = new FrmGestionarUsuarios();
                // Mostramos el formulario
                frm.MdiParent = this;

                frm.Show();
            }
            else
            {
                // Seleccionamos el formulario abierto
                frm.Select();
            }
        }

        public Form GetFormByName(string Nombre_Formulario)
        {
            if ((Nombre_Formulario == string.Empty))
                return null/* TODO Change to default(_) if this is not a reference type */;
            foreach (Form frm in Application.OpenForms)
            {
                if ((frm.Name.ToUpperInvariant() == Nombre_Formulario.ToUpperInvariant()))
                    return frm;
            }
            return null/* TODO Change to default(_) if this is not a reference type */;
        }

        private void btn_Gestionar_Usuario_Click(object sender, EventArgs e)
        {
            Form frm = GetFormByName("FrmGestionarUsuarios");
            if (frm == null)
            {
                // Creamos una nueva instancia del formulario
                frm = new FrmGestionarUsuarios();
                // Mostramos el formulario
                frm.MdiParent = this;

                frm.Show();
            }
            else
            {
                // Seleccionamos el formulario abierto
                frm.Select();
            }
        }
    }
}

