using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Seoane.Datos
{
    public class Conexion
    {
        //AGREGAR PROPIEDADES DB, Servidor, Usuario y clave
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;
        //TIPO DE AUTENTICACION
        private bool Seguridad;
        //DECLARAMOS EL OBJETO CONEXION
        private static Conexion Con = null;
        private Conexion()
        {
            this.Base = "dbseoane";
            this.Servidor = "DESKTOP-V65CB82\\SQLEXPRESS";
            this.Usuario = "";
            this.Clave = "";
            this.Seguridad = true;

        }
        public SqlConnection CrearConexion()
        {
            SqlConnection Cadena = new SqlConnection();
            try
            {
                Cadena.ConnectionString = "Server=" + this.Servidor + ";Database=" + this.Base + ";";
                if (this.Seguridad)
                {
                    //SEGURIDAD VERDADERO = AUTENTICACION DE WINDOWS
                    Cadena.ConnectionString = Cadena.ConnectionString + "Integrated Security = SSPI";
                }
                else
                {
                    //SEGURIdAD FALSO = AUTENTICACION SQL
                    Cadena.ConnectionString = Cadena.ConnectionString + "User Id=" + this.Usuario + ";Password=" + this.Clave;

                }

            }
            catch (Exception ex)
            {
                Cadena = null;
                throw ex;
            }
            return Cadena;
        }
        public static Conexion getInstancia()
        {
            if (Con == null)
            {
                Con = new Conexion();
            }
            return Con;
        }
    }
}


