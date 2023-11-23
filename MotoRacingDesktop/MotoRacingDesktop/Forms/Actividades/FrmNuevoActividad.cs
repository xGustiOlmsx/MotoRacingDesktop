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
    public partial class FrmNuevoActividad : Form
    {
        MotoRacingDesktopContext context = new MotoRacingDesktopContext();
        public FrmNuevoActividad()
        {
            InitializeComponent();
            CargarComboPista();
        }

        private void CargarComboPista()
        {
            comboPista.DataSource = context.Pistas.ToList();
            comboPista.DisplayMember = "Nombre";
            comboPista.ValueMember = "Id";
            comboPista.SelectedValue = 0;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MotoRacingDesktopContext context = new MotoRacingDesktopContext();
            var actividad = new Actividad()
            {
                Nombre = txtNombre.Text,
                Costo = numCosto.Value,
                Horarios = txtHorarios.Text,
                PistaId = (int)comboPista.SelectedValue
            };
            context.Actividades.Add(actividad);
            context.SaveChanges();
            this.Close();
        }

        private void btnNuevoActividad_Click(object sender, EventArgs e)
        {
            FrmNuevoPista frmNuevoPista = new FrmNuevoPista();
            frmNuevoPista.ShowDialog();
            CargarComboPista();
        }
    }
}
