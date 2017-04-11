namespace CuentasCoche
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNuevoRepostaje = new System.Windows.Forms.Button();
            this.btnNuevoMantenimiento = new System.Windows.Forms.Button();
            this.listaPpal = new System.Windows.Forms.ListView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.edtBuscar = new System.Windows.Forms.TextBox();
            this.listBuscar = new System.Windows.Forms.ListView();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNuevoRepostaje
            // 
            this.btnNuevoRepostaje.Location = new System.Drawing.Point(12, 346);
            this.btnNuevoRepostaje.Name = "btnNuevoRepostaje";
            this.btnNuevoRepostaje.Size = new System.Drawing.Size(100, 23);
            this.btnNuevoRepostaje.TabIndex = 1;
            this.btnNuevoRepostaje.Text = "+ Repostaje";
            this.btnNuevoRepostaje.UseVisualStyleBackColor = true;
            this.btnNuevoRepostaje.Click += new System.EventHandler(this.btnNuevoRepostaje_Click);
            // 
            // btnNuevoMantenimiento
            // 
            this.btnNuevoMantenimiento.Location = new System.Drawing.Point(304, 346);
            this.btnNuevoMantenimiento.Name = "btnNuevoMantenimiento";
            this.btnNuevoMantenimiento.Size = new System.Drawing.Size(107, 23);
            this.btnNuevoMantenimiento.TabIndex = 2;
            this.btnNuevoMantenimiento.Text = "+ Mantenimiento";
            this.btnNuevoMantenimiento.UseVisualStyleBackColor = true;
            this.btnNuevoMantenimiento.Click += new System.EventHandler(this.btnNuevoMantenimiento_Click);
            // 
            // listaPpal
            // 
            this.listaPpal.Location = new System.Drawing.Point(12, 46);
            this.listaPpal.Name = "listaPpal";
            this.listaPpal.Size = new System.Drawing.Size(399, 266);
            this.listaPpal.TabIndex = 4;
            this.listaPpal.UseCompatibleStateImageBehavior = false;
            this.listaPpal.View = System.Windows.Forms.View.Details;
            this.listaPpal.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listaPpal_MouseDoubleClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(5, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(413, 371);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(405, 345);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnBuscar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(405, 345);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(200, 16);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "button1";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // edtBuscar
            // 
            this.edtBuscar.Location = new System.Drawing.Point(51, 46);
            this.edtBuscar.Name = "edtBuscar";
            this.edtBuscar.Size = new System.Drawing.Size(128, 20);
            this.edtBuscar.TabIndex = 6;
            // 
            // listBuscar
            // 
            this.listBuscar.Location = new System.Drawing.Point(15, 94);
            this.listBuscar.Name = "listBuscar";
            this.listBuscar.Size = new System.Drawing.Size(393, 206);
            this.listBuscar.TabIndex = 7;
            this.listBuscar.UseCompatibleStateImageBehavior = false;
            this.listBuscar.View = System.Windows.Forms.View.Details;
            this.listBuscar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBuscar_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 381);
            this.Controls.Add(this.listBuscar);
            this.Controls.Add(this.edtBuscar);
            this.Controls.Add(this.listaPpal);
            this.Controls.Add(this.btnNuevoMantenimiento);
            this.Controls.Add(this.btnNuevoRepostaje);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevoRepostaje;
        private System.Windows.Forms.Button btnNuevoMantenimiento;
        private System.Windows.Forms.ListView listaPpal;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox edtBuscar;
        private System.Windows.Forms.ListView listBuscar;
    }
}

