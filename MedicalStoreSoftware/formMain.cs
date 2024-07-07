using MedicalStoreSoftware.Pages;
using System;
using System.Windows.Forms;

namespace MedicalStoreSoftware
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();

        }
        // Define Some global Controls
        Button btnprev;

        // Functions....................
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void activeButton(Button btn)
        {
            // Set btnprev to enabled
            try
            {
                btnprev.Enabled = true;
                btnprev.BackColor = Globals.navbarColor;
                btnprev.ForeColor = Globals.header_navbar_txt_Color;
            }
            catch (Exception) { }

            //  Set clicked button disabled
            btn.BackColor = Globals.headerColor;
            btn.Enabled = false;
            btnprev = btn;
        }

        // Events........................
        private void formMain_Load(object sender, EventArgs e)
        {
            activeButton(btnHome);
        }

        public void btnHome_Click(object sender, EventArgs e)
        {
            activeButton(btnHome);
            panelMain.Controls.Clear();
            panelMain.Controls.Add(panelHeader);
            panelHeader.Dock = DockStyle.Top;

            panelMain.Controls.Add(tlpButtons);
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            activeButton(btnSell);
            pg_Sell UC = new pg_Sell();
            addUserControl(UC);

            Globals.footerText(lbdecs, "Ready ", true);
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            activeButton(btnPurchase);
            pg_Purchase UC = new pg_Purchase();
            addUserControl(UC);

            Globals.footerText(lbdecs, "Ready ", true);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            activeButton(btnHistory);
            pg_History UC = new pg_History();
            addUserControl(UC);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            activeButton(btnReport);
            pg_Report UC = new pg_Report();
            addUserControl(UC);

            Globals.footerText(lbdecs, "View Report ", true);
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            activeButton(btnStock);
            pg_Stock UC = new pg_Stock();
            addUserControl(UC);

            Globals.footerText(lbdecs, "View Stock ", true);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            activeButton(btnSetting);
            pg_Setting UC = new pg_Setting();
            addUserControl(UC);

            Globals.footerText(lbdecs, "Change Settings", true);
        }
    }
}
