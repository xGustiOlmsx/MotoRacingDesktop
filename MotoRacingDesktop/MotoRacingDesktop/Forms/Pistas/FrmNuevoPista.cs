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

namespace MotoRacingDesktop.Forms.Pistas
{
    public partial class FrmNuevoPista : Form
    {
        public FrmNuevoPista()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MotoRacingDesktopContext context = new MotoRacingDesktopContext();
            var pista = new Pista()
            {
                Nombre = txtNombre.Text,
            };
            context.Pistas.Add(pista);
            context.SaveChanges();
            this.Close();
        }
    }
}
