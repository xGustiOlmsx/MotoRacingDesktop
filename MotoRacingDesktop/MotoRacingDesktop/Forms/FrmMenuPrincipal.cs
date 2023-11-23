using MotoRacingDesktop.Forms;
using MotoRacingDesktop.Forms.Actividades;
using MotoRacingDesktop.Forms.Pistas;
using MotoRacingDesktop.Forms.Vehiculos;
using MotoRacingDesktop.ViewForms;

namespace MotoRacingDesktop
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void corredoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void generacionDeCuotasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gestionDeCorredoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCorredores frmCorredores = new FrmCorredores();
            frmCorredores.ShowDialog();
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gestionDeVehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmActividades frmActividades = new FrmActividades();
            frmActividades.ShowDialog();
        }

        private void listadoDeVehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActividadesViewForm actividadesViewForm = new ActividadesViewForm();
            actividadesViewForm.ShowDialog();
        }

        private void gestionDeVehiculosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmVehiculos frmVehiculos = new FrmVehiculos();
            frmVehiculos.ShowDialog();
        }

        private void gestionDePistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPistas frmPistas = new FrmPistas();
            frmPistas.ShowDialog();
        }

        private void listadoDeCorredoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CorredoresViewForm corredoresViewForm = new CorredoresViewForm();
            corredoresViewForm.ShowDialog();
        }

        private void listadoDePistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PistasViewForm pistasViewForm = new PistasViewForm();
            pistasViewForm.ShowDialog();
        }

        private void listadoDeVehiculosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VehiculosViewForm vehiculosViewForm = new VehiculosViewForm();
            vehiculosViewForm.ShowDialog();
        }
    }
}