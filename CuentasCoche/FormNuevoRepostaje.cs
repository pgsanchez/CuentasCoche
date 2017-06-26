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
    public partial class FormNuevoRepostaje : Form
    {
        private Repostaje dlgRepostaje = new Repostaje();
        private bool editado = false;
        private bool borrarRepostaje = false; // Indica si hay que borrar este Repostaje.
        public FormNuevoRepostaje()
        {
            InitializeComponent();
            btnEdit.Visible = false;
            btnBorrarRep.Visible = false;
        }

        public FormNuevoRepostaje(Repostaje objRepostaje)
        {
            InitializeComponent();
            editImporte.Text = objRepostaje.Importe.ToString();
            dateTimePicker1.Value = objRepostaje.Fecha;
            editPrecio.Text = objRepostaje.Precio.ToString();
            editLitros.Text = objRepostaje.Litros.ToString();
            editKmTotales.Text = objRepostaje.KmTotales.ToString();
            editLugar.Text = objRepostaje.Lugar;
            editKmParciales.Text = objRepostaje.KmParciales.ToString();
            editImporte.Enabled = false;
            dateTimePicker1.Enabled = false;
            editPrecio.Enabled = false;
            editLitros.Enabled = false;
            editKmTotales.Enabled = false;
            editLugar.Enabled = false;
            btnEdit.Visible = true;
            editKmParciales.Enabled = false;
            btnBorrarRep.Enabled = false;
        }

        private void editImporte_TextChanged(object sender, EventArgs e)
        {
            dlgRepostaje.Importe = Convert.ToSingle(editImporte.Text);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dlgRepostaje.Fecha = dateTimePicker1.Value;
        }

        private void editPrecio_TextChanged(object sender, EventArgs e)
        {
            if (editPrecio.Text == "")
                dlgRepostaje.Precio = 0;
            else 
                dlgRepostaje.Precio = Convert.ToSingle(editPrecio.Text);
            if (dlgRepostaje.Precio > 0)
            {
                dlgRepostaje.Litros = dlgRepostaje.Importe / dlgRepostaje.Precio;
                editLitros.Text = dlgRepostaje.Litros.ToString();
            }
        }

        private void editLitros_TextChanged(object sender, EventArgs e)
        {
            if (editLitros.Text == "")
                dlgRepostaje.Litros = 0;
            else
                dlgRepostaje.Litros = Convert.ToSingle(editLitros.Text);
            if (dlgRepostaje.Litros > 0)
            {
                dlgRepostaje.Precio = dlgRepostaje.Importe / dlgRepostaje.Litros;
                editPrecio.Text = dlgRepostaje.Precio.ToString();
            }
        }

        private void editKmTotales_TextChanged(object sender, EventArgs e)
        {
            dlgRepostaje.KmTotales = Convert.ToInt32(editKmTotales.Text);
        }

        private void editKmParciales_TextChanged(object sender, EventArgs e)
        {

        }

        private void editLugar_TextChanged(object sender, EventArgs e)
        {
            dlgRepostaje.Lugar = editLugar.Text;
        }

        // Funciones Get para devolver los datos
        public float GetLitros()
        {
            return dlgRepostaje.Litros;
        }

        public float GetPrecio()
        {
            return dlgRepostaje.Precio;
        }

        public float GetImporte()
        {
            return dlgRepostaje.Importe;
        }

        public int GetKmTotales()
        {
            return dlgRepostaje.KmTotales;
        }

        public string GetLugar()
        {
            return dlgRepostaje.Lugar;
        }

        public DateTime GetFecha()
        {
            return dlgRepostaje.Fecha;
        }

        public bool GetEditado()
        {
            return editado;
        }

        public bool GetBorrarRepostaje()
        {
            return borrarRepostaje;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Se ponen los KmTotales a 0 para que no se tengan en cuenta ninguno de los valores
            dlgRepostaje.KmTotales = 0;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            editImporte.Enabled = true;
            dateTimePicker1.Enabled = true;
            editPrecio.Enabled = true;
            editLitros.Enabled = true;
            editKmTotales.Enabled = true;
            editLugar.Enabled = true;
            editKmParciales.Enabled = false;
            btnEdit.Enabled = false;
            editado = true;
            btnBorrarRep.Enabled = true;
        }

        private void btnBorrarRep_Click(object sender, EventArgs e)
        {
            // Se ponen los KmTotales a -1 y la variable de borrarRepostaje a true
            // Esto indicará a la ventana padre que hay que borrar esta entrada de 
            // la BD
            dlgRepostaje.KmTotales = -1;
            borrarRepostaje = true;
            this.Close();
        }
    }
}
