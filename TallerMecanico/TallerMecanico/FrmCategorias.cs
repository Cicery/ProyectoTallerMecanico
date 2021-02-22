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

namespace TallerMecanico
{
    public partial class FrmCategorias : Form
    {
        List<Categoria> lista = null;
        BLCategoria blCategoria = new BLCategoria();
        Categoria categoria;
        bool _nuevo = false;

        public FrmCategorias()
        {
            InitializeComponent();
            ActivarControlDatos(gbDatos, false);
            CargarDatos();

        }

        private void ActivarControlDatos(Control Contenedor, bool Estado)
        {
            try
            {
                foreach (var item in Contenedor.Controls)
                {
                    if (item.GetType() == typeof(TextBox))
                    {
                        ((TextBox)item).Enabled = Estado;
                    }
                }
            }
            catch (Exception)
            {

            }
        }


        private void LimpiarControl(Control Contenedor)
        {
            foreach (var item in Contenedor.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    ((TextBox)item).Clear();
                }
            }
        }

        private void ActivarButton(bool Estado)
        {
            btnNuevo.Enabled = Estado;
            btnGrabar.Enabled = !Estado;
            btnEliminar.Enabled = Estado;
            btnSalir.Enabled = Estado;
        }



        private void CargarDatos()
        {
            if (lista == null)
            {
                lista = blCategoria.Listar();
            }
            if (lista.Count > 0)
            {
                dgvDatos.Rows.Clear();
                for (int i = 0; i < lista.Count; i++)
                {
                    dgvDatos.Rows.Add(lista[i].Id, lista[i].Codigo,
                        lista[i].Nombre, lista[i].Observacion);
                }
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _nuevo = true;
            ActivarControlDatos(gbDatos, true);
            btnEditar.Text = "Cancelar";
            ActivarButton(false);
            LimpiarControl(gbDatos);
            txtCodigo.Focus();

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            int resultado = -1;
            if (_nuevo)
            {
                categoria = new Categoria(0, txtCodigo.Text,
                    txtNombre.Text, txtObservacion.Text);
                resultado = blCategoria.Insertar(categoria);
            }
            else
            {
                categoria.Codigo = txtCodigo.Text;
                categoria.Nombre = txtNombre.Text;
                categoria.Observacion = txtObservacion.Text;
                resultado = blCategoria.Actualizar(categoria);
            }
            if (resultado > 0)
            {
                MessageBox.Show("Datos grabados correctamente", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActivarControlDatos(gbDatos, false);
                ActivarButton(true);
                dgvDatos.Enabled = true;
                LimpiarControl(gbDatos);
                btnEditar.Text = "Editar";
                lista = blCategoria.Listar();
                CargarDatos();
            }
            else
            {
                MessageBox.Show("Error al grabar", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            _nuevo = false;
            if (btnEditar.Text == "Cancelar")
            {
                LimpiarControl(gbDatos);
                ActivarControlDatos(gbDatos, false);
                ActivarButton(true);
                dgvDatos.Enabled = true;
                btnEditar.Text = "Editar";
            }
            else
            {
                if (dgvDatos.RowCount > 0)
                {
                   categoria = blCategoria.TraerPorId((int)dgvDatos[0, dgvDatos.
                        CurrentRow.Index].Value);
                    txtCodigo.Text = categoria.Codigo;
                    txtNombre.Text = categoria.Nombre;
                    txtObservacion.Text = categoria.Observacion;
                    ActivarControlDatos(gbDatos, true);
                    ActivarButton(false);
                    dgvDatos.Enabled = false;
                    btnEditar.Text = "Cancelar";
                }
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.RowCount > 0)
            {
                categoria = blCategoria.TraerPorId((int)dgvDatos[0, dgvDatos.
                    CurrentRow.Index].Value);
                DialogResult rpta =
                    MessageBox.Show("Desea eliminar el registro", "Eliminar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rpta == System.Windows.Forms.DialogResult.Yes)
                {
                    int n = blCategoria.Eliminar(categoria.Id);
                    if (n > 0)
                    {
                        MessageBox.Show("Registro eliminado", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lista = blCategoria.Listar();
                        CargarDatos();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
