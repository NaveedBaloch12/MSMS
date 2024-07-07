using MedicalStoreSoftware.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalStoreSoftware
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        // Naveed_Hassan@123            P@sword_12345

        SQLAdapter SQLConnstion = new SQLAdapter(pg_Sell.ConnectionString);
        bool Check = false;
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "" && txtPassword.Text != "")
            {
                string Query = "Select * from MedicalUsers WHERE UName = '" + txtUserName.Text + "' AND UPassword = '" + txtPassword.Text +"'";
                Check = SQLConnstion.ReadData(Query);
                if (Check == true)
                {
                    this.Hide();
                    var form2 = new formMain();
                    form2.FormClosed += (s, agr) => this.Close();
                    form2.Show();
                }
                else
                {
                    MessageBox.Show("WRONG UserName or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter UserName or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
