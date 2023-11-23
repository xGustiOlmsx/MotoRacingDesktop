namespace MotoRacingDesktop.Forms.Pistas
{
    partial class FrmPistas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPistas));
            txtBusqueda = new TextBox();
            dataGridPistas = new DataGridView();
            btnSalir = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnNuevo = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridPistas).BeginInit();
            SuspendLayout();
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(164, 56);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(518, 23);
            txtBusqueda.TabIndex = 20;
            txtBusqueda.TextChanged += txtBusqueda_TextChanged;
            // 
            // dataGridPistas
            // 
            dataGridPistas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridPistas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPistas.Location = new Point(196, 106);
            dataGridPistas.Name = "dataGridPistas";
            dataGridPistas.RowTemplate.Height = 25;
            dataGridPistas.Size = new Size(429, 211);
            dataGridPistas.TabIndex = 19;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(647, 345);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(95, 49);
            btnSalir.TabIndex = 18;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(463, 345);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(98, 49);
            btnEliminar.TabIndex = 17;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(256, 345);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(99, 49);
            btnEditar.TabIndex = 16;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(58, 345);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(100, 49);
            btnNuevo.TabIndex = 15;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 59);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 14;
            label1.Text = "Buscar:";
            // 
            // FrmPistas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBusqueda);
            Controls.Add(dataGridPistas);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnNuevo);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmPistas";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Gestion de pistas";
            ((System.ComponentModel.ISupportInitialize)dataGridPistas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBusqueda;
        private DataGridView dataGridPistas;
        private Button btnSalir;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnNuevo;
        private Label label1;
    }
}