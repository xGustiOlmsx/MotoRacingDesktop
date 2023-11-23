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

namespace MotoRacingDesktop.Forms.Pistas
{
    public partial class FrmEditarPista : Form
    {
        MotoRacingDesktopContext context = new MotoRacingDesktopContext();
        int idPistaEditada;
        Pista? pista;
        public FrmEditarPista(int idPistaAModificar)
        {
            InitializeComponent();
            this.idPistaEditada = idPistaAModificar;
            CargarDatosEnPantalla();
        }

        private void CargarDatosEnPantalla()
        {
            pista = context.Pistas.Find(idPistaEditada);
            if (pista != null)
            {
                txtNombre.Text = pista.Nombre;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            pista.Nombre = txtNombre.Text;
            context.Entry(pista).State = EntityState.Modified;
            context.SaveChanges();
            this.Close();
        }
    }
}
