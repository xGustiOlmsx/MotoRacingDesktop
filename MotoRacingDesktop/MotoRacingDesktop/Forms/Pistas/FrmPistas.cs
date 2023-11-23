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

namespace MotoRacingDesktop.Forms.Pistas
{
    public partial class FrmPistas : Form
    {
        public FrmPistas()
        {
            InitializeComponent();
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            MotoRacingDesktopContext context = new MotoRacingDesktopContext();
            if (txtBusqueda.Text.Length > 0)
            {
                dataGridPistas.DataSource = context.Pistas.Where(s => s.Nombre.Contains(txtBusqueda.Text)).ToList();
            }
            else
            {
                dataGridPistas.DataSource = context.Pistas.ToList();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoPista frmNuevoPista = new FrmNuevoPista();
            frmNuevoPista.ShowDialog();
            CargarGrilla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int idAEditar = (int)dataGridPistas.CurrentRow.Cells[0].Value;
            FrmEditarPista frmEditarPista = new FrmEditarPista(idAEditar);
            frmEditarPista.ShowDialog();
            CargarGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idAEliminar = (int)dataGridPistas.CurrentRow.Cells[0].Value;
            string nombrePistaAEliminar = (string)dataGridPistas.CurrentRow.Cells[1].Value;
            var resultado = MessageBox.Show($"¿Está seguro que desea Eliminar la pista {nombrePistaAEliminar}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    var context = new MotoRacingDesktopContext();
                    var pista = context.Vehiculos.Find(idAEliminar);
                    context.Vehiculos.Remove(pista);
                    context.SaveChanges();
                    CargarGrilla();
                }
                catch (Exception error)
                {

                    MessageBox.Show($"Error, ocurrio un problema al intentar borrar al Vehiculo {nombrePistaAEliminar}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }
    }
}
