using Microsoft.EntityFrameworkCore;
using MotoRacingDesktop.Data;
using MotoRacingDesktop.Forms.Vehiculos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotoRacingDesktop.Forms.Actividades
{
    public partial class FrmActividades : Form
    {
        public FrmActividades()
        {
            InitializeComponent();
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            MotoRacingDesktopContext context = new MotoRacingDesktopContext();
            if (txtBusqueda.Text.Length > 0)
            {
                dataGridActividades.DataSource = context.Actividades.Where(s => s.Nombre.Contains(txtBusqueda.Text)).Include(s => s.Pista).ToList();
            }
            else
            {
                dataGridActividades.DataSource = context.Actividades.Include(s => s.Pista).ToList();
            }
            dataGridActividades.Columns[4].Visible = false;
            dataGridActividades.Columns[5].Visible = false;
            dataGridActividades.Columns[6].Visible = false;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoActividad frmNuevoActividad = new FrmNuevoActividad();
            frmNuevoActividad.ShowDialog();
            CargarGrilla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int idAEditar = (int)dataGridActividades.CurrentRow.Cells[0].Value;
            FrmEditarActividad frmEditarActividad = new FrmEditarActividad(idAEditar);
            frmEditarActividad.ShowDialog();
            CargarGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idAEliminar = (int)dataGridActividades.CurrentRow.Cells[0].Value;
            string nombreActividadAEliminar = (string)dataGridActividades.CurrentRow.Cells[1].Value;
            var resultado = MessageBox.Show($"¿Está seguro que desea Eliminar la actividad {nombreActividadAEliminar}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    var context = new MotoRacingDesktopContext();
                    var actividad = context.Actividades.Find(idAEliminar);
                    context.Actividades.Remove(actividad);
                    context.SaveChanges();
                    CargarGrilla();
                }
                catch (Exception error)
                {

                    MessageBox.Show($"Error, ocurrio un problema al intentar borrar la actividad {nombreActividadAEliminar}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }
    }
}
