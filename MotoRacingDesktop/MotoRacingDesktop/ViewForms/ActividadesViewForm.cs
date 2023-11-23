using Microsoft.Reporting.WinForms;
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

namespace MotoRacingDesktop.ViewForms
{
    public partial class ActividadesViewForm : Form
    {
        ReportViewer reporte = new ReportViewer();
        MotoRacingDesktopContext db = new MotoRacingDesktopContext();
        public ActividadesViewForm()
        {
            InitializeComponent();
            // hace q el reporte ocupe todo el form
            reporte.Dock = DockStyle.Fill;

            // establece la vista de impresion
            reporte.SetDisplayMode(DisplayMode.PrintLayout);

            // establece el zoom al 100%
            reporte.ZoomMode = ZoomMode.Percent;
            reporte.ZoomPercent = 100;

            Controls.Add(reporte);
        }

        private void ActividadesViewForm_Load(object sender, EventArgs e)
        {

            var actividades = db.Actividades.ToList();
            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSAvtividades", actividades));

            reporte.LocalReport.ReportEmbeddedResource = "MotoRacingDesktop.Reportes.ActividadesReport.rdlc";

            reporte.RefreshReport();
        }
    }
}
