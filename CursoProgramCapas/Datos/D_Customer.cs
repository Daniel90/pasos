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
        /// <summary>
        /// Método para obtener un registro dependiendo de customerid
        /// </summary>
        /// <param name="CustomerID"></param>
        /// <returns></returns>
        public E_Customer GetOne(int CustomerID)
        {
            E_Customer vRes = new E_Customer();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = CrearComando("Customer_Get");
                cmd.Parameters.AddWithValue("@CustomerId", CustomerID);

                AbrirConexion();
                SqlDataReader consulta = Ejecuta_Consulta(cmd);

                if (consulta.Read())
                {
                    if (consulta.HasRows)
                    {
                        vRes.CustomerId = (int)consulta["CustomerId"];
                        vRes.NameStyle = (Boolean)consulta["NameStyle"];
                        vRes.Title = !(String.IsNullOrEmpty(Convert.ToString(consulta["Title"]))) ? Convert.ToString(consulta["Title"]) : String.Empty;
                        vRes.FirstName = (string)consulta["FirstName"];
                        vRes.MiddleName = !(String.IsNullOrEmpty(Convert.ToString(consulta["MiddleName"]))) ? Convert.ToString(consulta["MiddleName"]) : String.Empty;
                        vRes.LastName = (string)consulta["LastName"];
                        vRes.Suffix = !(String.IsNullOrEmpty(Convert.ToString(consulta["Suffix"]))) ? Convert.ToString(consulta["Suffix"]) : String.Empty;
                        vRes.CompanyName = !(String.IsNullOrEmpty(Convert.ToString(consulta["CompanyName"]))) ? Convert.ToString(consulta["CompanyName"]) : String.Empty;
                        vRes.SalesPerson = !(String.IsNullOrEmpty(Convert.ToString(consulta["SalesPerson"]))) ? Convert.ToString(consulta["SalesPerson"]) : String.Empty;
                        vRes.EmailAddress = !(String.IsNullOrEmpty(Convert.ToString(consulta["EmailAddress"]))) ? Convert.ToString(consulta["EmailAddress"]) : String.Empty;
                        vRes.Phone = !(String.IsNullOrEmpty(Convert.ToString(consulta["Phone"]))) ? Convert.ToString(consulta["Phone"]) : String.Empty;
                        vRes.PasswordHash = (string)consulta["PasswordHash"];
                        vRes.PasswordSalt = (string)consulta["PasswordSalt"];
                        vRes.ModifiedDate = (DateTime)consulta["ModifiedDate"];
                    }
                }
                consulta.Close();
                consulta.Dispose();
            }
            catch (Exception Ex)
            {
                throw new Exception(Ex.Message, Ex);
            }
            finally
            {
                cmd.Dispose();
                CerrarConexion();
            }
            return vRes;
        }
    }
}
