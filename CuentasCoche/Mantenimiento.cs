using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CuentasCoche
{
    public class Mantenimiento
    {
        // Atributos de la clase
        private string reparacion = "";
        private string taller = "";
        private string lugar = "";
        private int kmTotales = 0; // será también el ID
        private float importe = 0;
        private DateTime fecha = System.DateTime.Today;

        // Propiedades de los atributos (set/get)
        public string Reparacion
        {
            set
            {
                reparacion = value;
            }
            get
            {
                return reparacion;
            }
        }
        public string Taller
        {
            set
            {
                taller = value;
            }
            get
            {
                return taller;
            }
        }
        public string Lugar
        {
            set
            {
                lugar = value;
            }
            get
            {
                return lugar;
            }
        }
        public int KmTotales
        {
            set
            {
                kmTotales = value;
            }
            get
            {
                return kmTotales;
            }
        }
        public float Importe
        {
            set
            {
                importe = value;
            }
            get
            {
                return importe;
            }
        }
        public DateTime Fecha
        {
            set
            {
                fecha = value;
            }
            get
            {
                return fecha;
            }
        }
    }
}
