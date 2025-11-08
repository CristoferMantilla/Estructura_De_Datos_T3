namespace Estructura_De_Datos_T3
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
            this.gbNueva = new System.Windows.Forms.GroupBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblPrioridad = new System.Windows.Forms.Label();
            this.cmbPrioridad = new System.Windows.Forms.ComboBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gbAcciones = new System.Windows.Forms.GroupBox();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.gbVista = new System.Windows.Forms.GroupBox();
            this.lstLista = new System.Windows.Forms.ListBox();
            this.lblLista = new System.Windows.Forms.Label();
            this.lblCola = new System.Windows.Forms.Label();
            this.lstCola = new System.Windows.Forms.ListBox();
            this.gbNueva.SuspendLayout();
            this.gbAcciones.SuspendLayout();
            this.gbVista.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbNueva
            // 
            this.gbNueva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbNueva.Controls.Add(this.lblNombre);
            this.gbNueva.Controls.Add(this.txtID);
            this.gbNueva.Controls.Add(this.dtpFecha);
            this.gbNueva.Controls.Add(this.btnAgregar);
            this.gbNueva.Controls.Add(this.lblFecha);
            this.gbNueva.Controls.Add(this.lblID);
            this.gbNueva.Controls.Add(this.cmbPrioridad);
            this.gbNueva.Controls.Add(this.txtNombre);
            this.gbNueva.Controls.Add(this.lblPrioridad);
            this.gbNueva.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNueva.Location = new System.Drawing.Point(12, 10);
            this.gbNueva.Name = "gbNueva";
            this.gbNueva.Size = new System.Drawing.Size(940, 209);
            this.gbNueva.TabIndex = 0;
            this.gbNueva.TabStop = false;
            this.gbNueva.Text = "Nueva tarea";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(222, 17);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(48, 29);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(356, 21);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(202, 31);
            this.txtID.TabIndex = 2;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(222, 58);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(102, 25);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(356, 60);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 31);
            this.txtNombre.TabIndex = 2;
            // 
            // lblPrioridad
            // 
            this.lblPrioridad.AutoSize = true;
            this.lblPrioridad.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrioridad.Location = new System.Drawing.Point(222, 93);
            this.lblPrioridad.Name = "lblPrioridad";
            this.lblPrioridad.Size = new System.Drawing.Size(114, 25);
            this.lblPrioridad.TabIndex = 3;
            this.lblPrioridad.Text = "Prioridad";
            this.lblPrioridad.Click += new System.EventHandler(this.lblPrioridad_Click);
            // 
            // cmbPrioridad
            // 
            this.cmbPrioridad.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPrioridad.FormattingEnabled = true;
            this.cmbPrioridad.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbPrioridad.Location = new System.Drawing.Point(356, 95);
            this.cmbPrioridad.Name = "cmbPrioridad";
            this.cmbPrioridad.Size = new System.Drawing.Size(200, 26);
            this.cmbPrioridad.TabIndex = 4;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(222, 130);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(114, 25);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "Fecha límite:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Arial Narrow", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(354, 133);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(202, 22);
            this.dtpFecha.TabIndex = 6;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Font = new System.Drawing.Font("Forte", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(632, 58);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(173, 81);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar tarea";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gbAcciones
            // 
            this.gbAcciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbAcciones.Controls.Add(this.btnConsultar);
            this.gbAcciones.Controls.Add(this.btnEliminar);
            this.gbAcciones.Controls.Add(this.btnEjecutar);
            this.gbAcciones.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAcciones.Location = new System.Drawing.Point(209, 263);
            this.gbAcciones.Name = "gbAcciones";
            this.gbAcciones.Size = new System.Drawing.Size(572, 80);
            this.gbAcciones.TabIndex = 8;
            this.gbAcciones.TabStop = false;
            this.gbAcciones.Text = "Acciones";
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEjecutar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEjecutar.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjecutar.Location = new System.Drawing.Point(20, 30);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(150, 35);
            this.btnEjecutar.TabIndex = 9;
            this.btnEjecutar.Text = "Ejecutar tarea:";
            this.btnEjecutar.UseVisualStyleBackColor = false;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(190, 30);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(150, 35);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar tarea";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(360, 30);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(170, 35);
            this.btnConsultar.TabIndex = 10;
            this.btnConsultar.Text = "Consultar tareas";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // gbVista
            // 
            this.gbVista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbVista.Controls.Add(this.lstCola);
            this.gbVista.Controls.Add(this.lblCola);
            this.gbVista.Controls.Add(this.lblLista);
            this.gbVista.Controls.Add(this.lstLista);
            this.gbVista.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbVista.Location = new System.Drawing.Point(12, 388);
            this.gbVista.Name = "gbVista";
            this.gbVista.Size = new System.Drawing.Size(940, 435);
            this.gbVista.TabIndex = 9;
            this.gbVista.TabStop = false;
            this.gbVista.Text = "Visualización";
            // 
            // lstLista
            // 
            this.lstLista.FormattingEnabled = true;
            this.lstLista.ItemHeight = 26;
            this.lstLista.Location = new System.Drawing.Point(78, 81);
            this.lstLista.Name = "lstLista";
            this.lstLista.Size = new System.Drawing.Size(300, 316);
            this.lstLista.TabIndex = 0;
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.BackColor = System.Drawing.Color.Orange;
            this.lblLista.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLista.Location = new System.Drawing.Point(138, 52);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(160, 26);
            this.lblLista.TabIndex = 1;
            this.lblLista.Text = "Lista de tareas:";
            // 
            // lblCola
            // 
            this.lblCola.AutoSize = true;
            this.lblCola.BackColor = System.Drawing.Color.Orange;
            this.lblCola.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCola.Location = new System.Drawing.Point(567, 52);
            this.lblCola.Name = "lblCola";
            this.lblCola.Size = new System.Drawing.Size(202, 26);
            this.lblCola.TabIndex = 2;
            this.lblCola.Text = "Cola de pendientes:";
            // 
            // lstCola
            // 
            this.lstCola.FormattingEnabled = true;
            this.lstCola.ItemHeight = 26;
            this.lstCola.Location = new System.Drawing.Point(523, 81);
            this.lstCola.Name = "lstCola";
            this.lstCola.Size = new System.Drawing.Size(300, 316);
            this.lstCola.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(972, 849);
            this.Controls.Add(this.gbVista);
            this.Controls.Add(this.gbAcciones);
            this.Controls.Add(this.gbNueva);
            this.Name = "Form1";
            this.Text = "GESTOR DE TAREAS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbNueva.ResumeLayout(false);
            this.gbNueva.PerformLayout();
            this.gbAcciones.ResumeLayout(false);
            this.gbVista.ResumeLayout(false);
            this.gbVista.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNueva;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblPrioridad;
        private System.Windows.Forms.ComboBox cmbPrioridad;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox gbAcciones;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox gbVista;
        private System.Windows.Forms.Label lblCola;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.ListBox lstLista;
        private System.Windows.Forms.ListBox lstCola;
    }
}

