using Microsoft.EntityFrameworkCore;
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
    public partial class FrmEditarVehiculo : Form
    {
        MotoRacingDesktopContext context = new MotoRacingDesktopContext();
        int idVehiculoEditado;
        Vehiculo? vehiculo;
        public FrmEditarVehiculo(int idVehiculoAModificar)
        {
            InitializeComponent();
            this.idVehiculoEditado = idVehiculoAModificar;
            CargarDatosEnPantalla();
        }

        private void CargarDatosEnPantalla()
        {
            vehiculo = context.Vehiculos.Find(idVehiculoEditado);
            if (vehiculo != null)
            {
                txtNombre.Text = vehiculo.Nombre;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            vehiculo.Nombre = txtNombre.Text;
            context.Entry(vehiculo).State = EntityState.Modified;
            context.SaveChanges();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
