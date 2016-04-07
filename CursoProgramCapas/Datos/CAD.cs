using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DEBSAccesoSQL;
using System.Data.SqlClient;
namespace Datos
{
    public class CAD : DEBSAccesoDatos
    {
        //Cambios
        public CAD() 
        {
            cConex = "Data Source=.;Initial Catalog=AdventureWorksLT2008R2;User=admin;Password=admin;Trusted_Connection=No;";
            conexion = new SqlConnection(cConex);
        }
    }
}
