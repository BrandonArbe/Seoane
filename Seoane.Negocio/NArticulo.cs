using System;
using System.Data;
using Seoane.Datos;
using Seoane.Entidades;


namespace Seoane.Negocio
{
    public class NArticulo
    {
        public static DataTable Listar()
        {
            DArticulo Datos = new DArticulo();
            return Datos.Listar();
        }
        public static DataTable Buscar(string Valor)
        {
            DArticulo Datos = new DArticulo();
            return Datos.Buscar(Valor);
        }

    }

}
