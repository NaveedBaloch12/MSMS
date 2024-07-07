using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalStoreSoftware.Pages
{
    public partial class UpdateStoc : Form
    {
        String ID, Name, Size, Company, Price, Type;
        decimal Quantity;
        DataGridView DGV;
        SQLAdapter SQLConnstion = new SQLAdapter(pg_Sell.ConnectionString);


        public UpdateStoc(string id, string name, string price, decimal quantity, string size, string company, string type, DataGridView dgv)
        {
            InitializeComponent();
            ID = id;
            Name = name;
            Price = price;
            Quantity = quantity;
            Size = size;
            Company = company;
            Type = type;
            DGV = dgv;
        }

        private void UpdateStoc_Load(object sender, EventArgs e)
        {
            txtID.Text = ID;
            txtName.Text = Name;
            txtPrice.Text = Price;
            NUD_Quantity.Value = Quantity;
            txtSize.Text = Size;
            txtCompany.Text = Company;
            txtType.Text = Type;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string Query = "UPDATE Products SET M_Price = " + txtPrice.Text + ", M_Quantity = " + NUD_Quantity.Value + ", M_Size = '" + txtSize.Text + "', M_Type = '" + txtType.Text + "', M_Company = '" + txtCompany.Text + "' WHERE M_ID = " + ID;
            SQLConnstion.SQLDataHandler(Query);

            string PurchaseDGVQuery = "SELECT M_ID AS ID, M_Name AS Name, M_Price AS Price, M_Quantity AS Quantity, M_Size AS Size, M_Type AS [Type], M_Company Company FROM Products";
            SQLConnstion.DisplayDGV(DGV, PurchaseDGVQuery);
            this.Close();
        }


    }
}
