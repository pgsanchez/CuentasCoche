using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CuentasCoche
{
    public class Repostaje
    {
        // Atributos de la clase
        private float litros = 0;
        private float precio = 0;
        private float importe = 0;

        private int kmTotales = 0; // Será también el ID 
        private string lugar = "";
        private DateTime fecha = System.DateTime.Today;

        private int kmParciales = 0; // Se calcula. No se guarda en la BD

        // Propiedades de los atributos (set/get)
        public float Litros
        {
            set
            {
                litros = value;
            }
            get
            {
                return litros;
            }
        }

        public float Precio
        {
            set
            {
                precio = value;
            }
            get
            {
                return precio;
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

        public int KmParciales
        {
            set
            {
                kmParciales = value;
            }
            get
            {
                return kmParciales;
            }
        }
    }
}
