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
    public partial class CorredoresViewForm : Form
    {
        ReportViewer reporte = new ReportViewer();
        MotoRacingDesktopContext db = new MotoRacingDesktopContext();
        public CorredoresViewForm()
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

        private void CorredoresViewForm_Load(object sender, EventArgs e)
        {
            var corredores = db.Corredores.ToList();
            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSCorredores", corredores));

            reporte.LocalReport.ReportEmbeddedResource = "MotoRacingDesktop.Reportes.CorredoresReport.rdlc";

            reporte.RefreshReport();
        }
    }
}
