using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class D_Customer : CAD
    {
        /// <summary>
        /// Devuelve todos los registros de la tabla customer
        /// </summary>
        /// <returns></returns>
        public DataSet GetAll()
        {
            DataSet ds = new DataSet();
            try
            {
                SqlCommand cmd = CrearComando("Customer_Get");
                ds = GetDS(cmd, "Customer_Get");
            }
            catch (Exception Ex)
            {
                throw new Exception("Error obteniendo todos los registros " + Ex.Message, Ex);
            }
            return ds;
        }
    }
}
