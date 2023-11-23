namespace MotoRacingDesktop.Forms.Vehiculos
{
    partial class FrmVehiculos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVehiculos));
            txtBusqueda = new TextBox();
            dataGridVehiculos = new DataGridView();
            btnSalir = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnNuevo = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridVehiculos).BeginInit();
            SuspendLayout();
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(171, 56);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(518, 23);
            txtBusqueda.TabIndex = 13;
            txtBusqueda.TextChanged += txtBusqueda_TextChanged;
            // 
            // dataGridVehiculos
            // 
            dataGridVehiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridVehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridVehiculos.Location = new Point(199, 109);
            dataGridVehiculos.Name = "dataGridVehiculos";
            dataGridVehiculos.RowTemplate.Height = 25;
            dataGridVehiculos.Size = new Size(429, 211);
            dataGridVehiculos.TabIndex = 12;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(654, 345);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(95, 49);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(470, 345);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(98, 49);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(263, 345);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(99, 49);
            btnEditar.TabIndex = 9;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(65, 345);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(100, 49);
            btnNuevo.TabIndex = 8;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 59);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 7;
            label1.Text = "Buscar:";
            // 
            // FrmVehiculos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(810, 450);
            Controls.Add(txtBusqueda);
            Controls.Add(dataGridVehiculos);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnNuevo);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmVehiculos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Gestion de vehiculos";
            ((System.ComponentModel.ISupportInitialize)dataGridVehiculos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBusqueda;
        private DataGridView dataGridVehiculos;
        private Button btnSalir;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnNuevo;
        private Label label1;
    }
}