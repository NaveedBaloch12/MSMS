using System;
using System.Windows.Forms;
using MedicalStoreSoftware.Controls;
using System.Drawing;
using System.Collections.Generic;

namespace MedicalStoreSoftware.Pages
{
    public partial class pg_Sell : UserControl
    {
        public pg_Sell()
        {
            InitializeComponent();
        }

        // Database Connection......
        public static string ConnectionString = "Data Source=NAVEED-PC;Initial Catalog=MSMS;Integrated Security=True";
        SQLAdapter SQLConnstion = new SQLAdapter(ConnectionString);

        // Variables...............
        public static List<ItemsToBill> ListBill = new List<ItemsToBill>();

        public static int CountPrd = 0, TotalBill = 0, totalprd = 0; public static string  GivenAmmount = "", ReturnAmmount = "", Discount = "";

        // Functions...............
        private void AddItem(UserControl UC)
        {
            UC.Dock = DockStyle.Top;
            panelSellprd.Controls.Add(UC);
        }
        private void Reset()
        {
            TotalBill = 0;
            totalprd = 0;
            CountPrd = 0;
        }

        private void BtnDisale()
        {
            if (panelSellprd.HasChildren != true)
            {
                btnSellClear.Enabled = false;
                btnSell_PrintBill.Enabled = false;
            }
        }

        // Events..................
        private void pg_Sell_Load(object sender, EventArgs e)
        {
            ListBill.Clear();
        }
        private void btnSell_prdAdd_Click(object sender, EventArgs e)
        {
            if (txtSell_prdID.Text != "" && txtSell_prdPrice.Text != "")
            {
                ItemsToBill ITB = new ItemsToBill();

                ITB.prdID = txtSell_prdID.Text;
                ITB.prdName = txtSell_prdName.Text;
                ITB.pricePI = Convert.ToInt32(txtSell_prdPrice.Text);
                ITB.prdQuantity = Convert.ToInt32(nUP_prdQuantitr.Value);
                ITB.prdSize = txtprdSize.Text;

                TotalBill += ITB.TotalPrice();
                totalprd += ITB.prdQuantity;

                // Adding in list
                ListBill.Add(ITB);

                // Reset Information
                Globals.CleartxtBoes(txtSell_prdID, txtSell_prdName, txtSell_prdPrice, txtprdSize);
                nUP_prdQuantitr.Value = 1;

                // Display Sold Item in Panel
                Item SI = new Item(ITB.prdID, ITB.prdName, ITB.pricePI, ITB.prdQuantity, ITB.prdSize);
                AddItem(SI);
                SQLConnstion.UpdateData(ITB.prdID, ITB.prdQuantity);

                txtSell_totalBill.Text = Convert.ToString(TotalBill);
                txtSell_totalPrd.Text = Convert.ToString(totalprd);

                CountPrd++;

                // Enable Buttons
                btnSellClear.Enabled = true;
                btnSell_PrintBill.Enabled = true;
            }
            else
            {
                MessageBox.Show("No Medicine to ADD" ,"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))  e.Handled = true;
        }

        private void txtDiscount_Leave(object sender, EventArgs e)
        {
            try
            {
                TotalBill = TotalBill - Convert.ToInt32(txtDiscount.Text);
                txtSell_totalBill.Text = Convert.ToString(TotalBill);
            }
            catch (Exception) { }
        }

        private void txtGivenAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtSell_returnAmount.Text = Convert.ToString(Convert.ToInt32(txtGivenAmount.Text) - TotalBill);
            }
            catch (Exception) { }
        }

        private void vsbProducts_Scroll(object sender, ScrollEventArgs e)
        {
            panelSellprd.VerticalScroll.Value = vsbProducts.Value;
        }

        private void txtSell_prdName_TextChanged(object sender, EventArgs e)
        {
            string Query = "SELECT M_ID AS ID, M_Name AS Name, M_Price AS Price, M_Quantity AS Quantity, M_Size AS Size, M_Type AS [Type], M_Company Company FROM Products WHERE M_Name like '%"+ txtSell_prdName.Text +"%';";
            SQLConnstion.DisplayDGV(dgvFilterPrd, Query);
            if (txtSell_prdName.Text == "")
            {
                dgvFilterPrd.DataSource = null;
                Globals.CleartxtBoes(txtSell_prdID, txtSell_prdName, txtSell_prdPrice, txtprdSize);
            }
        }


        private void dgvFilterPrd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvFilterPrd.Rows[e.RowIndex];

                    if (row.Cells[0].Value != null)
                        txtSell_prdID.Text = row.Cells[0].Value.ToString();
                    else
                        txtSell_prdID.Text = string.Empty;

                    if (row.Cells[1].Value != null)
                        txtSell_prdName.Text = row.Cells[1].Value.ToString();
                    else
                        txtSell_prdName.Text = string.Empty; 

                    if (row.Cells[2].Value != null)
                        txtSell_prdPrice.Text = row.Cells[2].Value.ToString();
                    else
                        txtSell_prdPrice.Text = string.Empty;

                    if (row.Cells[4].Value != null)
                        txtprdSize.Text = row.Cells[4].Value.ToString();
                    else
                        txtprdSize.Text = string.Empty;
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }
        }

        private void btnSell_PrintBill_Click(object sender, EventArgs e)
        {

            if(txtGivenAmount.Text != "")
                GivenAmmount = txtGivenAmount.Text;
            else
                GivenAmmount = "0";

            if(txtGivenAmount.Text != "")
                ReturnAmmount = txtSell_returnAmount.Text;
            else
                ReturnAmmount = "0";
            if (txtDiscount.Text != "")
                Discount = txtDiscount.Text;
            else
                Discount = "0";

            formPrintBill fPB = new formPrintBill();
            fPB.Show();

            panelSellprd.Controls.Clear();
            Globals.CleartxtBoes(txtSell_totalPrd, txtDiscount, txtGivenAmount, txtSell_returnAmount, txtSell_totalBill);
            BtnDisale();
            Reset();
        }

        private void btnSell_new_Click(object sender, EventArgs e)
        {
            panelSellprd.Controls.Clear();
            for (int i = 0; i < CountPrd; i++)
            {
                // SQLConnstion.UpdateData(SellProduct[i].prdID, -SellProduct[i].prdQuantity);
            }
                Reset();

            Globals.CleartxtBoes(txtSell_totalPrd,txtDiscount, txtGivenAmount, txtSell_returnAmount, txtSell_totalBill);
            BtnDisale();
        }
    }
}
