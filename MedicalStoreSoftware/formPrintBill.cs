using MedicalStoreSoftware.Pages;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MedicalStoreSoftware
{
    public partial class formPrintBill : Form
    {

        public formPrintBill()
        {
            InitializeComponent();
        }

        private void formPrintBill_Load(object sender, EventArgs e)
        {
            try
            {

                ReportParameterCollection RP = new ReportParameterCollection();

                RP.Add(new ReportParameter("GivenAmount", pg_Sell.GivenAmmount));
                RP.Add(new ReportParameter("ReturnAmount", pg_Sell.ReturnAmmount));
                RP.Add(new ReportParameter("Discount", pg_Sell.Discount));
                RP.Add(new ReportParameter("totalItem", Convert.ToString(pg_Sell.totalprd)));
                RP.Add(new ReportParameter("totalPrice", Convert.ToString(pg_Sell.TotalBill)));
                reportViewer1.LocalReport.SetParameters(RP);

                ReportDataSource rds = new ReportDataSource("DataSet1", pg_Sell.ListBill);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);

                reportViewer1.LocalReport.ReportEmbeddedResource = "MedicalStoreSoftware.Report1.rdlc";
                reportViewer1.RefreshReport();
            }
            catch (Exception Exp)
            { MessageBox.Show(Exp.Message);  }
        }
    }
}
