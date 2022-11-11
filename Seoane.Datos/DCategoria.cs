using System;
using System.Data;
using System.Data.SqlClient;
using Seoane.Entidades;

namespace Seoane.Datos
{
    public class DCategoria
    {
        //Listar
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
                SqlCommand Comando = new SqlCommand("Categoria_listar", SqlCon);
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
                SqlCommand Comando = new SqlCommand("Categoria_buscar", SqlCon);
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

        public string Existe(string Valor)
        {
            //Variables Respuesta
            String Rpta = "";
            //Almacenamos nuestra conexion
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Instanciar la conexion (Conexion Servidor)
                SqlCon = Conexion.getInstancia().CrearConexion();
                //Llamamos al SP => Categoria:Listar
                SqlCommand Comando = new SqlCommand("Categoria_existe", SqlCon);
                //Indicar que es un SP
                Comando.CommandType = CommandType.StoredProcedure;
                // Indicamos el Valor de Entrada
                Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor;
                //Recibir un parametro de Salida
                SqlParameter ParExiste = new SqlParameter();
                ParExiste.ParameterName = "@existe";
                //Que tipo de parametro (variable) devuelve
                ParExiste.SqlDbType = SqlDbType.Int;
                //Indicar que es un parametro de salida
                ParExiste.Direction = ParameterDirection.Output;
                //Indico parametro de Respuesta @existe
                Comando.Parameters.Add(ParExiste);
                //Abrimos la conexion
                SqlCon.Open();
                //Executar el SP
                Comando.ExecuteNonQuery();
                Rpta = Convert.ToString(ParExiste.Value);
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;

        }

        public string Insertar(Categoria Obj)
        {
            //Variables Respuesta
            String Rpta = "";
            //Almacenamos nuestra conexion
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Instanciar la conexion (Conexion Servidor)
                SqlCon = Conexion.getInstancia().CrearConexion();
                //Llamamos al SP => Categoria:Listar
                SqlCommand Comando = new SqlCommand("Categoria_insertar", SqlCon);
                //Indicar que es un SP
                Comando.CommandType = CommandType.StoredProcedure;
                // Indicamos el Valor de Entrada
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.Nombre;
                Comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = Obj.Descripcion;
                //Abrimos la conexion
                SqlCon.Open();
                //Executar el SP
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo guardar el registro";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;

        }
        public string Actualizar(Categoria Obj)
        {
            //Variables Respuesta
            String Rpta = "";
            //Almacenamos nuestra conexion
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Instanciar la conexion (Conexion Servidor)
                SqlCon = Conexion.getInstancia().CrearConexion();
                //Llamamos al SP => Categoria:Listar
                SqlCommand Comando = new SqlCommand("Categoria_actualizar", SqlCon);
                //Indicar que es un SP
                Comando.CommandType = CommandType.StoredProcedure;
                // Indicamos el Valor de Entrada + ID Actualize
                Comando.Parameters.Add("@idCategoria", SqlDbType.Int).Value = Obj.IdCategoria;
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.Nombre;
                Comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = Obj.Descripcion;
                //Abrimos la conexion
                SqlCon.Open();
                //Executar el SP
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo Actualizar el registro";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;

        }
        public string Eliminar(int Id)
        {
            //Variables Respuesta
            String Rpta = "";
            //Almacenamos nuestra conexion
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Instanciar la conexion (Conexion Servidor)
                SqlCon = Conexion.getInstancia().CrearConexion();
                //Llamamos al SP => Categoria:Listar
                SqlCommand Comando = new SqlCommand("Categoria_eliminar", SqlCon);
                //Indicar que es un SP
                Comando.CommandType = CommandType.StoredProcedure;
                // Indicamos el Valor de Entrada + ID Actualize
                Comando.Parameters.Add("@idCategoria", SqlDbType.Int).Value = Id;
                //Abrimos la conexion
                SqlCon.Open();
                //Executar el SP
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar el registro";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;

        }
        public string Activar(int Id)
        {
            //Variables Respuesta
            String Rpta = "";
            //Almacenamos nuestra conexion
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Instanciar la conexion (Conexion Servidor)
                SqlCon = Conexion.getInstancia().CrearConexion();
                //Llamamos al SP => Categoria:Listar
                SqlCommand Comando = new SqlCommand("Categoria_activar", SqlCon);
                //Indicar que es un SP
                Comando.CommandType = CommandType.StoredProcedure;
                // Indicamos el Valor de Entrada + ID Actualize
                Comando.Parameters.Add("@idCategoria", SqlDbType.Int).Value = Id;
                //Abrimos la conexion
                SqlCon.Open();
                //Executar el SP
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo activar el registro";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;

        }
        public string Desactivar(int Id)
        {
            //Variables Respuesta
            String Rpta = "";
            //Almacenamos nuestra conexion
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Instanciar la conexion (Conexion Servidor)
                SqlCon = Conexion.getInstancia().CrearConexion();
                //Llamamos al SP => Categoria:Listar
                SqlCommand Comando = new SqlCommand("Categoria_desactivar", SqlCon);
                //Indicar que es un SP
                Comando.CommandType = CommandType.StoredProcedure;
                // Indicamos el Valor de Entrada + ID Actualize
                Comando.Parameters.Add("@idCategoria", SqlDbType.Int).Value = Id;
                //Abrimos la conexion
                SqlCon.Open();
                //Executar el SP
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo activar el registro";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;

        }
    }
}
