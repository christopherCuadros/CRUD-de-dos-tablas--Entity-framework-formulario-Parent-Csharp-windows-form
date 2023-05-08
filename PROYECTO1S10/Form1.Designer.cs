namespace PROYECTO1S10
{
    partial class FrmVentas
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
            this.dgvPasajeros = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtAp = new System.Windows.Forms.TextBox();
            this.txtAm = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasajeros)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPasajeros
            // 
            this.dgvPasajeros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPasajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPasajeros.Location = new System.Drawing.Point(12, 12);
            this.dgvPasajeros.Name = "dgvPasajeros";
            this.dgvPasajeros.RowHeadersWidth = 51;
            this.dgvPasajeros.RowTemplate.Height = 24;
            this.dgvPasajeros.Size = new System.Drawing.Size(802, 281);
            this.dgvPasajeros.TabIndex = 0;
            this.dgvPasajeros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPasajeros_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.chkActivo);
            this.groupBox1.Controls.Add(this.txtDni);
            this.groupBox1.Controls.Add(this.txtAm);
            this.groupBox1.Controls.Add(this.txtAp);
            this.groupBox1.Controls.Add(this.txtNombres);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(858, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 312);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido Paterno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido Materno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombres";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "DNI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Activo";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(147, 39);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(181, 22);
            this.txtId.TabIndex = 6;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(147, 67);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(181, 22);
            this.txtNombres.TabIndex = 7;
            // 
            // txtAp
            // 
            this.txtAp.Location = new System.Drawing.Point(147, 96);
            this.txtAp.Name = "txtAp";
            this.txtAp.Size = new System.Drawing.Size(181, 22);
            this.txtAp.TabIndex = 8;
            // 
            // txtAm
            // 
            this.txtAm.Location = new System.Drawing.Point(147, 128);
            this.txtAm.Name = "txtAm";
            this.txtAm.Size = new System.Drawing.Size(181, 22);
            this.txtAm.TabIndex = 9;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(147, 158);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(181, 22);
            this.txtDni.TabIndex = 10;
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Location = new System.Drawing.Point(147, 193);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(18, 17);
            this.chkActivo.TabIndex = 11;
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(711, 299);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(103, 33);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(122, 273);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(105, 33);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(250, 273);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(104, 33);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 387);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvPasajeros);
            this.Name = "FrmVentas";
            this.Text = " FORMULARIO DE VENTAS";
            this.Load += new System.EventHandler(this.FrmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasajeros)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPasajeros;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtAm;
        private System.Windows.Forms.TextBox txtAp;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnNuevo;
    }
}

