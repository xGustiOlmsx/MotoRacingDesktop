using Microsoft.EntityFrameworkCore;
using MotoRacingDesktop.Data;
using MotoRacingDesktop.Forms.Pistas;
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

namespace MotoRacingDesktop.Forms.Actividades
{
    public partial class FrmEditarActividad : Form
    {
        MotoRacingDesktopContext context = new MotoRacingDesktopContext();
        int idActividadEditada;
        Actividad? actividad;
        public FrmEditarActividad(int idActividadAModificar)
        {
            InitializeComponent();
            this.idActividadEditada = idActividadAModificar;
            CargarDatosEnPantalla();
            CargarComboPista();
        }

        private void CargarComboPista()
        {
            comboPista.DataSource = context.Pistas.ToList();
            comboPista.DisplayMember = "Nombre";
            comboPista.ValueMember = "Id";
            comboPista.SelectedValue = 0;
        }

        private void CargarDatosEnPantalla()
        {
            actividad = context.Actividades.Find(idActividadEditada);
            if (actividad != null)
            {
                txtNombre.Text = actividad.Nombre;
                numCosto.Value = actividad.Costo;
                txtHorarios.Text = actividad.Horarios;
                comboPista.SelectedValue = actividad.PistaId;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            actividad.Nombre = txtNombre.Text;
            actividad.Costo = numCosto.Value;
            actividad.Horarios = txtHorarios.Text;
            actividad.PistaId = (int)comboPista.SelectedValue;
            context.Entry(actividad).State = EntityState.Modified;
            context.SaveChanges();
            this.Close();
        }

        private void btnNuevoPista_Click(object sender, EventArgs e)
        {
            FrmNuevoPista frmNuevoPista = new FrmNuevoPista();
            frmNuevoPista.ShowDialog();
            CargarComboPista();
        }
    }
}
