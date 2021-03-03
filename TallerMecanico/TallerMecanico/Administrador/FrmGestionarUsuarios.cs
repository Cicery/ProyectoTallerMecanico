using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallerMecanico.Administrador
{
    public partial class FrmGestionarUsuarios : Form
    {


        public FrmGestionarUsuarios()
        {
            InitializeComponent();
            cbTipoDocumento.Items.Add("CC");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var item = cbTipoDocumento.Text;
        }
    }
}
