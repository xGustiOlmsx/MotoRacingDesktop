using Microsoft.EntityFrameworkCore;
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
    public partial class FrmEditarCorredor : Form
    {
        MotoRacingDesktopContext context = new MotoRacingDesktopContext();
        int idCorredorEditado;
        Corredor? corredor;
        public FrmEditarCorredor(int idCorredorAEditar)
        {
            InitializeComponent();
            this.idCorredorEditado = idCorredorAEditar;
            CargarComboVehiculo();
            CargarComboActividad();
            CargarDatosEnPantalla();
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

        private void CargarDatosEnPantalla()
        {
            corredor = context.Corredores.Find(idCorredorEditado);
            if (corredor != null)
            {
                txtApellidoNombre.Text = corredor.ApellidoNombre;
                txtDireccion.Text = corredor.Direccion;
                txtTelefono.Text = corredor.Telefono;
                comboVehiculo.SelectedValue = corredor.VehiculoId ?? 0;
                comboActividad.SelectedValue = corredor.ActividadId ?? 0;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MotoRacingDesktopContext context = new MotoRacingDesktopContext();
            corredor.ApellidoNombre = txtApellidoNombre.Text;
            corredor.Direccion = txtDireccion.Text;
            corredor.Telefono = txtTelefono.Text;
            corredor.VehiculoId = (int)comboVehiculo.SelectedValue;
            corredor.ActividadId = (int)comboActividad.SelectedValue;
            context.Entry(corredor).State = EntityState.Modified;
            context.SaveChanges();
            this.Close();
        }

        private void comboVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmEditarCorredor_Load(object sender, EventArgs e)
        {
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
