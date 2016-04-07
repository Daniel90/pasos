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
    }
}
