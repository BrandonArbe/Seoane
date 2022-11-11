using System;
using System.Data;
using System.Data.SqlClient;
using Seoane.Entidades;

namespace Seoane.Datos
{
    public class DArticulo
    {
        public DataTable Listar()
        {
            //Variables
            SqlDataReader Resultado;
            //Instanciamos obj tabla
            DataTable Tabla = new DataTable();
            //Almacenamos nuestra conexion
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Instanciar la conexion (Conexion Servidor)
                SqlCon = Conexion.getInstancia().CrearConexion();
                //Llamamos al SP => Categoria:Listar
                SqlCommand Comando = new SqlCommand("articulo_listar", SqlCon);
                //Indicar que es un SP
                Comando.CommandType = CommandType.StoredProcedure;
                //Abrimos la conexion
                SqlCon.Open();
                //Executar el SP
                Resultado = Comando.ExecuteReader();
                //Cargar la Respuesta en nuestra Tabla
                Tabla.Load(Resultado);
                return (Tabla);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }
        //Buscar
        public DataTable Buscar(string Valor)
        {
            //Variables
            SqlDataReader Resultado;
            //Instanciamos obj tabla
            DataTable Tabla = new DataTable();
            //Almacenamos nuestra conexion
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Instanciar la conexion (Conexion Servidor)
                SqlCon = Conexion.getInstancia().CrearConexion();
                //Llamamos al SP => Categoria:Listar
                SqlCommand Comando = new SqlCommand("articulo_buscar", SqlCon);
                //Indicar que es un SP
                Comando.CommandType = CommandType.StoredProcedure;
                // Indicamos el Valor de Entrada
                Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor;
                //Abrimos la conexion
                SqlCon.Open();
                //Executar el SP
                Resultado = Comando.ExecuteReader();
                //Cargar la Respuesta en nuestra Tabla
                Tabla.Load(Resultado);
                return (Tabla);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }
    }
}
