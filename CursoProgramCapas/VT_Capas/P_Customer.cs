using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Data;
using Entidades;
using Negocio;

namespace VT_Capas
{
    public class P_Customer
    {
        N_Customer N_Cus = new N_Customer();

        public DataSet GetAll()
        {
            return N_Cus.GetAll();
        }
    }
}
