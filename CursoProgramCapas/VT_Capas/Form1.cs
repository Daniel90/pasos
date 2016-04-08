using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Entidades;

namespace VT_Capas
{
    public partial class Form1 : Form
    {
        P_Customer oCliente = new P_Customer();
        E_Customer oCliente_Ent = new E_Customer();
        public Form1()
        {
            InitializeComponent();
        }

        private void IniDG()
        {
            try
            {
                DGCustomer.DataSource = oCliente.GetAll().Tables[0];
                DGCustomer.Refresh();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IniDG();
        }

        private void txtCustomerId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                int CustId = Convert.ToInt32(txtCustomerId.Text);
                try
                {
                    oCliente_Ent = oCliente.GetOne(CustId);

                    chkNameStyle.Checked = oCliente_Ent.NameStyle;
                    txtTitle.Text = oCliente_Ent.Title;
                    txtFirstName.Text = oCliente_Ent.FirstName;
                    txtMiddleName.Text = oCliente_Ent.MiddleName;
                    txtLastName.Text = oCliente_Ent.LastName;
                    txtSuffix.Text = oCliente_Ent.Suffix;
                    txtCompany.Text = oCliente_Ent.CompanyName;
                    txtSalesPerson.Text = oCliente_Ent.SalesPerson;
                    txtEmailAddress.Text = oCliente_Ent.EmailAddress;
                    txtPhone.Text = oCliente_Ent.Phone;
                    txtPassHash.Text = oCliente_Ent.PasswordHash;
                    txtPassSalt.Text = oCliente_Ent.PasswordSalt;
                    txtFecha.Text = oCliente_Ent.ModifiedDate.ToString("dd-MM-yyyy");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void DGCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)DGCustomer.Rows[e.RowIndex].Cells[0].Value;
            txtCustomerId.Text = Convert.ToString(id);
            txtCustomerId_KeyPress(sender, new KeyPressEventArgs((char)Keys.Return));
        }

      
    }
}
