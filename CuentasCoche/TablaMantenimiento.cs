using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CuentasCoche
{
    class TablaMantenimiento
    {
        // Leer tabla de mantenimientos
        public List<Mantenimiento> LeerBDMantenimiento(MySqlConnection conn)
        {
            int kmMantenimientoAnterior = 0;
            List<Mantenimiento> listaMantenimientoBD = new List<Mantenimiento>();
            try
            {
                conn.Open();
                MySqlCommand instruccion = conn.CreateCommand();
                instruccion.CommandText = "SELECT fecha, kmTotales, lugar, importe, taller, reparacion from Mantenimientos order by kmTotales";
                MySqlDataReader reader = instruccion.ExecuteReader();
                while (reader.Read())
                {
                    Mantenimiento obj = new Mantenimiento();
                    obj.Fecha = reader.GetDateTime("fecha");
                    obj.KmTotales = reader.GetInt32("kmTotales");
                    obj.Lugar = reader["lugar"].ToString();
                    obj.Importe = reader.GetFloat("importe");
                    obj.Taller = reader["taller"].ToString();
                    obj.Reparacion = reader["reparacion"].ToString();
                    obj.KmParciales = obj.KmTotales - kmMantenimientoAnterior;
                    kmMantenimientoAnterior = obj.KmTotales;
                    listaMantenimientoBD.Add(obj);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            listaMantenimientoBD.Reverse();
            return listaMantenimientoBD;
        }

        // Actualizar Mantenimiento en BD
        public int UpdBDMantenimiento(MySqlConnection conn, int idViejoMantenimiento, Mantenimiento nuevoMantenimiento)
        {
            try
            {
                conn.Open();
                MySqlCommand instruccion = conn.CreateCommand();
                instruccion.CommandText = "update Mantenimientos set fecha = '" + nuevoMantenimiento.Fecha.ToString("yyyy-MM-dd") + "', kmTotales = '" + nuevoMantenimiento.KmTotales + "', lugar = '" + nuevoMantenimiento.Lugar + "', importe = '" + nuevoMantenimiento.Importe + "', taller = '" + nuevoMantenimiento.Taller + "', reparacion = '" + nuevoMantenimiento.Reparacion + "' where kmTotales = '" + idViejoMantenimiento + "';";
                instruccion.ExecuteReader();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return 0;
        }

        // Añadir Mantenimiento a la BD
        public int AddBDMantenimiento(MySqlConnection conn, Mantenimiento nuevoMantenimiento)
        {
            try
            {
                conn.Open();
                MySqlCommand instruccion = conn.CreateCommand();
                instruccion.CommandText = "insert into Mantenimientos(fecha, kmTotales, lugar, importe, taller, reparacion) values('" + nuevoMantenimiento.Fecha.ToString("yyyy-MM-dd") + "','" + nuevoMantenimiento.KmTotales + "','" + nuevoMantenimiento.Lugar + "','" + nuevoMantenimiento.Importe + "','" + nuevoMantenimiento.Taller + "','" + nuevoMantenimiento.Reparacion + "');";
                instruccion.ExecuteReader();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return 0;
        }

        // Borrar Mantenimiento de la BD
        public int DelBDMantenimiento(MySqlConnection conn, Mantenimiento mantenimiento)
        {
            try
            {
                conn.Open();
                MySqlCommand instruccion = conn.CreateCommand();
                instruccion.CommandText = "delete from Mantenimientos where kmTotales = '" + mantenimiento.KmTotales + "';";
                instruccion.ExecuteReader();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return 0;
        }

    }
}
