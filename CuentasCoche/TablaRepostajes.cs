using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CuentasCoche
{
    class TablaRepostajes
    {

        /* FUNCIONES:
         * private List<Repostaje> LeerBDRepostajes(MySqlConnection conn)
         * private int UpdBDRepostaje(MySqlConnection conn, int idViejoRepostaje, Repostaje nuevoRepostaje)
         * private int AddBDRepostaje(MySqlConnection conn, Repostaje nuevoRepostaje)
         * private int DelBDRepostaje(MySqlConnection conn, Repostaje repostaje)
         */

        // Leer tabla de repostajes
        public List<Repostaje> LeerBDRepostajes(MySqlConnection conn)
        {
            int kmRepostajeAnterior = 0;
            List<Repostaje> listaRepostajesBD = new List<Repostaje>();
            try
            {
                //idGastoActual = 0;
                conn.Open();
                // Se obtienen los registros en orden ascendente ordenados por KmTotales (que será el id), ya que
                // es la manera más fácil de calcular los KmParciales.
                // Una vez rellenada la lista (con los KmParciales calculados), se invierte el orden de la lista
                // ya que es mejor mostrarla de mayor a menor kilometraje.
                MySqlCommand instruccion = conn.CreateCommand();
                instruccion.CommandText = "SELECT fecha, kmTotales, lugar, importe, litros, precio from Repostajes order by kmTotales";
                MySqlDataReader reader = instruccion.ExecuteReader();
                while (reader.Read())
                {
                    Repostaje obj = new Repostaje();
                    obj.Fecha = reader.GetDateTime("fecha");
                    obj.KmTotales = reader.GetInt32("kmTotales");
                    obj.Lugar = reader["lugar"].ToString();
                    obj.Importe = reader.GetFloat("importe");
                    obj.Litros = reader.GetFloat("litros");
                    obj.Precio = reader.GetFloat("precio");
                    obj.KmParciales = obj.KmTotales - kmRepostajeAnterior;
                    kmRepostajeAnterior = obj.KmTotales;
                    listaRepostajesBD.Add(obj);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // Invertimos el orden de la lista para tener los elementos ordenados por km de mayor a menor
            listaRepostajesBD.Reverse();
            return listaRepostajesBD;
        }

        // Actualizar Repostaje en BD
        public int UpdBDRepostaje(MySqlConnection conn, int idViejoRepostaje, Repostaje nuevoRepostaje)
        {
            try
            {
                conn.Open();
                MySqlCommand instruccion = conn.CreateCommand();
                instruccion.CommandText = "update Repostajes set fecha = '" + nuevoRepostaje.Fecha.ToString("yyyy-MM-dd") + "', kmTotales = '" + nuevoRepostaje.KmTotales + "', lugar = '" + nuevoRepostaje.Lugar + "', importe = '" + nuevoRepostaje.Importe + "', litros = '" + nuevoRepostaje.Litros + "', precio = '" + nuevoRepostaje.Precio + "' where kmTotales = '" + idViejoRepostaje + "';";
                instruccion.ExecuteReader();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return 0;
        }

        // Añadir Repostaje a la BD
        public int AddBDRepostaje(MySqlConnection conn, Repostaje nuevoRepostaje)
        {
            try
            {
                conn.Open();
                MySqlCommand instruccion = conn.CreateCommand();
                instruccion.CommandText = "insert into Repostajes(fecha, kmTotales, lugar, importe, litros, precio) values('" + nuevoRepostaje.Fecha.ToString("yyyy-MM-dd") + "','" + nuevoRepostaje.KmTotales + "','" + nuevoRepostaje.Lugar + "','" + nuevoRepostaje.Importe + "','" + nuevoRepostaje.Litros + "','" + nuevoRepostaje.Precio + "');";
                instruccion.ExecuteReader();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return 0;
        }

        // Borrar Repostaje de la BD
        public int DelBDRepostaje(MySqlConnection conn, Repostaje repostaje)
        {
            try
            {
                conn.Open();
                MySqlCommand instruccion = conn.CreateCommand();
                instruccion.CommandText = "delete from Repostajes where kmTotales = '" + repostaje.KmTotales + "';";
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
