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
            this.gbNueva.Controls.Add(this.lblNombre);
            this.gbNueva.Controls.Add(this.txtID);
            this.gbNueva.Location = new System.Drawing.Point(10, 10);
            this.gbNueva.Name = "gbNueva";
            this.gbNueva.Size = new System.Drawing.Size(942, 140);
            this.gbNueva.TabIndex = 0;
            this.gbNueva.TabStop = false;
            this.gbNueva.Text = "Nueva tarea";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(20, 30);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(20, 16);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(84, 17);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(120, 22);
            this.txtID.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(226, 23);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(300, 25);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // lblPrioridad
            // 
            this.lblPrioridad.AutoSize = true;
            this.lblPrioridad.Location = new System.Drawing.Point(520, 30);
            this.lblPrioridad.Name = "lblPrioridad";
            this.lblPrioridad.Size = new System.Drawing.Size(62, 16);
            this.lblPrioridad.TabIndex = 3;
            this.lblPrioridad.Text = "Prioridad";
            // 
            // cmbPrioridad
            // 
            this.cmbPrioridad.FormattingEnabled = true;
            this.cmbPrioridad.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbPrioridad.Location = new System.Drawing.Point(600, 25);
            this.cmbPrioridad.Name = "cmbPrioridad";
            this.cmbPrioridad.Size = new System.Drawing.Size(100, 24);
            this.cmbPrioridad.TabIndex = 4;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(720, 30);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(82, 16);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "Fecha límite:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(820, 25);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(120, 22);
            this.dtpFecha.TabIndex = 6;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(20, 70);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(150, 35);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar tarea";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gbAcciones
            // 
            this.gbAcciones.Controls.Add(this.btnConsultar);
            this.gbAcciones.Controls.Add(this.btnEliminar);
            this.gbAcciones.Controls.Add(this.btnEjecutar);
            this.gbAcciones.Location = new System.Drawing.Point(10, 160);
            this.gbAcciones.Name = "gbAcciones";
            this.gbAcciones.Size = new System.Drawing.Size(942, 80);
            this.gbAcciones.TabIndex = 8;
            this.gbAcciones.TabStop = false;
            this.gbAcciones.Text = "Acciones";
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(20, 30);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(150, 35);
            this.btnEjecutar.TabIndex = 9;
            this.btnEjecutar.Text = "Ejecutar tarea:";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(190, 30);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(150, 35);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar tarea";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(360, 30);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(170, 35);
            this.btnConsultar.TabIndex = 10;
            this.btnConsultar.Text = "Consultar tareas";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // gbVista
            // 
            this.gbVista.Controls.Add(this.lstCola);
            this.gbVista.Controls.Add(this.lblCola);
            this.gbVista.Controls.Add(this.lblLista);
            this.gbVista.Controls.Add(this.lstLista);
            this.gbVista.Location = new System.Drawing.Point(10, 250);
            this.gbVista.Name = "gbVista";
            this.gbVista.Size = new System.Drawing.Size(940, 435);
            this.gbVista.TabIndex = 9;
            this.gbVista.TabStop = false;
            this.gbVista.Text = "Visualización";
            // 
            // lstLista
            // 
            this.lstLista.FormattingEnabled = true;
            this.lstLista.ItemHeight = 16;
            this.lstLista.Location = new System.Drawing.Point(71, 55);
            this.lstLista.Name = "lstLista";
            this.lstLista.Size = new System.Drawing.Size(300, 340);
            this.lstLista.TabIndex = 0;
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Location = new System.Drawing.Point(157, 30);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(98, 16);
            this.lblLista.TabIndex = 1;
            this.lblLista.Text = "Lista de tareas:";
            // 
            // lblCola
            // 
            this.lblCola.AutoSize = true;
            this.lblCola.Location = new System.Drawing.Point(621, 30);
            this.lblCola.Name = "lblCola";
            this.lblCola.Size = new System.Drawing.Size(127, 16);
            this.lblCola.TabIndex = 2;
            this.lblCola.Text = "Cola de pendientes:";
            // 
            // lstCola
            // 
            this.lstCola.FormattingEnabled = true;
            this.lstCola.ItemHeight = 16;
            this.lstCola.Location = new System.Drawing.Point(541, 55);
            this.lstCola.Name = "lstCola";
            this.lstCola.Size = new System.Drawing.Size(300, 340);
            this.lstCola.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 710);
            this.Controls.Add(this.gbVista);
            this.Controls.Add(this.gbAcciones);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.cmbPrioridad);
            this.Controls.Add(this.lblPrioridad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.gbNueva);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbNueva.ResumeLayout(false);
            this.gbNueva.PerformLayout();
            this.gbAcciones.ResumeLayout(false);
            this.gbVista.ResumeLayout(false);
            this.gbVista.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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

