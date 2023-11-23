namespace MotoRacingDesktop.Forms
{
    partial class FrmCorredores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCorredores));
            label1 = new Label();
            btnNuevo = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnSalir = new Button();
            dataGridCorredores = new DataGridView();
            txtBusqueda = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridCorredores).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(192, 33);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Buscar:";
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(137, 429);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(100, 49);
            btnNuevo.TabIndex = 1;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click_1;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(349, 429);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(99, 49);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(556, 429);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(98, 49);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click_2;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(740, 429);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(95, 49);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click_1;
            // 
            // dataGridCorredores
            // 
            dataGridCorredores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridCorredores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCorredores.Location = new Point(137, 130);
            dataGridCorredores.Name = "dataGridCorredores";
            dataGridCorredores.RowTemplate.Height = 25;
            dataGridCorredores.Size = new Size(698, 257);
            dataGridCorredores.TabIndex = 5;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(262, 30);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(518, 23);
            txtBusqueda.TabIndex = 6;
            txtBusqueda.TextChanged += txtBusqueda_TextChanged_1;
            // 
            // FrmCorredores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(973, 535);
            Controls.Add(txtBusqueda);
            Controls.Add(dataGridCorredores);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnNuevo);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmCorredores";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Gestion de corredores";
            ((System.ComponentModel.ISupportInitialize)dataGridCorredores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnNuevo;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnSalir;
        private DataGridView dataGridCorredores;
        private TextBox txtBusqueda;
    }
}