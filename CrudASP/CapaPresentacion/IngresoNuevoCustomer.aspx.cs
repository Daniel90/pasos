using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaEntidad;
using CapaNegocio;
using CapaEntidad.Enumeradores;
using System.Globalization;
using System.Threading;

namespace CapaPresentacion
{
    public partial class IngresoNuevoCustomer : System.Web.UI.Page
    {
        CustomerNegocio customerNegocio = new CustomerNegocio();
        Customer customer = new Customer();
        Insercion insercion = new Insercion();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public string en_GBFormat()
        {
            DateTime now = DateTime.Now;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB");
            return now.ToString("d");
        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            try 
	        {
                        
		        customer.NameStyle = (chkNameStyle.Checked) ? true : false;
                customer.Title = txtTitle.Text;
                customer.FirstName = txtFirstName.Text;
                customer.MiddleName = txtMiddleName.Text;
                customer.LastName = txtLastName.Text;
                customer.Suffix = txtSuffix.Text;
                customer.CompanyName = txtCompanyName.Text;
                customer.SalesPerson = txtSalesPerson.Text;
                customer.EmailAddress = txtEmail.Text;
                customer.Phone = txtPhone.Text;
                customer.ModifiedDate = Convert.ToDateTime(en_GBFormat());
                customer.CustomerRut = txtRut.Text;
                customer.CustomerDV = txtDV.Text;
                customer.Password = customerNegocio.cifrarClave(txtPassword.Text);           
                switch (customerNegocio.ValidaInsert(customer))
                {
                    case Insercion.Exitosa:
                        Response.Write("<script type='text/javascript'> alert('EXITO') </script>");
                        break;
                    case Insercion.Erronea:
                        Response.Write("<script type='text/javascript'> alert('hubo un error') </script>");
                        break;
                    case Insercion.ErrorNoControlado:
                        Response.Write("<script type='text/javascript'> alert('hubo un error') </script>");
                        break;
                }
	        }
	        catch (Exception ex)
	        {
                Response.Write("<script type='text/javascript'> alert('hubo un error') </script>");
	        }
                 
        }

        
    }
}