using Microsoft.EntityFrameworkCore;
using MotoRacingDesktop.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotoRacingDesktop.Forms
{
    public partial class FrmCorredores : Form
    {
        public FrmCorredores()
        {
            InitializeComponent();
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            MotoRacingDesktopContext context = new MotoRacingDesktopContext();
            if (txtBusqueda.Text.Length > 0)
            {
                dataGridCorredores.DataSource = context.Corredores.Where(s => s.ApellidoNombre.Contains(txtBusqueda.Text)).Include(s => s.Vehiculo).Include(s => s.Actividad).ToList();
            }
            else
            {
                dataGridCorredores.DataSource = context.Corredores.Include(s => s.Vehiculo).Include(s => s.Actividad).ToList();
            }
            dataGridCorredores.Columns[4].Visible = false;
            dataGridCorredores.Columns[6].Visible = false;
            dataGridCorredores.Columns[7].Visible = false;
            dataGridCorredores.Columns[8].Visible = false;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            FrmNuevoCorredor frmNuevoCorredor = new FrmNuevoCorredor();
            frmNuevoCorredor.ShowDialog();
            CargarGrilla();
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            int idAEditar = (int)dataGridCorredores.CurrentRow.Cells[0].Value;
            FrmEditarCorredor frmEditarCorredor = new FrmEditarCorredor(idAEditar);
            frmEditarCorredor.ShowDialog();
            CargarGrilla();
        }

        private void btnEliminar_Click_2(object sender, EventArgs e)
        {
            int idAEliminar = (int)dataGridCorredores.CurrentRow.Cells[0].Value;
            string nombreCorredorAEliminar = (string)dataGridCorredores.CurrentRow.Cells[1].Value;
            var resultado = MessageBox.Show($"¿Está seguro que desea Eliminar al corredor {nombreCorredorAEliminar}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    var context = new MotoRacingDesktopContext();
                    var corredor = context.Corredores.Find(idAEliminar);
                    context.Corredores.Remove(corredor);
                    context.SaveChanges();
                    CargarGrilla();
                }
                catch (Exception error)
                {

                    MessageBox.Show($"Error, ocurrio un problema al intentar borrar al socio {nombreCorredorAEliminar}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBusqueda_TextChanged_1(object sender, EventArgs e)
        {
            CargarGrilla();
        }
    }
}

