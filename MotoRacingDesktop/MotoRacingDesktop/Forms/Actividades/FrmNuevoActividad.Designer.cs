namespace MotoRacingDesktop.Forms.Actividades
{
    partial class FrmNuevoActividad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNuevoActividad));
            pictureBox1 = new PictureBox();
            txtNombre = new TextBox();
            label1 = new Label();
            btnSalir = new Button();
            btnGuardar = new Button();
            btnNuevoPista = new Button();
            label5 = new Label();
            comboPista = new ComboBox();
            txtHorarios = new TextBox();
            label2 = new Label();
            label3 = new Label();
            numCosto = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCosto).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(27, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(328, 222);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(432, 41);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(170, 23);
            txtNombre.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(375, 44);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 17;
            label1.Text = "Nombre";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(513, 227);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(89, 36);
            btnSalir.TabIndex = 16;
            btnSalir.Text = "Cancelar";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(412, 227);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(95, 36);
            btnGuardar.TabIndex = 15;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevoPista
            // 
            btnNuevoPista.Location = new Point(608, 170);
            btnNuevoPista.Name = "btnNuevoPista";
            btnNuevoPista.Size = new Size(28, 24);
            btnNuevoPista.TabIndex = 22;
            btnNuevoPista.Text = "...";
            btnNuevoPista.UseVisualStyleBackColor = true;
            btnNuevoPista.Click += btnNuevoActividad_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(391, 175);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 21;
            label5.Text = "Pista:";
            // 
            // comboPista
            // 
            comboPista.FormattingEnabled = true;
            comboPista.Location = new Point(432, 171);
            comboPista.Name = "comboPista";
            comboPista.Size = new Size(170, 23);
            comboPista.TabIndex = 20;
            // 
            // txtHorarios
            // 
            txtHorarios.Location = new Point(432, 129);
            txtHorarios.Name = "txtHorarios";
            txtHorarios.Size = new Size(170, 23);
            txtHorarios.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(375, 132);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 23;
            label2.Text = "Horarios";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(388, 88);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 25;
            label3.Text = "Costo";
            // 
            // numCosto
            // 
            numCosto.Location = new Point(432, 86);
            numCosto.Maximum = new decimal(new int[] { -159383553, 46653770, 5421, 0 });
            numCosto.Name = "numCosto";
            numCosto.Size = new Size(170, 23);
            numCosto.TabIndex = 27;
            // 
            // FrmNuevoActividad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 290);
            Controls.Add(numCosto);
            Controls.Add(label3);
            Controls.Add(txtHorarios);
            Controls.Add(label2);
            Controls.Add(btnNuevoPista);
            Controls.Add(label5);
            Controls.Add(comboPista);
            Controls.Add(pictureBox1);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(btnSalir);
            Controls.Add(btnGuardar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmNuevoActividad";
            Text = "Creando nueva actividad";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCosto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtNombre;
        private Label label1;
        private Button btnSalir;
        private Button btnGuardar;
        private Button btnNuevoPista;
        private Label label5;
        private ComboBox comboPista;
        private TextBox txtHorarios;
        private Label label2;
        private Label label3;
        private NumericUpDown numCosto;
    }
}