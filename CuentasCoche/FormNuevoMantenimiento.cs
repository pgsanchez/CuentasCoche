using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CuentasCoche
{
    public partial class FormNuevoMantenimiento : Form
    {
        private Mantenimiento dlgMantenimiento = new Mantenimiento();
        private bool editado = false;
        public FormNuevoMantenimiento()
        {
            InitializeComponent();
            btnEdit2.Visible = false;
        }

        public FormNuevoMantenimiento(Mantenimiento objMantenimiento)
        {
            InitializeComponent();
            dateTimePicker1.Value = objMantenimiento.Fecha;
            editImporte.Text = objMantenimiento.Importe.ToString();
            editKmTotales.Text = objMantenimiento.KmTotales.ToString();
            editLugar.Text = objMantenimiento.Lugar;
            editKmParciales.Text = objMantenimiento.KmParciales.ToString();
            editTaller.Text = objMantenimiento.Taller;
            editDescripcion.Text = objMantenimiento.Reparacion;
            dateTimePicker1.Enabled = false;
            editImporte.Enabled = false;
            editKmTotales.Enabled = false;
            editLugar.Enabled = false;
            editTaller.Enabled = false;
            editDescripcion.Enabled = false;
            btnEdit2.Visible = true;
            editKmParciales.Enabled = false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dlgMantenimiento.Fecha = dateTimePicker1.Value;
        }

        private void editImporte_TextChanged(object sender, EventArgs e)
        {
            if (editImporte.Text == "")
                dlgMantenimiento.Importe = 0;
            else
                dlgMantenimiento.Importe = Convert.ToSingle(editImporte.Text);
        }

        private void editKmTotales_TextChanged(object sender, EventArgs e)
        {
            if (editKmTotales.Text == "")
                dlgMantenimiento.KmTotales = 0;
            else
                dlgMantenimiento.KmTotales = Convert.ToInt32(editKmTotales.Text);
        }

        private void editKmParciales_TextChanged(object sender, EventArgs e)
        {

        }

        private void editLugar_TextChanged(object sender, EventArgs e)
        {
            dlgMantenimiento.Lugar = editLugar.Text;
        }

        private void editTaller_TextChanged(object sender, EventArgs e)
        {
            dlgMantenimiento.Taller = editTaller.Text;
        }

        private void editDescripcion_TextChanged(object sender, EventArgs e)
        {
            dlgMantenimiento.Reparacion = editDescripcion.Text;
        }

        // Funciones Get para devolver los datos
        public string GetReparacion()
        {
            return dlgMantenimiento.Reparacion;
        }

        public string GetTaller()
        {
            return dlgMantenimiento.Taller;
        }

        public string GetLugar()
        {
            return dlgMantenimiento.Lugar;
        }

        public int GetKmTotales()
        {
            return dlgMantenimiento.KmTotales;
        }

        public float GetImporte()
        {
            return dlgMantenimiento.Importe;
        }

        public DateTime GetFecha()
        {
            return dlgMantenimiento.Fecha;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Se ponen los KmTotales a 0 para que no se tengan en cuenta ninguno de los valores
            dlgMantenimiento.KmTotales = 0;
        }

        private void btnEdit2_Click(object sender, EventArgs e)
        {
            editImporte.Enabled = true;
            dateTimePicker1.Enabled = true;
            editKmTotales.Enabled = true;
            editLugar.Enabled = true;
            editKmParciales.Enabled = false;
            editTaller.Enabled = true;
            editDescripcion.Enabled = true;
            btnEdit2.Enabled = false;
            editado = true;
        }
    }
}
