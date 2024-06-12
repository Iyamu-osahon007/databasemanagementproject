using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductsOrder
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (IsValidLogin())
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                txtpswfd.ForeColor = Color.Red;
                MessageBox.Show("Login Fialed");
                txtpswfd.Text = $"* Invalid password try again";
               
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.Text = Application.ProductName + "- Login";

            txtUserName.Text = Environment.UserName;

            txtPassword.UseSystemPasswordChar = true;
        }

        private bool IsValidLogin()
        {
            string defaultpassword = ConfigurationManager.AppSettings["DefaultPassword"]!.ToString();
            return txtUserName.Text == Environment.UserName
                && txtPassword.Text == defaultpassword;


        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            string errMsg = null;

            if (txt.Text == string.Empty)
            {
                errMsg = $"{txt.Tag} is required.";
                e.Cancel = true;
            }

          

            errorProvider1.SetError(txt, errMsg);

        }

       
    }
}
