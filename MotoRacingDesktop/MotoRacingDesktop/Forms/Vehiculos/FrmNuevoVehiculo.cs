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
    public partial class FrmNuevoVehiculo : Form
    {
        public FrmNuevoVehiculo()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MotoRacingDesktopContext context = new MotoRacingDesktopContext();
            var vehiculo = new Vehiculo()
            {
                Nombre = txtNombre.Text,
            };
            context.Vehiculos.Add(vehiculo);
            context.SaveChanges();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
