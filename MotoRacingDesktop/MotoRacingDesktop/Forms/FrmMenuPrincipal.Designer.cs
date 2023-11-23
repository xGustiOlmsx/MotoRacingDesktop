namespace MotoRacingDesktop
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            menuStrip1 = new MenuStrip();
            principalToolStripMenuItem = new ToolStripMenuItem();
            corredoresToolStripMenuItem = new ToolStripMenuItem();
            gestionDeCorredoresToolStripMenuItem = new ToolStripMenuItem();
            listadoDeCorredoresToolStripMenuItem = new ToolStripMenuItem();
            vehiculoToolStripMenuItem = new ToolStripMenuItem();
            gestionDeVehiculosToolStripMenuItem = new ToolStripMenuItem();
            listadoDeVehiculosToolStripMenuItem = new ToolStripMenuItem();
            vehiculosToolStripMenuItem = new ToolStripMenuItem();
            gestionDeVehiculosToolStripMenuItem1 = new ToolStripMenuItem();
            listadoDeVehiculosToolStripMenuItem1 = new ToolStripMenuItem();
            pistasToolStripMenuItem = new ToolStripMenuItem();
            gestionDePistasToolStripMenuItem = new ToolStripMenuItem();
            listadoDePistasToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            salirDelSistemaToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            aceracDeToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { principalToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // principalToolStripMenuItem
            // 
            principalToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { corredoresToolStripMenuItem, vehiculoToolStripMenuItem, vehiculosToolStripMenuItem, pistasToolStripMenuItem });
            principalToolStripMenuItem.Name = "principalToolStripMenuItem";
            principalToolStripMenuItem.Size = new Size(65, 20);
            principalToolStripMenuItem.Text = "Principal";
            // 
            // corredoresToolStripMenuItem
            // 
            corredoresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gestionDeCorredoresToolStripMenuItem, listadoDeCorredoresToolStripMenuItem });
            corredoresToolStripMenuItem.Name = "corredoresToolStripMenuItem";
            corredoresToolStripMenuItem.Size = new Size(180, 22);
            corredoresToolStripMenuItem.Text = "Corredores";
            corredoresToolStripMenuItem.Click += corredoresToolStripMenuItem_Click;
            // 
            // gestionDeCorredoresToolStripMenuItem
            // 
            gestionDeCorredoresToolStripMenuItem.Name = "gestionDeCorredoresToolStripMenuItem";
            gestionDeCorredoresToolStripMenuItem.Size = new Size(189, 22);
            gestionDeCorredoresToolStripMenuItem.Text = "Gestion de corredores";
            gestionDeCorredoresToolStripMenuItem.Click += gestionDeCorredoresToolStripMenuItem_Click;
            // 
            // listadoDeCorredoresToolStripMenuItem
            // 
            listadoDeCorredoresToolStripMenuItem.Name = "listadoDeCorredoresToolStripMenuItem";
            listadoDeCorredoresToolStripMenuItem.Size = new Size(189, 22);
            listadoDeCorredoresToolStripMenuItem.Text = "Listado de corredores";
            listadoDeCorredoresToolStripMenuItem.Click += listadoDeCorredoresToolStripMenuItem_Click;
            // 
            // vehiculoToolStripMenuItem
            // 
            vehiculoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gestionDeVehiculosToolStripMenuItem, listadoDeVehiculosToolStripMenuItem });
            vehiculoToolStripMenuItem.Name = "vehiculoToolStripMenuItem";
            vehiculoToolStripMenuItem.Size = new Size(180, 22);
            vehiculoToolStripMenuItem.Text = "Actividades";
            // 
            // gestionDeVehiculosToolStripMenuItem
            // 
            gestionDeVehiculosToolStripMenuItem.Name = "gestionDeVehiculosToolStripMenuItem";
            gestionDeVehiculosToolStripMenuItem.Size = new Size(192, 22);
            gestionDeVehiculosToolStripMenuItem.Text = "Gestion de actividades";
            gestionDeVehiculosToolStripMenuItem.Click += gestionDeVehiculosToolStripMenuItem_Click;
            // 
            // listadoDeVehiculosToolStripMenuItem
            // 
            listadoDeVehiculosToolStripMenuItem.Name = "listadoDeVehiculosToolStripMenuItem";
            listadoDeVehiculosToolStripMenuItem.Size = new Size(192, 22);
            listadoDeVehiculosToolStripMenuItem.Text = "Listado de actividades";
            listadoDeVehiculosToolStripMenuItem.Click += listadoDeVehiculosToolStripMenuItem_Click;
            // 
            // vehiculosToolStripMenuItem
            // 
            vehiculosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gestionDeVehiculosToolStripMenuItem1, listadoDeVehiculosToolStripMenuItem1 });
            vehiculosToolStripMenuItem.Name = "vehiculosToolStripMenuItem";
            vehiculosToolStripMenuItem.Size = new Size(180, 22);
            vehiculosToolStripMenuItem.Text = "Vehiculos";
            // 
            // gestionDeVehiculosToolStripMenuItem1
            // 
            gestionDeVehiculosToolStripMenuItem1.Name = "gestionDeVehiculosToolStripMenuItem1";
            gestionDeVehiculosToolStripMenuItem1.Size = new Size(183, 22);
            gestionDeVehiculosToolStripMenuItem1.Text = "Gestion de Vehiculos";
            gestionDeVehiculosToolStripMenuItem1.Click += gestionDeVehiculosToolStripMenuItem1_Click;
            // 
            // listadoDeVehiculosToolStripMenuItem1
            // 
            listadoDeVehiculosToolStripMenuItem1.Name = "listadoDeVehiculosToolStripMenuItem1";
            listadoDeVehiculosToolStripMenuItem1.Size = new Size(183, 22);
            listadoDeVehiculosToolStripMenuItem1.Text = "Listado de Vehiculos";
            listadoDeVehiculosToolStripMenuItem1.Click += listadoDeVehiculosToolStripMenuItem1_Click;
            // 
            // pistasToolStripMenuItem
            // 
            pistasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gestionDePistasToolStripMenuItem, listadoDePistasToolStripMenuItem });
            pistasToolStripMenuItem.Name = "pistasToolStripMenuItem";
            pistasToolStripMenuItem.Size = new Size(180, 22);
            pistasToolStripMenuItem.Text = "Pistas";
            // 
            // gestionDePistasToolStripMenuItem
            // 
            gestionDePistasToolStripMenuItem.Name = "gestionDePistasToolStripMenuItem";
            gestionDePistasToolStripMenuItem.Size = new Size(180, 22);
            gestionDePistasToolStripMenuItem.Text = "Gestion de pistas";
            gestionDePistasToolStripMenuItem.Click += gestionDePistasToolStripMenuItem_Click;
            // 
            // listadoDePistasToolStripMenuItem
            // 
            listadoDePistasToolStripMenuItem.Name = "listadoDePistasToolStripMenuItem";
            listadoDePistasToolStripMenuItem.Size = new Size(180, 22);
            listadoDePistasToolStripMenuItem.Text = "Listado de pistas";
            listadoDePistasToolStripMenuItem.Click += listadoDePistasToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirDelSistemaToolStripMenuItem, toolStripSeparator1, aceracDeToolStripMenuItem });
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(41, 20);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // salirDelSistemaToolStripMenuItem
            // 
            salirDelSistemaToolStripMenuItem.Name = "salirDelSistemaToolStripMenuItem";
            salirDelSistemaToolStripMenuItem.Size = new Size(158, 22);
            salirDelSistemaToolStripMenuItem.Text = "Salir del sistema";
            salirDelSistemaToolStripMenuItem.Click += salirDelSistemaToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(155, 6);
            // 
            // aceracDeToolStripMenuItem
            // 
            aceracDeToolStripMenuItem.Name = "aceracDeToolStripMenuItem";
            aceracDeToolStripMenuItem.Size = new Size(158, 22);
            aceracDeToolStripMenuItem.Text = "Acerca de...";
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "FrmMenuPrincipal";
            Text = "MotoRacingDesktop 1.0 - Gestion de alquileres de circuito de Motos/Karting";
            WindowState = FormWindowState.Maximized;
            Load += FrmMenuPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem principalToolStripMenuItem;
        private ToolStripMenuItem corredoresToolStripMenuItem;
        private ToolStripMenuItem vehiculoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem salirDelSistemaToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem aceracDeToolStripMenuItem;
        private ToolStripMenuItem gestionDeCorredoresToolStripMenuItem;
        private ToolStripMenuItem listadoDeCorredoresToolStripMenuItem;
        private ToolStripMenuItem gestionDeVehiculosToolStripMenuItem;
        private ToolStripMenuItem listadoDeVehiculosToolStripMenuItem;
        private ToolStripMenuItem vehiculosToolStripMenuItem;
        private ToolStripMenuItem gestionDeVehiculosToolStripMenuItem1;
        private ToolStripMenuItem listadoDeVehiculosToolStripMenuItem1;
        private ToolStripMenuItem pistasToolStripMenuItem;
        private ToolStripMenuItem gestionDePistasToolStripMenuItem;
        private ToolStripMenuItem listadoDePistasToolStripMenuItem;
    }
}