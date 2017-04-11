using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace CuentasCoche
{
    public partial class Form1 : Form
    {
        // Prueba: escribo esta línea para ver si aparece en github
        // Para mostrar la información necesitamos:
        // Una lista de todos los Repostajes: listaRep
        // Una lista de todos los Mantenimientos: listaMant
        List<Repostaje> listaRep = new List<Repostaje>();
        List<Mantenimiento> listaMant = new List<Mantenimiento>();
        TablaRepostajes mTablaRepostajes = new TablaRepostajes();
        TablaMantenimiento mTablaMantenimiento = new TablaMantenimiento();
        List<Mantenimiento> listaMantAux = new List<Mantenimiento>();

        MySqlConnection conn = new MySqlConnection();
        String cadenaConexion;

        public Form1()
        {
            InitializeComponent();

            // Columnas Lista Principal
            listaPpal.Columns.Add("Icon", 40);
            listaPpal.Columns.Add("Fecha", 80);
            listaPpal.Columns.Add("Km", 80);
            listaPpal.Columns.Add("Importe", 60);
            listaPpal.Columns.Add("Km Parciales", 80);

            // Columnas Lista Buscar
            listBuscar.Columns.Add("Icon", 40);
            listBuscar.Columns.Add("Fecha", 80);
            listBuscar.Columns.Add("Km", 80);
            listBuscar.Columns.Add("Importe", 60);
            listBuscar.Columns.Add("Reparación", 200);

            // Datos de conexión de la BD y abrirla.
            cadenaConexion = "Server=127.0.0.1; Database=pruebaspedro; Uid=root; Pwd=''";
            conn.ConnectionString = cadenaConexion;

            // Se leen las listas de la BD y se actualiza la vista.
            LeerListaRepostajesBD();
            LeerListaMantenimientosBD();
            ConfigAparienciaDlg();
            //ActualizarListaPpal();
            ActualizarListaPpal2();
        }




        private int LeerListaRepostajesBD()
        {
            // Leer lista de Repostajes
            listaRep.Clear();
            listaRep = mTablaRepostajes.LeerBDRepostajes(conn);
            return 0;
        }

        private int LeerListaMantenimientosBD()
        {
            // Leer lista de Mantenimientos
            listaMant.Clear();
            listaMant = mTablaMantenimiento.LeerBDMantenimiento(conn);
            return 0;
        }

        private int ActualizarListaPpal()
        {

            listaPpal.Items.Clear();
            foreach (Repostaje repostaje in listaRep)
            {
                ListViewItem item1 = new ListViewItem("Repost.", 0);
                item1.SubItems.Add(repostaje.Fecha.ToShortDateString());
                item1.SubItems.Add(repostaje.KmTotales.ToString());
                item1.SubItems.Add(repostaje.Importe.ToString());
                item1.SubItems.Add(repostaje.KmParciales.ToString());
                listaPpal.Items.Add(item1);
            }

            foreach (Mantenimiento mantenimiento in listaMant)
            {
                ListViewItem item1 = new ListViewItem("Taller", 0);
                item1.SubItems.Add(mantenimiento.Fecha.ToShortDateString());
                item1.SubItems.Add(mantenimiento.KmTotales.ToString());
                item1.SubItems.Add(mantenimiento.Importe.ToString());
                listaPpal.Items.Add(item1);
            }

            // habría que ordenar la lista por KmTotales
            //listaPpal.Sort();
            return 0;
        }

        private int ActualizarListaPpal2()
        {
            List<Repostaje>.Enumerator it1 = listaRep.GetEnumerator() ;
            List<Mantenimiento>.Enumerator it2 = listaMant.GetEnumerator();
            bool finLista1 = false;
            bool finLista2 = false;

            if (!it1.MoveNext())
                finLista1 = true;
            if (!it2.MoveNext())
                finLista2 = true;

            while ((!finLista1) && (!finLista2))
            {
                if (it1.Current.KmTotales >= it2.Current.KmTotales)
                {
                    ListViewItem item1 = new ListViewItem("Repost.", 0);
                    // Se añade it1
                    item1.SubItems.Add(it1.Current.Fecha.ToShortDateString());
                    item1.SubItems.Add(it1.Current.KmTotales.ToString());
                    item1.SubItems.Add(it1.Current.Importe.ToString());
                    listaPpal.Items.Add(item1);
                    // Se avanza it1 y se mira si ha llegado al final
                    if (!it1.MoveNext())
                        finLista1 = true;
                }
                else
                {
                    ListViewItem item1 = new ListViewItem("Taller", 0);
                    // Se añade it2
                    item1.SubItems.Add(it2.Current.Fecha.ToShortDateString());
                    item1.SubItems.Add(it2.Current.KmTotales.ToString());
                    item1.SubItems.Add(it2.Current.Importe.ToString());
                    listaPpal.Items.Add(item1);
                    // Se avanza it2 y se mira si ha llegado al final
                    if (!it2.MoveNext())
                        finLista2 = true;
                }

                if (finLista1)
                {
                    // Se añaden todos los elementos que faltan de lista2:
                    while (!finLista2)
                    {
                        ListViewItem item2 = new ListViewItem("Taller", 0);
                        item2.SubItems.Add(it2.Current.Fecha.ToShortDateString());
                        item2.SubItems.Add(it2.Current.KmTotales.ToString());
                        item2.SubItems.Add(it2.Current.Importe.ToString());
                        listaPpal.Items.Add(item2);
                        // Se avanza it2 y se mira si ha llegado al final
                        if (!it2.MoveNext())
                            finLista2 = true;
                    }
                }
                if (finLista2)
                {
                    // Se añaden todos los elementos que faltan de lista1
                    while (!finLista1)
                    {
                        ListViewItem item2 = new ListViewItem("Repost.", 0);
                        item2.SubItems.Add(it1.Current.Fecha.ToShortDateString());
                        item2.SubItems.Add(it1.Current.KmTotales.ToString());
                        item2.SubItems.Add(it1.Current.Importe.ToString());
                        listaPpal.Items.Add(item2);
                        // Se avanza it2 y se mira si ha llegado al final
                        if (!it1.MoveNext())
                            finLista1 = true;
                    }
                }
            }



            return 0;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }

        private void btnNuevoRepostaje_Click(object sender, EventArgs e)
        {
            FormNuevoRepostaje frmNuevoRep = new FormNuevoRepostaje();
            frmNuevoRep.ShowDialog();
            Repostaje nuevoRep = new Repostaje();
            if (frmNuevoRep.GetKmTotales() == 0)
                return;

            nuevoRep.Litros = frmNuevoRep.GetLitros();
            nuevoRep.Precio = frmNuevoRep.GetPrecio();
            nuevoRep.Importe = frmNuevoRep.GetImporte();
            nuevoRep.KmTotales = frmNuevoRep.GetKmTotales();
            nuevoRep.Lugar = frmNuevoRep.GetLugar();
            nuevoRep.Fecha = frmNuevoRep.GetFecha();

            // Añadir el nuevo Repostaje a la BD
            mTablaRepostajes.AddBDRepostaje(conn, nuevoRep);

            // Actualizar la lista de Repostajes y la pantalla Ppal
            LeerListaRepostajesBD();
            ActualizarListaPpal();
        }

        private void btnNuevoMantenimiento_Click(object sender, EventArgs e)
        {
            FormNuevoMantenimiento frmNuevoMant = new FormNuevoMantenimiento();
            frmNuevoMant.ShowDialog();
            Mantenimiento nuevoMant = new Mantenimiento();
            if (frmNuevoMant.GetKmTotales() == 0)
                return;

            nuevoMant.Reparacion = frmNuevoMant.GetReparacion();
            nuevoMant.Taller = frmNuevoMant.GetTaller();
            nuevoMant.Lugar = frmNuevoMant.GetLugar();
            nuevoMant.KmTotales = frmNuevoMant.GetKmTotales();
            nuevoMant.Importe = frmNuevoMant.GetImporte();
            nuevoMant.Fecha = frmNuevoMant.GetFecha();

            // Añadir el nuevo Mantenimiento a la BD
            mTablaMantenimiento.AddBDMantenimiento(conn, nuevoMant);

            // Actualizar la lista de Mantenimentos y la pantalla Ppal
            LeerListaMantenimientosBD();
            ActualizarListaPpal();
        }

        private void ConfigAparienciaDlg()
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0: // Pestaña Principal
                    listaPpal.Visible = true;
                    btnNuevoMantenimiento.Visible = true;
                    btnNuevoRepostaje.Visible = true;
                    edtBuscar.Visible = false;
                    btnBuscar.Visible = false;
                    listBuscar.Visible = false;
                    break;
                case 1: // Pestaña de busquedas
                    listaPpal.Visible = false;
                    btnNuevoMantenimiento.Visible = false;
                    btnNuevoRepostaje.Visible = false;
                    edtBuscar.Visible = true;
                    btnBuscar.Visible = true;
                    listBuscar.Visible = true;
                    break;

                default:
                    break;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfigAparienciaDlg();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listaMantAux.Clear();
            listBuscar.Items.Clear();
            String textoABuscar = edtBuscar.Text;
            int index = 0;
            // Recorrer la lista de mantenimientos y buscar ahí
            foreach (Mantenimiento it in listaMant)
            {
                index = it.Reparacion.ToUpper().IndexOf(textoABuscar.ToUpper());
                if (index > 0)
                {
                    // Cadena encontrada
                    // Añadir a la lista
                    listaMantAux.Add(it);
                    ListViewItem item1 = new ListViewItem("Taller.", 0);
                    item1.SubItems.Add(it.Fecha.ToShortDateString());
                    item1.SubItems.Add(it.KmTotales.ToString());
                    item1.SubItems.Add(it.Importe.ToString());
                    item1.SubItems.Add(it.Reparacion);
                    listBuscar.Items.Add(item1);
                }
            }
        }

        private void listBuscar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Abrir la ventana del detalle del repostaje o mantenimiento
                foreach (Mantenimiento it in listaMantAux)
                {
                    String tmp = listBuscar.SelectedItems[0].SubItems[2].Text;
                    int a = String.Compare(it.KmTotales.ToString(), tmp);

                    if (String.Compare(it.KmTotales.ToString(), tmp) == 0)
                    {
                        FormNuevoMantenimiento frmNuevoMant = new FormNuevoMantenimiento(it);
                        frmNuevoMant.ShowDialog();
                    }
                }

        }

        private void listaPpal_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Abrir la ventana del detalle del repostaje o mantenimiento
            if (String.Compare(listaPpal.SelectedItems[0].SubItems[0].Text, "Repost.") == 0)
            {
                foreach (Repostaje it in listaRep)
                {
                    String tmp = listaPpal.SelectedItems[0].SubItems[2].Text;
                    int a = String.Compare(it.KmTotales.ToString(), tmp);

                    if (String.Compare(it.KmTotales.ToString(), tmp) == 0)
                    {
                        FormNuevoRepostaje frmNuevoRep = new FormNuevoRepostaje(it);
                        frmNuevoRep.ShowDialog();
                    }
                }
            }
            else
            {
                foreach (Mantenimiento it in listaMant)
                {
                    String tmp = listaPpal.SelectedItems[0].SubItems[2].Text;
                    int a = String.Compare(it.KmTotales.ToString(), tmp);

                    if (String.Compare(it.KmTotales.ToString(), tmp) == 0)
                    {
                        FormNuevoMantenimiento frmNuevoMant = new FormNuevoMantenimiento(it);
                        frmNuevoMant.ShowDialog();
                    }
                }
            }
            
        }
    }
}
