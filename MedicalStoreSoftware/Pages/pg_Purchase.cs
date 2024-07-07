using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalStoreSoftware.Pages
{
    public partial class pg_Purchase : UserControl
    {
        public pg_Purchase()
        {
            InitializeComponent();
        }

        SQLAdapter SQLConnstion = new SQLAdapter(pg_Sell.ConnectionString);


        void UpdateDGV()
        {
            string PurchaseDGVQuery = "SELECT M_ID AS ID, M_Name AS Name, M_Price AS Price, M_Quantity AS Quantity, M_Size AS Size, M_Type AS [Type], M_Company Company FROM Products";
            SQLConnstion.DisplayDGV(dgv_BuyProuducts, PurchaseDGVQuery);
        }

        // Events..................
        private void pg_Purchase_Load(object sender, EventArgs e)
        {
            UpdateDGV();
        }
        private void txtprdSellPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSell_prdAdd_Click(object sender, EventArgs e)
        {
            string Query = "select * from Products where M_Name = '"+ txtSell_prdName.Text +"' AND M_Size = '"+ txtprdSize.Text +"'";
            
            bool Check = SQLConnstion.ReadData(Query);
            if (Check == false)
            {
                if (txtSell_prdName.Text != "" && txtprdSellPrice.Text != "")
                {
                    if (MessageBox.Show("INSERT MEDICINE", "CONFORMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Query = "INSERT INTO [dbo].[Products]([M_Name] ,[M_Price], [M_Quantity] ,[M_Size], [M_Type],[M_Company])VALUES('" + txtSell_prdName.Text + "','" + Convert.ToInt32(txtprdSellPrice.Text) + "','" + Convert.ToInt32(NUD_prdQuantitr.Value) + "','" + txtprdSize.Text + "','" + txtSell_prdtype.Text + "','" + txtprdCompany.Text + "')";
                        
                        SQLConnstion.SQLDataHandler(Query);
                        UpdateDGV();
                        Globals.CleartxtBoes(txtprdID, txtSell_prdName, txtprdSize, txtprdSellPrice, txtprdCompany, txtSell_prdtype);
                    }
                }
                else
                {
                    MessageBox.Show("INSERT Details of MEDICINE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("This medicine is already present in Database", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSell_prdDelete_Click(object sender, EventArgs e)
        {
            if (txtprdID.Text != "")
            {
                if (MessageBox.Show("DELETE MEDICINE", "CONFORMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string Query = "Delete from Products Where M_ID = " + txtprdID.Text;

                    SQLConnstion.SQLDataHandler(Query);
                    UpdateDGV();
                    Globals.CleartxtBoes(txtprdID, txtSell_prdName, txtprdSize, txtprdSellPrice, txtprdCompany, txtSell_prdtype);
                }
            }
            else
            {
                MessageBox.Show("No MEDICINE to DELETE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_BuyProuducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgv_BuyProuducts.Rows[e.RowIndex];

                    txtprdID.Text = row.Cells[0].Value.ToString();
                    txtSell_prdName.Text = row.Cells[1].Value.ToString();
                    txtprdSellPrice.Text = row.Cells[2].Value.ToString();
                    txtprdSize.Text = row.Cells[4].Value.ToString();
                    txtSell_prdtype.Text = row.Cells[5].Value.ToString();
                    txtprdCompany.Text = row.Cells[6].Value.ToString();
                    NUD_prdQuantitr.Value = Convert.ToDecimal(row.Cells[3].Value);
                }
            }
            catch (Exception) { }
        }

        private void btnSell_prdUpdate_Click(object sender, EventArgs e)
        {
            if (txtprdID.Text != "")
            {
                UpdateStoc US = new UpdateStoc(txtprdID.Text, txtSell_prdName.Text, txtprdSellPrice.Text, NUD_prdQuantitr.Value, txtprdSize.Text, txtprdCompany.Text, txtSell_prdtype.Text, dgv_BuyProuducts);
                US.Show();
            }
            else
            {
                MessageBox.Show("No SELECTED Medicine to Update", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
