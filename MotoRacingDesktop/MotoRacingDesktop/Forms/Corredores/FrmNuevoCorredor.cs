using MotoRacingDesktop.Data;
using MotoRacingDesktop.Forms.Actividades;
using MotoRacingDesktop.Forms.Vehiculos;
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

namespace MotoRacingDesktop.Forms
{
    public partial class FrmNuevoCorredor : Form
    {
        MotoRacingDesktopContext context = new MotoRacingDesktopContext();

        public FrmNuevoCorredor()
        {
            InitializeComponent();
            CargarComboVehiculo();
            CargarComboActividad();
        }

        private void CargarComboActividad()
        {
            comboActividad.DataSource = context.Actividades.ToList();
            comboActividad.DisplayMember = "Nombre";
            comboActividad.ValueMember = "Id";
            comboActividad.SelectedValue = 0;
        }

        private void CargarComboVehiculo()
        {
            comboVehiculo.DataSource = context.Vehiculos.ToList();
            comboVehiculo.DisplayMember = "Nombre";
            comboVehiculo.ValueMember = "Id";
            comboVehiculo.SelectedValue = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var corredor = new Corredor()
            {
                ApellidoNombre = txtApellidoNombre.Text,
                Direccion = txtDireccion.Text,
                Telefono = txtTelefono.Text,
                VehiculoId = (int)comboVehiculo.SelectedValue,
                ActividadId = (int)comboActividad.SelectedValue
            };
            context.Corredores.Add(corredor);
            context.SaveChanges();
            this.Close();
        }

        private void btnNuevoVehiculo_Click(object sender, EventArgs e)
        {
            FrmNuevoVehiculo frmNuevoVehiculo = new FrmNuevoVehiculo();
            frmNuevoVehiculo.ShowDialog();
            CargarComboVehiculo();
        }

        private void btnNuevoActividad_Click(object sender, EventArgs e)
        {
            FrmNuevoActividad frmNuevoActividad = new FrmNuevoActividad();
            frmNuevoActividad.ShowDialog();
            CargarComboVehiculo();
        }
    }
}
