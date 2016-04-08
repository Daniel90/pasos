using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Data;
using Entidades;
using Datos;

namespace Negocio
{
    public class N_Customer
    {
        D_Customer D_Cus = new D_Customer();
        /// <summary>
        /// Devuelve lo procesado en la capa de datos
        /// </summary>
        /// <returns>2</returns>
        public DataSet GetAll()
        {
            return D_Cus.GetAll();
        }
        public E_Customer GetOne(int CustomerId)
        {
            return D_Cus.GetOne(CustomerId);
        }
    }
}
