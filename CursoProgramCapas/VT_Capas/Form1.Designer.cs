namespace VT_Capas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGCustomer = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.chkNameStyle = new System.Windows.Forms.CheckBox();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSuffix = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSalesPerson = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPassHash = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPassSalt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // DGCustomer
            // 
            this.DGCustomer.AllowUserToAddRows = false;
            this.DGCustomer.AllowUserToDeleteRows = false;
            this.DGCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGCustomer.Location = new System.Drawing.Point(12, 279);
            this.DGCustomer.Name = "DGCustomer";
            this.DGCustomer.ReadOnly = true;
            this.DGCustomer.Size = new System.Drawing.Size(795, 223);
            this.DGCustomer.TabIndex = 0;
            this.DGCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGCustomer_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Id:";
            // 
            // chkNameStyle
            // 
            this.chkNameStyle.AutoSize = true;
            this.chkNameStyle.Location = new System.Drawing.Point(260, 21);
            this.chkNameStyle.Name = "chkNameStyle";
            this.chkNameStyle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkNameStyle.Size = new System.Drawing.Size(80, 17);
            this.chkNameStyle.TabIndex = 2;
            this.chkNameStyle.Text = "Name Style";
            this.chkNameStyle.UseVisualStyleBackColor = true;
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(103, 19);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(120, 20);
            this.txtCustomerId.TabIndex = 3;
            this.txtCustomerId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerId_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(463, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(496, 18);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(124, 20);
            this.txtTitle.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "First Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(103, 56);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(237, 20);
            this.txtFirstName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Middle Name";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(449, 59);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(290, 20);
            this.txtMiddleName.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Last Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(103, 90);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(237, 20);
            this.txtLastName.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(410, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Suffix:";
            // 
            // txtSuffix
            // 
            this.txtSuffix.Location = new System.Drawing.Point(449, 96);
            this.txtSuffix.Name = "txtSuffix";
            this.txtSuffix.Size = new System.Drawing.Size(100, 20);
            this.txtSuffix.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Company";
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(104, 123);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(236, 20);
            this.txtCompany.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(410, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Sales";
            // 
            // txtSalesPerson
            // 
            this.txtSalesPerson.Location = new System.Drawing.Point(449, 127);
            this.txtSalesPerson.Name = "txtSalesPerson";
            this.txtSalesPerson.Size = new System.Drawing.Size(100, 20);
            this.txtSalesPerson.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Email Address";
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(104, 162);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(236, 20);
            this.txtEmailAddress.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(405, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Phone";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(449, 157);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(143, 20);
            this.txtPhone.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 198);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Pass Hash";
            // 
            // txtPassHash
            // 
            this.txtPassHash.Location = new System.Drawing.Point(103, 198);
            this.txtPassHash.Name = "txtPassHash";
            this.txtPassHash.Size = new System.Drawing.Size(305, 20);
            this.txtPassHash.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(37, 236);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Pass Salt";
            // 
            // txtPassSalt
            // 
            this.txtPassSalt.Location = new System.Drawing.Point(104, 236);
            this.txtPassSalt.Name = "txtPassSalt";
            this.txtPassSalt.Size = new System.Drawing.Size(190, 20);
            this.txtPassSalt.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(654, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Fecha";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(697, 16);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 27;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(819, 514);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtPassSalt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtPassHash);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSalesPerson);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSuffix);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.chkNameStyle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGCustomer);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkNameStyle;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSuffix;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSalesPerson;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPassHash;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPassSalt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtFecha;


    }
}

