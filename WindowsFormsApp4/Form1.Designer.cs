namespace WindowsFormsApp4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listaAlumnos = new System.Windows.Forms.DataGridView();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.txtcarrera = new System.Windows.Forms.TextBox();
            this.txtaño = new System.Windows.Forms.TextBox();
            this.btninscribir = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.listaAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // listaAlumnos
            // 
            this.listaAlumnos.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listaAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.listaAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaAlumnos.Location = new System.Drawing.Point(11, 12);
            this.listaAlumnos.Name = "listaAlumnos";
            this.listaAlumnos.Size = new System.Drawing.Size(626, 319);
            this.listaAlumnos.TabIndex = 1;
            this.listaAlumnos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaAlumnos_CellDoubleClick);
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(642, 58);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(104, 21);
            this.txtid.TabIndex = 2;
            this.txtid.Text = "Id";
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            this.txtid.Enter += new System.EventHandler(this.txtid_Enter);
            this.txtid.Leave += new System.EventHandler(this.txtid_Leave);
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(752, 58);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(112, 21);
            this.txtnombre.TabIndex = 3;
            this.txtnombre.Text = "Nombre";
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            this.txtnombre.Enter += new System.EventHandler(this.txtnombre_Enter);
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_KeyPress);
            this.txtnombre.Leave += new System.EventHandler(this.txtnombre_Leave);
            // 
            // txtapellido
            // 
            this.txtapellido.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapellido.Location = new System.Drawing.Point(642, 85);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(167, 21);
            this.txtapellido.TabIndex = 4;
            this.txtapellido.Text = "Apellido";
            this.txtapellido.TextChanged += new System.EventHandler(this.txtapellido_TextChanged);
            this.txtapellido.Enter += new System.EventHandler(this.txtapellido_Enter);
            this.txtapellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtapellido_KeyPress);
            this.txtapellido.Leave += new System.EventHandler(this.txtapellido_Leave);
            // 
            // txtedad
            // 
            this.txtedad.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtedad.Location = new System.Drawing.Point(815, 85);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(48, 21);
            this.txtedad.TabIndex = 5;
            this.txtedad.Text = "Edad";
            this.txtedad.TextChanged += new System.EventHandler(this.txtedad_TextChanged);
            this.txtedad.Enter += new System.EventHandler(this.txtedad_Enter);
            this.txtedad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtedad_KeyPress);
            this.txtedad.Leave += new System.EventHandler(this.txtedad_Leave);
            // 
            // txtcorreo
            // 
            this.txtcorreo.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcorreo.Location = new System.Drawing.Point(642, 112);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(222, 21);
            this.txtcorreo.TabIndex = 6;
            this.txtcorreo.Text = "Correo electrónico";
            this.txtcorreo.Enter += new System.EventHandler(this.txtcorreo_Enter);
            this.txtcorreo.Leave += new System.EventHandler(this.txtcorreo_Leave);
            // 
            // txtcarrera
            // 
            this.txtcarrera.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcarrera.Location = new System.Drawing.Point(642, 139);
            this.txtcarrera.Name = "txtcarrera";
            this.txtcarrera.Size = new System.Drawing.Size(145, 21);
            this.txtcarrera.TabIndex = 7;
            this.txtcarrera.Text = "Carrera";
            this.txtcarrera.Enter += new System.EventHandler(this.txtcarrera_Enter);
            this.txtcarrera.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcarrera_KeyPress);
            this.txtcarrera.Leave += new System.EventHandler(this.txtcarrera_Leave);
            // 
            // txtaño
            // 
            this.txtaño.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaño.Location = new System.Drawing.Point(793, 139);
            this.txtaño.Name = "txtaño";
            this.txtaño.Size = new System.Drawing.Size(71, 21);
            this.txtaño.TabIndex = 8;
            this.txtaño.Text = "Año carrera";
            this.txtaño.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            this.txtaño.Enter += new System.EventHandler(this.txtaño_Enter);
            this.txtaño.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtaño_KeyPress);
            this.txtaño.Leave += new System.EventHandler(this.txtaño_Leave);
            // 
            // btninscribir
            // 
            this.btninscribir.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninscribir.Location = new System.Drawing.Point(641, 174);
            this.btninscribir.Name = "btninscribir";
            this.btninscribir.Size = new System.Drawing.Size(222, 28);
            this.btninscribir.TabIndex = 9;
            this.btninscribir.Text = "Inscribir";
            this.btninscribir.UseVisualStyleBackColor = true;
            this.btninscribir.Click += new System.EventHandler(this.btninscribir_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificar.Location = new System.Drawing.Point(753, 208);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(104, 28);
            this.btnmodificar.TabIndex = 10;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnborrar.Location = new System.Drawing.Point(643, 208);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(104, 28);
            this.btnborrar.TabIndex = 11;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(667, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 33);
            this.label1.TabIndex = 12;
            this.label1.Text = "Inscripciones";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(643, 316);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 13);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(876, 338);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btninscribir);
            this.Controls.Add(this.txtaño);
            this.Controls.Add(this.txtcarrera);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.listaAlumnos);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Beppo Levi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView listaAlumnos;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.TextBox txtcarrera;
        private System.Windows.Forms.TextBox txtaño;
        private System.Windows.Forms.Button btninscribir;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

