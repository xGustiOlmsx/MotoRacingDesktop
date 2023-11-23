namespace MotoRacingDesktop.Forms
{
    partial class FrmNuevoCorredor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNuevoCorredor));
            label1 = new Label();
            txtApellidoNombre = new TextBox();
            txtTelefono = new TextBox();
            label2 = new Label();
            txtDireccion = new TextBox();
            label3 = new Label();
            btnCancelar = new Button();
            btnGuardar = new Button();
            comboVehiculo = new ComboBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            btnNuevoVehiculo = new Button();
            btnNuevoActividad = new Button();
            label5 = new Label();
            comboActividad = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(434, 48);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre y Apellido:";
            // 
            // txtApellidoNombre
            // 
            txtApellidoNombre.Location = new Point(550, 45);
            txtApellidoNombre.Name = "txtApellidoNombre";
            txtApellidoNombre.Size = new Size(237, 23);
            txtApellidoNombre.TabIndex = 1;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(550, 124);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(237, 23);
            txtTelefono.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(489, 127);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 2;
            label2.Text = "Telefono:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(550, 84);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(237, 23);
            txtDireccion.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(484, 87);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 4;
            label3.Text = "Direccion:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(685, 253);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(102, 44);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(533, 253);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(102, 44);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // comboVehiculo
            // 
            comboVehiculo.FormattingEnabled = true;
            comboVehiculo.Location = new Point(550, 168);
            comboVehiculo.Name = "comboVehiculo";
            comboVehiculo.Size = new Size(237, 23);
            comboVehiculo.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(489, 171);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 9;
            label4.Text = "Vehiculo:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(25, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(376, 252);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // btnNuevoVehiculo
            // 
            btnNuevoVehiculo.Location = new Point(793, 167);
            btnNuevoVehiculo.Name = "btnNuevoVehiculo";
            btnNuevoVehiculo.Size = new Size(28, 24);
            btnNuevoVehiculo.TabIndex = 14;
            btnNuevoVehiculo.Text = "...";
            btnNuevoVehiculo.UseVisualStyleBackColor = true;
            btnNuevoVehiculo.Click += btnNuevoVehiculo_Click;
            // 
            // btnNuevoActividad
            // 
            btnNuevoActividad.Location = new Point(793, 209);
            btnNuevoActividad.Name = "btnNuevoActividad";
            btnNuevoActividad.Size = new Size(28, 24);
            btnNuevoActividad.TabIndex = 19;
            btnNuevoActividad.Text = "...";
            btnNuevoActividad.UseVisualStyleBackColor = true;
            btnNuevoActividad.Click += btnNuevoActividad_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(479, 213);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 18;
            label5.Text = "Actividad:";
            // 
            // comboActividad
            // 
            comboActividad.FormattingEnabled = true;
            comboActividad.Location = new Point(550, 210);
            comboActividad.Name = "comboActividad";
            comboActividad.Size = new Size(237, 23);
            comboActividad.TabIndex = 17;
            // 
            // FrmNuevoCorredor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(842, 345);
            Controls.Add(btnNuevoActividad);
            Controls.Add(label5);
            Controls.Add(comboActividad);
            Controls.Add(btnNuevoVehiculo);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(comboVehiculo);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(txtDireccion);
            Controls.Add(label3);
            Controls.Add(txtTelefono);
            Controls.Add(label2);
            Controls.Add(txtApellidoNombre);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmNuevoCorredor";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Creando un nuevo corredor";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtApellidoNombre;
        private TextBox txtTelefono;
        private Label label2;
        private TextBox txtDireccion;
        private Label label3;
        private Button btnCancelar;
        private Button btnGuardar;
        private ComboBox comboVehiculo;
        private Label label4;
        private PictureBox pictureBox1;
        private Button btnNuevoVehiculo;
        private Button btnNuevoActividad;
        private Label label5;
        private ComboBox comboActividad;
    }
}