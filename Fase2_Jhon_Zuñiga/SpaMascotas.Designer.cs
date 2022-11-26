namespace Fase1_Jhon_Zuñiga
{
    partial class SpaMascotas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpaMascotas));
            this.label1 = new System.Windows.Forms.Label();
            this.txtPropietario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtServicio3 = new System.Windows.Forms.RadioButton();
            this.rbtServicio2 = new System.Windows.Forms.RadioButton();
            this.rbtServicio1 = new System.Windows.Forms.RadioButton();
            this.cbxEstrato = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMascota = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCostoServicio = new System.Windows.Forms.TextBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.errorIdentificacion = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPropietario = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorMascota = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIdentificacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPropietario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMascota)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Propietario";
            // 
            // txtPropietario
            // 
            this.txtPropietario.Location = new System.Drawing.Point(132, 25);
            this.txtPropietario.Name = "txtPropietario";
            this.txtPropietario.Size = new System.Drawing.Size(237, 23);
            this.txtPropietario.TabIndex = 1;
            this.txtPropietario.TextChanged += new System.EventHandler(this.txtPropietario_TextChanged);
            this.txtPropietario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPropietario_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Identificación";
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(487, 29);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(195, 23);
            this.txtIdentificacion.TabIndex = 3;
            this.txtIdentificacion.TextChanged += new System.EventHandler(this.txtIdentificacion_TextChanged);
            this.txtIdentificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdentificacion_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtServicio3);
            this.groupBox1.Controls.Add(this.rbtServicio2);
            this.groupBox1.Controls.Add(this.rbtServicio1);
            this.groupBox1.Location = new System.Drawing.Point(14, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 112);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Servicios";
            // 
            // rbtServicio3
            // 
            this.rbtServicio3.AutoSize = true;
            this.rbtServicio3.Location = new System.Drawing.Point(6, 80);
            this.rbtServicio3.Name = "rbtServicio3";
            this.rbtServicio3.Size = new System.Drawing.Size(341, 19);
            this.rbtServicio3.TabIndex = 2;
            this.rbtServicio3.TabStop = true;
            this.rbtServicio3.Text = "Baño, Corte, Vacuna Antigarrapatas y Antiparácitos $100.000";
            this.rbtServicio3.UseVisualStyleBackColor = true;
            this.rbtServicio3.CheckedChanged += new System.EventHandler(this.RbtServicio3_CheckedChanged);
            this.rbtServicio3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rbtServicio3_KeyPress);
            // 
            // rbtServicio2
            // 
            this.rbtServicio2.AutoSize = true;
            this.rbtServicio2.Location = new System.Drawing.Point(6, 55);
            this.rbtServicio2.Name = "rbtServicio2";
            this.rbtServicio2.Size = new System.Drawing.Size(259, 19);
            this.rbtServicio2.TabIndex = 1;
            this.rbtServicio2.TabStop = true;
            this.rbtServicio2.Text = "Baño, Corte y Vacuna Antigarrapatas $80.000";
            this.rbtServicio2.UseVisualStyleBackColor = true;
            this.rbtServicio2.CheckedChanged += new System.EventHandler(this.RbtServicio2_CheckedChanged);
            this.rbtServicio2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rbtServicio2_KeyPress);
            // 
            // rbtServicio1
            // 
            this.rbtServicio1.AutoSize = true;
            this.rbtServicio1.Location = new System.Drawing.Point(6, 30);
            this.rbtServicio1.Name = "rbtServicio1";
            this.rbtServicio1.Size = new System.Drawing.Size(135, 19);
            this.rbtServicio1.TabIndex = 0;
            this.rbtServicio1.TabStop = true;
            this.rbtServicio1.Text = "Baño y Corte $45.000";
            this.rbtServicio1.UseVisualStyleBackColor = true;
            this.rbtServicio1.CheckedChanged += new System.EventHandler(this.RbtServicio1_CheckedChanged);
            this.rbtServicio1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rbtServicio1_KeyPress);
            // 
            // cbxEstrato
            // 
            this.cbxEstrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstrato.FormattingEnabled = true;
            this.cbxEstrato.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "Mayor"});
            this.cbxEstrato.Location = new System.Drawing.Point(487, 67);
            this.cbxEstrato.Name = "cbxEstrato";
            this.cbxEstrato.Size = new System.Drawing.Size(126, 23);
            this.cbxEstrato.TabIndex = 5;
            this.cbxEstrato.SelectedIndexChanged += new System.EventHandler(this.CbxEstrato_SelectedIndexChanged);
            this.cbxEstrato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxEstrato_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre Mascota";
            // 
            // txtMascota
            // 
            this.txtMascota.Location = new System.Drawing.Point(132, 63);
            this.txtMascota.Name = "txtMascota";
            this.txtMascota.Size = new System.Drawing.Size(237, 23);
            this.txtMascota.TabIndex = 7;
            this.txtMascota.TextChanged += new System.EventHandler(this.txtMascota_TextChanged);
            this.txtMascota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMascota_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(402, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Costo Servicio";
            // 
            // txtCostoServicio
            // 
            this.txtCostoServicio.Enabled = false;
            this.txtCostoServicio.Location = new System.Drawing.Point(490, 192);
            this.txtCostoServicio.Name = "txtCostoServicio";
            this.txtCostoServicio.Size = new System.Drawing.Size(123, 23);
            this.txtCostoServicio.TabIndex = 9;
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.Olive;
            this.btnMostrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrar.Enabled = false;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMostrar.Location = new System.Drawing.Point(490, 274);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 33);
            this.btnMostrar.TabIndex = 10;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Olive;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.Location = new System.Drawing.Point(614, 274);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 33);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            this.btnGuardar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnGuardar_KeyPress);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Location = new System.Drawing.Point(20, 274);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 33);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // txtDescuento
            // 
            this.txtDescuento.Enabled = false;
            this.txtDescuento.Location = new System.Drawing.Point(490, 149);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(123, 23);
            this.txtDescuento.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(408, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "V. Descuento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(429, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Estrato";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Olive;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLimpiar.Location = new System.Drawing.Point(360, 274);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(79, 33);
            this.btnLimpiar.TabIndex = 16;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // errorIdentificacion
            // 
            this.errorIdentificacion.ContainerControl = this;
            // 
            // errorPropietario
            // 
            this.errorPropietario.ContainerControl = this;
            // 
            // errorMascota
            // 
            this.errorMascota.ContainerControl = this;
            // 
            // SpaMascotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(190)))), ((int)(((byte)(5)))));
            this.ClientSize = new System.Drawing.Size(716, 319);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.txtCostoServicio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMascota);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxEstrato);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPropietario);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SpaMascotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spa Mascotas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SpaMascotas_FormClosing);
            this.Load += new System.EventHandler(this.SpaMascotas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIdentificacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPropietario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMascota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtIdentificacion;
        private GroupBox groupBox1;
        private RadioButton rbtServicio3;
        private RadioButton rbtServicio2;
        private RadioButton rbtServicio1;
        private ComboBox cbxEstrato;
        private Label label3;
        private TextBox txtMascota;
        private Label label4;
        private TextBox txtCostoServicio;
        private Button btnGuardar;
        private Button btnSalir;
        private TextBox txtDescuento;
        private Label label5;
        private Label label6;
        public Button btnMostrar;
        private Button btnLimpiar;
        private ErrorProvider errorIdentificacion;
        private ErrorProvider errorPropietario;
        private ErrorProvider errorMascota;
        public TextBox txtPropietario;
    }
}