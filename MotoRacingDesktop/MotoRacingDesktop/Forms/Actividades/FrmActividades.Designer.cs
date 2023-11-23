namespace MotoRacingDesktop.Forms.Actividades
{
    partial class FrmActividades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmActividades));
            txtBusqueda = new TextBox();
            dataGridActividades = new DataGridView();
            btnSalir = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnNuevo = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridActividades).BeginInit();
            SuspendLayout();
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(200, 28);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(518, 23);
            txtBusqueda.TabIndex = 20;
            txtBusqueda.TextChanged += txtBusqueda_TextChanged;
            // 
            // dataGridActividades
            // 
            dataGridActividades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridActividades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridActividades.Location = new Point(61, 83);
            dataGridActividades.Name = "dataGridActividades";
            dataGridActividades.RowTemplate.Height = 25;
            dataGridActividades.Size = new Size(705, 311);
            dataGridActividades.TabIndex = 19;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(581, 423);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(95, 49);
            btnSalir.TabIndex = 18;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(436, 423);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(98, 49);
            btnEliminar.TabIndex = 17;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(286, 423);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(99, 49);
            btnEditar.TabIndex = 16;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(147, 423);
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
            label1.Location = new Point(121, 31);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 14;
            label1.Text = "Buscar:";
            // 
            // FrmActividades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(826, 495);
            Controls.Add(txtBusqueda);
            Controls.Add(dataGridActividades);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnNuevo);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmActividades";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Gestion de actividades";
            ((System.ComponentModel.ISupportInitialize)dataGridActividades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBusqueda;
        private DataGridView dataGridActividades;
        private Button btnSalir;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnNuevo;
        private Label label1;
    }
}