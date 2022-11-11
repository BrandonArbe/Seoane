using System;
using System.Data;
using Seoane.Datos;
using Seoane.Entidades;


namespace Seoane.Negocio
{
    public class NCategoria
    {
        public static DataTable Listar()
        {
            DCategoria Datos = new DCategoria();
            return Datos.Listar();
        }
        public static DataTable Buscar(string Valor)
        {
            DCategoria Datos = new DCategoria();
            return Datos.Buscar(Valor);
        }
        public static string Insertar(string Nombre, string Descripcion)
        {
            DCategoria Datos = new DCategoria();
            String Existe = Datos.Existe(Nombre);
            if (Existe.Equals("1"))
            {
                return "DUPLICIDAD: La Categoria ya existe";
            }
            else
            {
                //Referenciamos al obj Entidades.Categoria
                Categoria Obj = new Categoria();
                Obj.Nombre = Nombre;
                Obj.Descripcion = Descripcion;
                return Datos.Insertar(Obj);

            }

        }
        public static string Actualizar(int ID, string NombreAnterior, string Nombre, string Descripcion)
        {
            DCategoria Datos = new DCategoria();
            Categoria Obj = new Categoria();
            if (NombreAnterior.Equals(Nombre))
            {
                //Si no cambia el Nombre -> Actualize
                Obj.IdCategoria = ID;
                Obj.Nombre = Nombre;
                Obj.Descripcion = Descripcion;
                return Datos.Actualizar(Obj);
            }
            else
            {
                //Yo cambio el Nombre, verificamos que no se repita en mi tabla Categorias
                string Existe = Datos.Existe(Nombre);
                if (Existe.Equals("1"))
                {
                    return "La Categoria YA EXISTE";
                }
                else
                {
                    Obj.IdCategoria = ID;
                    Obj.Nombre = Nombre;
                    Obj.Descripcion = Descripcion;
                    return Datos.Actualizar(Obj);
                }
            }

        }

        public static string Eliminar(int ID)
        {
            //Instancio Capa Datos: Clase DCategoria
            DCategoria Datos = new DCategoria();
            //Invoco al metodo Eliminar y le paso el ID (parametro)
            return Datos.Eliminar(ID);
        }
        public static string Activar(int ID)
        {
            //Instancio Capa Datos: Clase DCategoria
            DCategoria Datos = new DCategoria();
            //Invoco al metodo Eliminar y le paso el ID (parametro)
            return Datos.Activar(ID);
        }
        public static string Desactivar(int ID)
        {
            //Invoco al metodo Eliminar y le paso el ID (parametro)
            DCategoria Datos = new DCategoria();
            //Invoco al metodo Eliminar y le paso el ID (parametro)
            return Datos.Desactivar(ID);
        }

    }
}




