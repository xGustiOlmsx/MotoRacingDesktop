using MotoRacingDesktop.Data;
using MotoRacingDesktop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotoRacingDesktop.Forms.Vehiculos
{
    public partial class FrmVehiculos : Form
    {
        public FrmVehiculos()
        {
            InitializeComponent();
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            MotoRacingDesktopContext context = new MotoRacingDesktopContext();
            if (txtBusqueda.Text.Length > 0)
            {
                dataGridVehiculos.DataSource = context.Vehiculos.Where(s => s.Nombre.Contains(txtBusqueda.Text)).ToList();
            }
            else
            {
                dataGridVehiculos.DataSource = context.Vehiculos.ToList();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoVehiculo frmNuevoVehiculo = new FrmNuevoVehiculo();
            frmNuevoVehiculo.ShowDialog();
            CargarGrilla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int idAEditar = (int)dataGridVehiculos.CurrentRow.Cells[0].Value;
            FrmEditarVehiculo frmEditarVehiculo = new FrmEditarVehiculo(idAEditar);
            frmEditarVehiculo.ShowDialog();
            CargarGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idAEliminar = (int)dataGridVehiculos.CurrentRow.Cells[0].Value;
            string nombreVehiculoAEliminar = (string)dataGridVehiculos.CurrentRow.Cells[1].Value;
            var resultado = MessageBox.Show($"¿Está seguro que desea Eliminar al Vehiculo {nombreVehiculoAEliminar}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    var context = new MotoRacingDesktopContext();
                    var vehiculo = context.Vehiculos.Find(idAEliminar);
                    context.Vehiculos.Remove(vehiculo);
                    context.SaveChanges();
                    CargarGrilla();
                }
                catch (Exception error)
                {

                    MessageBox.Show($"Error, ocurrio un problema al intentar borrar al Vehiculo {nombreVehiculoAEliminar}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }
    }
}
