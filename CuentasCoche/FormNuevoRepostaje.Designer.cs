namespace CuentasCoche
{
    partial class FormNuevoRepostaje
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
            this.editPrecio = new System.Windows.Forms.TextBox();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelLitros = new System.Windows.Forms.Label();
            this.editLitros = new System.Windows.Forms.TextBox();
            this.editKmTotales = new System.Windows.Forms.TextBox();
            this.labelKmTotales = new System.Windows.Forms.Label();
            this.editKmParciales = new System.Windows.Forms.TextBox();
            this.labelKmParciales = new System.Windows.Forms.Label();
            this.editLugar = new System.Windows.Forms.TextBox();
            this.labelLugar = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
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
            this.editImporte.Location = new System.Drawing.Point(172, 47);
            this.editImporte.Name = "editImporte";
            this.editImporte.Size = new System.Drawing.Size(100, 20);
            this.editImporte.TabIndex = 1;
            this.editImporte.TextChanged += new System.EventHandler(this.editImporte_TextChanged);
            // 
            // labelImporte
            // 
            this.labelImporte.AutoSize = true;
            this.labelImporte.Location = new System.Drawing.Point(29, 50);
            this.labelImporte.Name = "labelImporte";
            this.labelImporte.Size = new System.Drawing.Size(42, 13);
            this.labelImporte.TabIndex = 2;
            this.labelImporte.Text = "Importe";
            // 
            // editPrecio
            // 
            this.editPrecio.Location = new System.Drawing.Point(172, 84);
            this.editPrecio.Name = "editPrecio";
            this.editPrecio.Size = new System.Drawing.Size(100, 20);
            this.editPrecio.TabIndex = 3;
            this.editPrecio.TextChanged += new System.EventHandler(this.editPrecio_TextChanged);
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(29, 87);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(37, 13);
            this.labelPrecio.TabIndex = 4;
            this.labelPrecio.Text = "Precio";
            // 
            // labelLitros
            // 
            this.labelLitros.AutoSize = true;
            this.labelLitros.Location = new System.Drawing.Point(29, 123);
            this.labelLitros.Name = "labelLitros";
            this.labelLitros.Size = new System.Drawing.Size(32, 13);
            this.labelLitros.TabIndex = 5;
            this.labelLitros.Text = "Litros";
            // 
            // editLitros
            // 
            this.editLitros.Location = new System.Drawing.Point(172, 120);
            this.editLitros.Name = "editLitros";
            this.editLitros.Size = new System.Drawing.Size(100, 20);
            this.editLitros.TabIndex = 6;
            this.editLitros.TextChanged += new System.EventHandler(this.editLitros_TextChanged);
            // 
            // editKmTotales
            // 
            this.editKmTotales.Location = new System.Drawing.Point(172, 155);
            this.editKmTotales.Name = "editKmTotales";
            this.editKmTotales.Size = new System.Drawing.Size(100, 20);
            this.editKmTotales.TabIndex = 7;
            this.editKmTotales.TextChanged += new System.EventHandler(this.editKmTotales_TextChanged);
            // 
            // labelKmTotales
            // 
            this.labelKmTotales.AutoSize = true;
            this.labelKmTotales.Location = new System.Drawing.Point(29, 158);
            this.labelKmTotales.Name = "labelKmTotales";
            this.labelKmTotales.Size = new System.Drawing.Size(60, 13);
            this.labelKmTotales.TabIndex = 8;
            this.labelKmTotales.Text = "Km Totales";
            // 
            // editKmParciales
            // 
            this.editKmParciales.Location = new System.Drawing.Point(172, 191);
            this.editKmParciales.Name = "editKmParciales";
            this.editKmParciales.Size = new System.Drawing.Size(100, 20);
            this.editKmParciales.TabIndex = 9;
            this.editKmParciales.TextChanged += new System.EventHandler(this.editKmParciales_TextChanged);
            // 
            // labelKmParciales
            // 
            this.labelKmParciales.AutoSize = true;
            this.labelKmParciales.Location = new System.Drawing.Point(29, 194);
            this.labelKmParciales.Name = "labelKmParciales";
            this.labelKmParciales.Size = new System.Drawing.Size(68, 13);
            this.labelKmParciales.TabIndex = 10;
            this.labelKmParciales.Text = "Km Parciales";
            // 
            // editLugar
            // 
            this.editLugar.Location = new System.Drawing.Point(172, 217);
            this.editLugar.Name = "editLugar";
            this.editLugar.Size = new System.Drawing.Size(100, 20);
            this.editLugar.TabIndex = 11;
            this.editLugar.TextChanged += new System.EventHandler(this.editLugar_TextChanged);
            // 
            // labelLugar
            // 
            this.labelLugar.AutoSize = true;
            this.labelLugar.Location = new System.Drawing.Point(29, 220);
            this.labelLugar.Name = "labelLugar";
            this.labelLugar.Size = new System.Drawing.Size(34, 13);
            this.labelLugar.TabIndex = 12;
            this.labelLugar.Text = "Lugar";
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(197, 259);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 13;
            this.btnOk.Text = "Aceptar";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(32, 259);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(116, 259);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // FormNuevoRepostaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 294);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.labelLugar);
            this.Controls.Add(this.editLugar);
            this.Controls.Add(this.labelKmParciales);
            this.Controls.Add(this.editKmParciales);
            this.Controls.Add(this.labelKmTotales);
            this.Controls.Add(this.editKmTotales);
            this.Controls.Add(this.editLitros);
            this.Controls.Add(this.labelLitros);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.editPrecio);
            this.Controls.Add(this.labelImporte);
            this.Controls.Add(this.editImporte);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "FormNuevoRepostaje";
            this.Text = "FormNuevoRepostaje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox editImporte;
        private System.Windows.Forms.Label labelImporte;
        private System.Windows.Forms.TextBox editPrecio;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelLitros;
        private System.Windows.Forms.TextBox editLitros;
        private System.Windows.Forms.TextBox editKmTotales;
        private System.Windows.Forms.Label labelKmTotales;
        private System.Windows.Forms.TextBox editKmParciales;
        private System.Windows.Forms.Label labelKmParciales;
        private System.Windows.Forms.TextBox editLugar;
        private System.Windows.Forms.Label labelLugar;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
    }
}