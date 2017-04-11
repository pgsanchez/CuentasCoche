namespace CuentasCoche
{
    partial class FormNuevoMantenimiento
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.editImporte = new System.Windows.Forms.TextBox();
            this.labelImporte = new System.Windows.Forms.Label();
            this.labelKmTotales = new System.Windows.Forms.Label();
            this.labelKmParciales = new System.Windows.Forms.Label();
            this.editKmTotales = new System.Windows.Forms.TextBox();
            this.editKmParciales = new System.Windows.Forms.TextBox();
            this.editLugar = new System.Windows.Forms.TextBox();
            this.labelLugar = new System.Windows.Forms.Label();
            this.editTaller = new System.Windows.Forms.TextBox();
            this.labelTaller = new System.Windows.Forms.Label();
            this.editDescripcion = new System.Windows.Forms.TextBox();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(72, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // editImporte
            // 
            this.editImporte.Location = new System.Drawing.Point(172, 55);
            this.editImporte.Name = "editImporte";
            this.editImporte.Size = new System.Drawing.Size(100, 20);
            this.editImporte.TabIndex = 1;
            this.editImporte.TextChanged += new System.EventHandler(this.editImporte_TextChanged);
            // 
            // labelImporte
            // 
            this.labelImporte.AutoSize = true;
            this.labelImporte.Location = new System.Drawing.Point(42, 58);
            this.labelImporte.Name = "labelImporte";
            this.labelImporte.Size = new System.Drawing.Size(42, 13);
            this.labelImporte.TabIndex = 2;
            this.labelImporte.Text = "Importe";
            // 
            // labelKmTotales
            // 
            this.labelKmTotales.AutoSize = true;
            this.labelKmTotales.Location = new System.Drawing.Point(42, 98);
            this.labelKmTotales.Name = "labelKmTotales";
            this.labelKmTotales.Size = new System.Drawing.Size(60, 13);
            this.labelKmTotales.TabIndex = 3;
            this.labelKmTotales.Text = "Km Totales";
            // 
            // labelKmParciales
            // 
            this.labelKmParciales.AutoSize = true;
            this.labelKmParciales.Location = new System.Drawing.Point(42, 141);
            this.labelKmParciales.Name = "labelKmParciales";
            this.labelKmParciales.Size = new System.Drawing.Size(68, 13);
            this.labelKmParciales.TabIndex = 4;
            this.labelKmParciales.Text = "Km Parciales";
            // 
            // editKmTotales
            // 
            this.editKmTotales.Location = new System.Drawing.Point(172, 95);
            this.editKmTotales.Name = "editKmTotales";
            this.editKmTotales.Size = new System.Drawing.Size(100, 20);
            this.editKmTotales.TabIndex = 5;
            this.editKmTotales.TextChanged += new System.EventHandler(this.editKmTotales_TextChanged);
            // 
            // editKmParciales
            // 
            this.editKmParciales.Location = new System.Drawing.Point(172, 138);
            this.editKmParciales.Name = "editKmParciales";
            this.editKmParciales.Size = new System.Drawing.Size(100, 20);
            this.editKmParciales.TabIndex = 6;
            this.editKmParciales.TextChanged += new System.EventHandler(this.editKmParciales_TextChanged);
            // 
            // editLugar
            // 
            this.editLugar.Location = new System.Drawing.Point(172, 182);
            this.editLugar.Name = "editLugar";
            this.editLugar.Size = new System.Drawing.Size(100, 20);
            this.editLugar.TabIndex = 7;
            this.editLugar.TextChanged += new System.EventHandler(this.editLugar_TextChanged);
            // 
            // labelLugar
            // 
            this.labelLugar.AutoSize = true;
            this.labelLugar.Location = new System.Drawing.Point(42, 189);
            this.labelLugar.Name = "labelLugar";
            this.labelLugar.Size = new System.Drawing.Size(34, 13);
            this.labelLugar.TabIndex = 8;
            this.labelLugar.Text = "Lugar";
            // 
            // editTaller
            // 
            this.editTaller.Location = new System.Drawing.Point(172, 225);
            this.editTaller.Name = "editTaller";
            this.editTaller.Size = new System.Drawing.Size(100, 20);
            this.editTaller.TabIndex = 9;
            this.editTaller.TextChanged += new System.EventHandler(this.editTaller_TextChanged);
            // 
            // labelTaller
            // 
            this.labelTaller.AutoSize = true;
            this.labelTaller.Location = new System.Drawing.Point(42, 228);
            this.labelTaller.Name = "labelTaller";
            this.labelTaller.Size = new System.Drawing.Size(33, 13);
            this.labelTaller.TabIndex = 10;
            this.labelTaller.Text = "Taller";
            // 
            // editDescripcion
            // 
            this.editDescripcion.Location = new System.Drawing.Point(45, 278);
            this.editDescripcion.Multiline = true;
            this.editDescripcion.Name = "editDescripcion";
            this.editDescripcion.Size = new System.Drawing.Size(227, 72);
            this.editDescripcion.TabIndex = 11;
            this.editDescripcion.TextChanged += new System.EventHandler(this.editDescripcion_TextChanged);
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(42, 262);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(63, 13);
            this.labelDescripcion.TabIndex = 12;
            this.labelDescripcion.Text = "Descripción";
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(197, 372);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 13;
            this.btnOk.Text = "Aceptar";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(45, 372);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormNuevoMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 407);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.editDescripcion);
            this.Controls.Add(this.labelTaller);
            this.Controls.Add(this.editTaller);
            this.Controls.Add(this.labelLugar);
            this.Controls.Add(this.editLugar);
            this.Controls.Add(this.editKmParciales);
            this.Controls.Add(this.editKmTotales);
            this.Controls.Add(this.labelKmParciales);
            this.Controls.Add(this.labelKmTotales);
            this.Controls.Add(this.labelImporte);
            this.Controls.Add(this.editImporte);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "FormNuevoMantenimiento";
            this.Text = "FormNuevoMantenimiento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox editImporte;
        private System.Windows.Forms.Label labelImporte;
        private System.Windows.Forms.Label labelKmTotales;
        private System.Windows.Forms.Label labelKmParciales;
        private System.Windows.Forms.TextBox editKmTotales;
        private System.Windows.Forms.TextBox editKmParciales;
        private System.Windows.Forms.TextBox editLugar;
        private System.Windows.Forms.Label labelLugar;
        private System.Windows.Forms.TextBox editTaller;
        private System.Windows.Forms.Label labelTaller;
        private System.Windows.Forms.TextBox editDescripcion;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}